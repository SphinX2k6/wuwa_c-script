using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200263B RID: 9787
[NullableContext(1)]
[Nullable(0)]
public class RotateBonesParams
{
	// Token: 0x1700265D RID: 9821
	// (get) Token: 0x060186E4 RID: 100068 RVA: 0x007609FC File Offset: 0x0075EBFC
	// (set) Token: 0x060186E5 RID: 100069 RVA: 0x00760A04 File Offset: 0x0075EC04
	public long Handle { get; private set; }

	// Token: 0x060186E6 RID: 100070 RVA: 0x00760A10 File Offset: 0x0075EC10
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

	// Token: 0x060186E7 RID: 100071 RVA: 0x00760A74 File Offset: 0x0075EC74
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

	// Token: 0x060186E8 RID: 100072 RVA: 0x00760B08 File Offset: 0x0075ED08
	public bool IsEnd()
	{
		return this.RotateBoneItemMap.Count == 0 || (this.GoingToEnd && this.CurrentTime >= this.TimeLength);
	}

	// Token: 0x060186E9 RID: 100073 RVA: 0x00760B34 File Offset: 0x0075ED34
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

	// Token: 0x0400D2EB RID: 53995
	private readonly Dictionary<string, RotateBoneItem> RotateBoneItemMap = new Dictionary<string, RotateBoneItem>();

	// Token: 0x0400D2EC RID: 53996
	private float CurrentTime;

	// Token: 0x0400D2ED RID: 53997
	private float TimeLength = 1f;

	// Token: 0x0400D2EE RID: 53998
	public bool GoingToEnd;
}
