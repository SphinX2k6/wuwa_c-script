using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D54 RID: 11604
public class WeeklyRogueRewardPreviewView : UiViewBase
{
	// Token: 0x06018620 RID: 99872 RVA: 0x006351F0 File Offset: 0x006333F0
	[NullableContext(1)]
	public WeeklyRogueRewardPreviewView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06018621 RID: 99873 RVA: 0x006351FC File Offset: 0x006333FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06018622 RID: 99874 RVA: 0x00635258 File Offset: 0x00633458
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(1), new Func<CommonItemSmallItemGrid>(this.InitCommonGridItem), null, false, true);
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		if (activityDataNew == null)
		{
			return;
		}
		this.ItemLayout.RefreshByData(ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(activityDataNew.GetCycleConfig().Value.BlackFlowerAward, new int?(activityDataNew.WorldLevel)), null, false);
	}

	// Token: 0x06018623 RID: 99875 RVA: 0x006352CD File Offset: 0x006334CD
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0400B4EB RID: 46315
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x020092EA RID: 37610
	private enum EComponents
	{
		// Token: 0x0402F7C0 RID: 194496
		TxtDesc,
		// Token: 0x0402F7C1 RID: 194497
		GridLayout,
		// Token: 0x0402F7C2 RID: 194498
		GridItem
	}
}
