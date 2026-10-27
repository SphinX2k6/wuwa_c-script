using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

// Token: 0x0200308A RID: 12426
[NullableContext(2)]
[Nullable(0)]
public class SpecialTagConfig
{
	// Token: 0x0601A8BD RID: 108733 RVA: 0x0071BE4C File Offset: 0x0071A04C
	public void Init(BaseTagComponent tagComp = null, BP_SpecialTagConfig_C asset = null, Func<double, bool> check = null)
	{
		if (asset == null || tagComp == null)
		{
			return;
		}
		int tag = asset.SpecialTagListener.SpecialTagListener.TagId();
		List<int> list = new List<int>();
		TArray<FGameplayTag> gameplayTags = asset.SpecialTagListener.ForbidTagList.GameplayTags;
		for (int i = 0; i < gameplayTags.Num(); i++)
		{
			list.Add(gameplayTags.Get(i).TagId());
		}
		List<int> list2 = new List<int>();
		TArray<FGameplayTag> gameplayTags2 = asset.SpecialTagListener.TargetTagList.GameplayTags;
		for (int j = 0; j < gameplayTags2.Num(); j++)
		{
			list2.Add(gameplayTags2.Get(j).TagId());
		}
		this.TagListenerInfo = new SpecialTagListener();
		this.TagListenerInfo.InitTagListener(tagComp, tag, list, list2, check);
	}

	// Token: 0x0601A8BE RID: 108734 RVA: 0x0071BF12 File Offset: 0x0071A112
	public void Clear()
	{
		SpecialTagListener tagListenerInfo = this.TagListenerInfo;
		if (tagListenerInfo == null)
		{
			return;
		}
		tagListenerInfo.ClearTagListener();
	}

	// Token: 0x0601A8BF RID: 108735 RVA: 0x0071BF24 File Offset: 0x0071A124
	public void UpdateCondition(double delta)
	{
		SpecialTagListener tagListenerInfo = this.TagListenerInfo;
		if (tagListenerInfo == null)
		{
			return;
		}
		tagListenerInfo.UpdateCondition(delta);
	}

	// Token: 0x0400CBFA RID: 52218
	private SpecialTagListener TagListenerInfo;
}
