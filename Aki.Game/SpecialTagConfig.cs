using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

// Token: 0x020025E1 RID: 9697
[NullableContext(2)]
[Nullable(0)]
public class SpecialTagConfig
{
	// Token: 0x060182A4 RID: 98980 RVA: 0x00742204 File Offset: 0x00740404
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

	// Token: 0x060182A5 RID: 98981 RVA: 0x007422CA File Offset: 0x007404CA
	public void Clear()
	{
		SpecialTagListener tagListenerInfo = this.TagListenerInfo;
		if (tagListenerInfo == null)
		{
			return;
		}
		tagListenerInfo.ClearTagListener();
	}

	// Token: 0x060182A6 RID: 98982 RVA: 0x007422DC File Offset: 0x007404DC
	public void UpdateCondition(double delta)
	{
		SpecialTagListener tagListenerInfo = this.TagListenerInfo;
		if (tagListenerInfo == null)
		{
			return;
		}
		tagListenerInfo.UpdateCondition(delta);
	}

	// Token: 0x0400CFDD RID: 53213
	private SpecialTagListener TagListenerInfo;
}
