using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022AE RID: 8878
public class WeeklyRogueRewardPreviewView : UiViewBase
{
	// Token: 0x06015EC2 RID: 89794 RVA: 0x0065B200 File Offset: 0x00659400
	[NullableContext(1)]
	public WeeklyRogueRewardPreviewView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EC3 RID: 89795 RVA: 0x0065B20C File Offset: 0x0065940C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06015EC4 RID: 89796 RVA: 0x0065B268 File Offset: 0x00659468
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

	// Token: 0x06015EC5 RID: 89797 RVA: 0x0065B2DD File Offset: 0x006594DD
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0400B860 RID: 47200
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x02008511 RID: 34065
	private enum EComponents
	{
		// Token: 0x0402AE48 RID: 175688
		TxtDesc,
		// Token: 0x0402AE49 RID: 175689
		GridLayout,
		// Token: 0x0402AE4A RID: 175690
		GridItem
	}
}
