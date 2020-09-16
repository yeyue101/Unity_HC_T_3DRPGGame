using UnityEngine;

[System.Serializable]
public class NewPlayableAsset : PlayableAsset
{
    #region 欄位
    [Header(移動速度), Range(0, 100]
    public float speed = 1.5f;
    [Header(攻擊), Range(0, 100)]
    public float attack = 20f;
    [Header(血量), Range(0, 1000)]
    public float hp = 350f;
    #region 方法

    #region 事件




}
