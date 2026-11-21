using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144E RID: 5198
public class ReputationRewardsView : UiViewBase
{
	// Token: 0x0600CEC1 RID: 52929 RVA: 0x003D77AA File Offset: 0x003D59AA
	[NullableContext(1)]
	public ReputationRewardsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CEC2 RID: 52930 RVA: 0x003D77B4 File Offset: 0x003D59B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CEC3 RID: 52931 RVA: 0x003D77FC File Offset: 0x003D59FC
	protected override void OnBeforeCreate()
	{
		int id = (int)this.OpenParam;
		this.Influence = InfluenceReputationModel.Instance.GetInfluenceInstance(id);
	}

	// Token: 0x0600CEC4 RID: 52932 RVA: 0x003D7826 File Offset: 0x003D5A26
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<InfluenceRewardItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceRewardItem>(this.InitItem), null);
	}

	// Token: 0x0600CEC5 RID: 52933 RVA: 0x003D7848 File Offset: 0x003D5A48
	[NullableContext(1)]
	private ILayoutItem<InfluenceRewardItem> InitItem(object data, UUIItem uiItem, int index)
	{
		InfluenceRewardItem influenceRewardItem = new InfluenceRewardItem(uiItem);
		bool isReceived = this.Influence.RewardIndex >= index;
		influenceRewardItem.UpdateItem((IntPair)data, isReceived);
		return new LayoutItem<InfluenceRewardItem>
		{
			Key = index,
			Value = influenceRewardItem
		};
	}

	// Token: 0x0600CEC6 RID: 52934 RVA: 0x003D7894 File Offset: 0x003D5A94
	protected override void OnAfterShow()
	{
		this.ScrollView.RefreshByData<IntPair>(this.Influence.GetReward(), null);
	}

	// Token: 0x0600CEC7 RID: 52935 RVA: 0x003D78C0 File Offset: 0x003D5AC0
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
	}

	// Token: 0x04007595 RID: 30101
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceRewardItem> ScrollView;

	// Token: 0x04007596 RID: 30102
	[Nullable(2)]
	private InfluenceInstance Influence;

	// Token: 0x020076FB RID: 30459
	private enum EReputationRewardsView
	{
		// Token: 0x04026A73 RID: 158323
		ScrollView
	}
}
