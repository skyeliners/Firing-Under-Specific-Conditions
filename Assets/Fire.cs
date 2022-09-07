using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public bool inArea;
    public GameObject prefab;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if(inArea && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab,player.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Orb")
        {
            inArea = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            inArea = false;
    }
}
