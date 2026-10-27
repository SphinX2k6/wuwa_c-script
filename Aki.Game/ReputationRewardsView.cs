using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8C RID: 8076
public class ReputationRewardsView : UiViewBase
{
	// Token: 0x0600FAA2 RID: 64162 RVA: 0x003CBC72 File Offset: 0x003C9E72
	[NullableContext(1)]
	public ReputationRewardsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FAA3 RID: 64163 RVA: 0x003CBC7C File Offset: 0x003C9E7C
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

	// Token: 0x0600FAA4 RID: 64164 RVA: 0x003CBCC4 File Offset: 0x003C9EC4
	protected override void OnBeforeCreate()
	{
		int id = (int)this.OpenParam;
		this.Influence = InfluenceReputationModel.Instance.GetInfluenceInstance(id);
	}

	// Token: 0x0600FAA5 RID: 64165 RVA: 0x003CBCEE File Offset: 0x003C9EEE
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<InfluenceRewardItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceRewardItem>(this.InitItem), null);
	}

	// Token: 0x0600FAA6 RID: 64166 RVA: 0x003CBD10 File Offset: 0x003C9F10
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

	// Token: 0x0600FAA7 RID: 64167 RVA: 0x003CBD5C File Offset: 0x003C9F5C
	protected override void OnAfterShow()
	{
		this.ScrollView.RefreshByData<IntPair>(this.Influence.GetReward().ToList<IntPair>(), null);
	}

	// Token: 0x0600FAA8 RID: 64168 RVA: 0x003CBD8D File Offset: 0x003C9F8D
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
	}

	// Token: 0x040074B4 RID: 29876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceRewardItem> ScrollView;

	// Token: 0x040074B5 RID: 29877
	[Nullable(2)]
	private InfluenceInstance Influence;

	// Token: 0x02008576 RID: 34166
	private enum EReputationRewardsView
	{
		// Token: 0x0402B750 RID: 178000
		ScrollView
	}
}
