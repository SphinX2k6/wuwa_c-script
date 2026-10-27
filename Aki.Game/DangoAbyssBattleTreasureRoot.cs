using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A2D RID: 6701
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssBattleTreasureRoot : UiPanelBase
{
	// Token: 0x0600C520 RID: 50464 RVA: 0x002CB6EA File Offset: 0x002C98EA
	public void InitItem(UUIItem rootItem, UUIItem templateItem)
	{
		this.CurrentCopyRootItem = rootItem;
		this.CurrentCopyTemplateItem = templateItem;
	}

	// Token: 0x0600C521 RID: 50465 RVA: 0x002CB6FC File Offset: 0x002C98FC
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

	// Token: 0x0600C522 RID: 50466 RVA: 0x002CB750 File Offset: 0x002C9950
	public void RefreshRewardItem(float progress)
	{
		foreach (DangoAbyssBattleTreasureItem dangoAbyssBattleTreasureItem in this.DangoAbyssBattleTreasureItemList)
		{
			dangoAbyssBattleTreasureItem.RefreshByCurrentPercentage(progress);
		}
	}

	// Token: 0x04005ADA RID: 23258
	[Nullable(2)]
	private UUIItem CurrentCopyRootItem;

	// Token: 0x04005ADB RID: 23259
	[Nullable(2)]
	private UUIItem CurrentCopyTemplateItem;

	// Token: 0x04005ADC RID: 23260
	private readonly List<UUIItem> RewardItemList = new List<UUIItem>();

	// Token: 0x04005ADD RID: 23261
	private readonly List<DangoAbyssBattleTreasureItem> DangoAbyssBattleTreasureItemList = new List<DangoAbyssBattleTreasureItem>();
}
