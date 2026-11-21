using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020006AC RID: 1708
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingRewardItem : UiPanelBase, IGridProxy<ActivityCorniceMeetingRewardItemData>
{
	// Token: 0x17000AA3 RID: 2723
	// (get) Token: 0x06004E89 RID: 20105 RVA: 0x001A7359 File Offset: 0x001A5559
	// (set) Token: 0x06004E8A RID: 20106 RVA: 0x001A7361 File Offset: 0x001A5561
	public IScrollViewDelegate<IGridProxy<ActivityCorniceMeetingRewardItemData>, ActivityCorniceMeetingRewardItemData> ScrollViewDelegate { get; set; }

	// Token: 0x17000AA4 RID: 2724
	// (get) Token: 0x06004E8B RID: 20107 RVA: 0x001A736A File Offset: 0x001A556A
	// (set) Token: 0x06004E8C RID: 20108 RVA: 0x001A7372 File Offset: 0x001A5572
	public int GridIndex { get; set; }

	// Token: 0x17000AA5 RID: 2725
	// (get) Token: 0x06004E8D RID: 20109 RVA: 0x001A737B File Offset: 0x001A557B
	// (set) Token: 0x06004E8E RID: 20110 RVA: 0x001A7383 File Offset: 0x001A5583
	public int DisplayIndex { get; set; }

	// Token: 0x06004E8F RID: 20111 RVA: 0x001A738C File Offset: 0x001A558C
	public object GetKey(ActivityCorniceMeetingRewardItemData data, int gridIndex)
	{
		return null;
	}

	// Token: 0x06004E90 RID: 20112 RVA: 0x001A7390 File Offset: 0x001A5590
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickFinishButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004E91 RID: 20113 RVA: 0x001A74BC File Offset: 0x001A56BC
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06004E92 RID: 20114 RVA: 0x001A74EC File Offset: 0x001A56EC
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06004E93 RID: 20115 RVA: 0x001A74EE File Offset: 0x001A56EE
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06004E94 RID: 20116 RVA: 0x001A74F0 File Offset: 0x001A56F0
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06004E95 RID: 20117 RVA: 0x001A74F7 File Offset: 0x001A56F7
	private void OnClickFinishButton()
	{
		Action onClickFinishBtnCb = this.OnClickFinishBtnCb;
		if (onClickFinishBtnCb == null)
		{
			return;
		}
		onClickFinishBtnCb();
	}

	// Token: 0x06004E96 RID: 20118 RVA: 0x001A7509 File Offset: 0x001A5709
	public void Refresh(ActivityCorniceMeetingRewardItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentScore = data.RewardId;
		this.OnClickFinishBtnCb = data.OnClickFinishBtnCb;
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshContentState();
	}

	// Token: 0x06004E97 RID: 20119 RVA: 0x001A7535 File Offset: 0x001A5735
	public void Clear()
	{
	}

	// Token: 0x06004E98 RID: 20120 RVA: 0x001A7537 File Offset: 0x001A5737
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), ActivityCorniceMeetingController.Instance.GetCurrentActivityData().TaskTitleTextId, new <>z__ReadOnlySingleElementList<object>(this.CurrentScore.ToString()));
	}

	// Token: 0x06004E99 RID: 20121 RVA: 0x001A756C File Offset: 0x001A576C
	private void RefreshReward()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		List<TItem> scoreIndexPreviewItem = currentActivityData.GetScoreIndexPreviewItem(currentActivityData.CurrentSelectLevelPlayId, this.CurrentScore);
		this.RewardScrollView.RefreshByData(scoreIndexPreviewItem, null, false);
	}

	// Token: 0x06004E9A RID: 20122 RVA: 0x001A75A4 File Offset: 0x001A57A4
	private void RefreshContentState()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		ECorniceMeetingRewardState rewardState = currentActivityData.GetRewardState(currentActivityData.CurrentSelectLevelPlayId, this.GridIndex);
		base.GetText(2).SetUIActive(false);
		base.GetButton(4).RootUIComp.Get().SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		base.GetSprite(3).SetUIActive(false);
		if (rewardState == ECorniceMeetingRewardState.Unfinished)
		{
			base.GetText(2).SetUIActive(true);
			return;
		}
		if (rewardState == ECorniceMeetingRewardState.Finished)
		{
			base.GetItem(5).SetUIActive(true);
			base.GetButton(4).RootUIComp.Get().SetUIActive(true);
			return;
		}
		if (rewardState == ECorniceMeetingRewardState.Rewarded)
		{
			base.GetSprite(3).SetUIActive(true);
		}
	}

	// Token: 0x040038E6 RID: 14566
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040038E7 RID: 14567
	private int CurrentScore;

	// Token: 0x040038E8 RID: 14568
	[Nullable(2)]
	private Action OnClickFinishBtnCb;

	// Token: 0x02006965 RID: 26981
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022B5E RID: 142174
		public const int Title = 0;

		// Token: 0x04022B5F RID: 142175
		public const int ItemScroller = 1;

		// Token: 0x04022B60 RID: 142176
		public const int UnFinishedText = 2;

		// Token: 0x04022B61 RID: 142177
		public const int SprDone = 3;

		// Token: 0x04022B62 RID: 142178
		public const int FinishButton = 4;

		// Token: 0x04022B63 RID: 142179
		public const int FinishedItem = 5;
	}
}
