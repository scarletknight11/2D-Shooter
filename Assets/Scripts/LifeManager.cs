using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour {

    public GameObject Life1, Life2, Life3;
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Life1.SetActive(true);
        Life2.SetActive(true);
        Life3.SetActive(true);

    }

    void Update()
    {
        if(health == 3 && gameObject.tag == "EnemyBullet")
        {
            Debug.Log("hit");
        }
    }

    // Update is called once per frame
    public void LifeTake()
    {
        
      
    }

     void TriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemyBullet")
        {
            health -= 1;
            Life1.SetActive(false);
            Debug.Log("Hit");
        }
    }
}
