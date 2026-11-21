using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000846 RID: 2118
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MowingTowerRewardItem : GridProxyAbstract<IActivityRewardData>
{
	// Token: 0x06005FF6 RID: 24566 RVA: 0x001EA3D4 File Offset: 0x001E85D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickButton))
		};
	}

	// Token: 0x06005FF7 RID: 24567 RVA: 0x001EA4A9 File Offset: 0x001E86A9
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
	}

	// Token: 0x06005FF8 RID: 24568 RVA: 0x001EA4CC File Offset: 0x001E86CC
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06005FF9 RID: 24569 RVA: 0x001EA4D4 File Offset: 0x001E86D4
	public override void Refresh(IActivityRewardData data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		if (data.NameTextArgs != null)
		{
			base.GetText(1).SetText(data.NameTextArgs[1] + "/" + data.NameTextArgs[0], true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "BossRushRewardText", new <>z__ReadOnlySingleElementList<object>(data.NameTextArgs[0]));
		}
		base.GetButton(4).RootUIComp.Get().SetUIActive(data.RewardState == EActivityRewardState.Enable);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(data.RewardState == EActivityRewardState.Disabled);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(data.RewardState == EActivityRewardState.Claimed);
		}
		List<TItem> data2 = (data.RewardList != null) ? new List<TItem>(data.RewardList) : new List<TItem>();
		GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
		if (itemLayout == null)
		{
			return;
		}
		itemLayout.RefreshByData(data2, null, false);
	}

	// Token: 0x06005FFA RID: 24570 RVA: 0x001EA5C0 File Offset: 0x001E87C0
	private void OnClickButton()
	{
		IActivityRewardData rewardData = this.RewardData;
		if (rewardData == null)
		{
			return;
		}
		Action clickFunction = rewardData.ClickFunction;
		if (clickFunction == null)
		{
			return;
		}
		clickFunction();
	}

	// Token: 0x04003EEC RID: 16108
	[Nullable(2)]
	private IActivityRewardData RewardData;

	// Token: 0x04003EED RID: 16109
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;
}
