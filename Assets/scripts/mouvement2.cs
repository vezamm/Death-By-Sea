using UnityEngine;
using System.Collections;
public class mouvement2 : MonoBehaviour
{
    Health health;
    public float speed;
    

    // Use this for initialization
    void Start()
    {
        health = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = new Vector2 (0,0);
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            moveDirection.x = 1;
           
        }
        else if (horizontal < 0)
        {
            moveDirection.x = -1;
           
        }
        else if (vertical > 0)
        {
            moveDirection.y = 1;
           
        }
        else if (vertical < 0)
        {
            moveDirection.y = -1;
           
        }
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="bullet") {
            health.health--;
        
        }
    }
}