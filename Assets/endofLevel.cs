using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endofLevel : MonoBehaviour
{
    
    public void EndOfGame()
    {
        SceneManager.LoadScene("FPS");
    }
}
