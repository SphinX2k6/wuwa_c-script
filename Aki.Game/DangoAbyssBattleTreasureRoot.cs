using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EEC RID: 3820
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssBattleTreasureRoot : UiPanelBase
{
	// Token: 0x06009930 RID: 39216 RVA: 0x002D680A File Offset: 0x002D4A0A
	public void InitItem(UUIItem rootItem, UUIItem templateItem)
	{
		this.CurrentCopyRootItem = rootItem;
		this.CurrentCopyTemplateItem = templateItem;
	}

	// Token: 0x06009931 RID: 39217 RVA: 0x002D681C File Offset: 0x002D4A1C
	public UniTask Init(Dictionary<int, int> rewardItemMap, float fullTime)
	{
		DangoAbyssBattleTreasureRoot.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.rewardItemMap = rewardItemMap;
		<Init>d__.fullTime = fullTime;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoAbyssBattleTreasureRoot.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009932 RID: 39218 RVA: 0x002D6870 File Offset: 0x002D4A70
	public void RefreshRewardItem(float progress)
	{
		foreach (DangoAbyssBattleTreasureItem dangoAbyssBattleTreasureItem in this.DangoAbyssBattleTreasureItemList)
		{
			dangoAbyssBattleTreasureItem.RefreshByCurrentPercentage(progress);
		}
	}

	// Token: 0x04005BA9 RID: 23465
	[Nullable(2)]
	private UUIItem CurrentCopyRootItem;

	// Token: 0x04005BAA RID: 23466
	[Nullable(2)]
	private UUIItem CurrentCopyTemplateItem;

	// Token: 0x04005BAB RID: 23467
	private readonly List<UUIItem> RewardItemList = new List<UUIItem>();

	// Token: 0x04005BAC RID: 23468
	private readonly List<DangoAbyssBattleTreasureItem> DangoAbyssBattleTreasureItemList = new List<DangoAbyssBattleTreasureItem>();
}
