using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030E3 RID: 12515
[NullableContext(1)]
[Nullable(0)]
public class RotateBonesParams
{
	// Token: 0x170024D3 RID: 9427
	// (get) Token: 0x0601ACC8 RID: 109768 RVA: 0x0073AFC0 File Offset: 0x007391C0
	// (set) Token: 0x0601ACC9 RID: 109769 RVA: 0x0073AFC8 File Offset: 0x007391C8
	public long Handle { get; private set; }

	// Token: 0x0601ACCA RID: 109770 RVA: 0x0073AFD4 File Offset: 0x007391D4
	public RotateBonesParams(long handle, TArray<string> bones)
	{
		this.Handle = handle;
		int num = bones.Num();
		for (int i = 0; i < num; i++)
		{
			string text = bones.Get(i);
			if (!string.IsNullOrEmpty(text))
			{
				this.RotateBoneItemMap[text] = new RotateBoneItem();
			}
		}
	}

	// Token: 0x0601ACCB RID: 109771 RVA: 0x0073B038 File Offset: 0x00739238
	public void Set(float timeLength, float targetAlpha, Dictionary<string, float> currentAlphaMap)
	{
		this.CurrentTime = 0f;
		this.TimeLength = timeLength;
		foreach (KeyValuePair<string, RotateBoneItem> keyValuePair in this.RotateBoneItemMap)
		{
			float startAlpha = 0f;
			currentAlphaMap.TryGetValue(keyValuePair.Key, out startAlpha);
			keyValuePair.Value.Set(startAlpha, targetAlpha, null);
		}
		this.GoingToEnd = (targetAlpha <= 0f);
	}

	// Token: 0x0601ACCC RID: 109772 RVA: 0x0073B0CC File Offset: 0x007392CC
	public bool IsEnd()
	{
		return this.RotateBoneItemMap.Count == 0 || (this.GoingToEnd && this.CurrentTime >= this.TimeLength);
	}

	// Token: 0x0601ACCD RID: 109773 RVA: 0x0073B0F8 File Offset: 0x007392F8
	public void GetAndUpdate(float deltaTime, Dictionary<string, float> outAlphaMap)
	{
		this.CurrentTime += deltaTime;
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, RotateBoneItem> keyValuePair in this.RotateBoneItemMap)
		{
			if (outAlphaMap.ContainsKey(keyValuePair.Key))
			{
				list.Add(keyValuePair.Key);
			}
			else
			{
				outAlphaMap[keyValuePair.Key] = keyValuePair.Value.GetBoneAlpha(this.CurrentTime / this.TimeLength);
			}
		}
		foreach (string key in list)
		{
			this.RotateBoneItemMap.Remove(key);
		}
	}

	// Token: 0x0400CEFB RID: 52987
	private readonly Dictionary<string, RotateBoneItem> RotateBoneItemMap = new Dictionary<string, RotateBoneItem>();

	// Token: 0x0400CEFC RID: 52988
	private float CurrentTime;

	// Token: 0x0400CEFD RID: 52989
	private float TimeLength = 1f;

	// Token: 0x0400CEFE RID: 52990
	public bool GoingToEnd;
}
