using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollectorV2 : MonoBehaviour
{ 
   private int cherries = 0;

   [SerializeField] private Text cherriesText;
   private void OnTriggerEnter2D(Collider2D collision) {
         if (collision.gameObject.tag == "Cherry")
          {
               Destroy(collision.gameObject);
               cherries++;
               cherriesText.text = "cerise : " + cherries;
         }
   }
     
}
