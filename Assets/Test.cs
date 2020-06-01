using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic(int magicAttack)
    {
       
        
        if(mp > 5)
        {
            
            for (int mpcut = 53;  mpcut >= magicAttack; mpcut -= magicAttack  )
            {
                mp -= magicAttack  ;
                Debug.Log("魔法攻撃をした。残りMPは" +   mp  );
            }
        }
        else 
        {
            Debug.Log("MPが足りないため魔法攻撃が使えない。");
        }
    }

    

}
public class Test : MonoBehaviour
{
    int[] array = { 10, 20, 30, 40, 50 };
    private void Start()
    {
        ascendingorder();
        descendingorder();

        Boss boss = new Boss();

        boss.Magic(5);
        boss.Magic(5);
    }
    
   private void ascendingorder()
    {
       
            for (int i = 0; i < array.Length ; i++)
            {

                Debug.Log(array[i]);
            }
           
        
    }

    private void descendingorder()
    {
        int i;
        for ( i = array.Length - 1; i < array .Length;    i--)
        {
            
            Debug.Log(array[i]);
            if (i == 0)
            {
                break;
            }
            
        }
        
    }
}

