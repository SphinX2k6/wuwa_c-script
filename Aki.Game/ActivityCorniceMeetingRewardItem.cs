using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011F8 RID: 4600
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingRewardItem : UiPanelBase, IGridProxy<ActivityCorniceMeetingRewardItemData>
{
	// Token: 0x17000A83 RID: 2691
	// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x0019E6A1 File Offset: 0x0019C8A1
	// (set) Token: 0x06007AF4 RID: 31476 RVA: 0x0019E6A9 File Offset: 0x0019C8A9
	public IScrollViewDelegate<IGridProxy<ActivityCorniceMeetingRewardItemData>, ActivityCorniceMeetingRewardItemData> ScrollViewDelegate { get; set; }

	// Token: 0x17000A84 RID: 2692
	// (get) Token: 0x06007AF5 RID: 31477 RVA: 0x0019E6B2 File Offset: 0x0019C8B2
	// (set) Token: 0x06007AF6 RID: 31478 RVA: 0x0019E6BA File Offset: 0x0019C8BA
	public int GridIndex { get; set; }

	// Token: 0x17000A85 RID: 2693
	// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x0019E6C3 File Offset: 0x0019C8C3
	// (set) Token: 0x06007AF8 RID: 31480 RVA: 0x0019E6CB File Offset: 0x0019C8CB
	public int DisplayIndex { get; set; }

	// Token: 0x06007AF9 RID: 31481 RVA: 0x0019E6D4 File Offset: 0x0019C8D4
	public object GetKey(ActivityCorniceMeetingRewardItemData data, int gridIndex)
	{
		return null;
	}

	// Token: 0x06007AFA RID: 31482 RVA: 0x0019E6D8 File Offset: 0x0019C8D8
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

	// Token: 0x06007AFB RID: 31483 RVA: 0x0019E804 File Offset: 0x0019CA04
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
	}

	// Token: 0x06007AFC RID: 31484 RVA: 0x0019E834 File Offset: 0x0019CA34
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06007AFD RID: 31485 RVA: 0x0019E836 File Offset: 0x0019CA36
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06007AFE RID: 31486 RVA: 0x0019E838 File Offset: 0x0019CA38
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007AFF RID: 31487 RVA: 0x0019E83F File Offset: 0x0019CA3F
	private void OnClickFinishButton()
	{
		Action onClickFinishBtnCb = this.OnClickFinishBtnCb;
		if (onClickFinishBtnCb == null)
		{
			return;
		}
		onClickFinishBtnCb();
	}

	// Token: 0x06007B00 RID: 31488 RVA: 0x0019E851 File Offset: 0x0019CA51
	public void Refresh(ActivityCorniceMeetingRewardItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentScore = data.RewardId;
		this.OnClickFinishBtnCb = data.OnClickFinishBtnCb;
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshContentState();
	}

	// Token: 0x06007B01 RID: 31489 RVA: 0x0019E87D File Offset: 0x0019CA7D
	public void Clear()
	{
	}

	// Token: 0x06007B02 RID: 31490 RVA: 0x0019E87F File Offset: 0x0019CA7F
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), ActivityCorniceMeetingController.Instance.GetCurrentActivityData().TaskTitleTextId, new <>z__ReadOnlySingleElementList<object>(this.CurrentScore.ToString()));
	}

	// Token: 0x06007B03 RID: 31491 RVA: 0x0019E8B4 File Offset: 0x0019CAB4
	private void RefreshReward()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		List<TItem> scoreIndexPreviewItem = currentActivityData.GetScoreIndexPreviewItem(currentActivityData.CurrentSelectLevelPlayId, this.CurrentScore);
		this.RewardScrollView.RefreshByData(scoreIndexPreviewItem, null, false);
	}

	// Token: 0x06007B04 RID: 31492 RVA: 0x0019E8EC File Offset: 0x0019CAEC
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

	// Token: 0x0400384D RID: 14413
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0400384E RID: 14414
	private int CurrentScore;

	// Token: 0x0400384F RID: 14415
	[Nullable(2)]
	private Action OnClickFinishBtnCb;

	// Token: 0x020077DA RID: 30682
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402782C RID: 161836
		public const int Title = 0;

		// Token: 0x0402782D RID: 161837
		public const int ItemScroller = 1;

		// Token: 0x0402782E RID: 161838
		public const int UnFinishedText = 2;

		// Token: 0x0402782F RID: 161839
		public const int SprDone = 3;

		// Token: 0x04027830 RID: 161840
		public const int FinishButton = 4;

		// Token: 0x04027831 RID: 161841
		public const int FinishedItem = 5;
	}
}
