using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001029 RID: 4137
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchLimitRewardView : UiViewBase
{
	// Token: 0x0600A4B1 RID: 42161 RVA: 0x003057AB File Offset: 0x003039AB
	public FloroRanchLimitRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A4B2 RID: 42162 RVA: 0x003057BC File Offset: 0x003039BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnCardDetailBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A4B3 RID: 42163 RVA: 0x0030596C File Offset: 0x00303B6C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchLimitRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchLimitRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A4B4 RID: 42164 RVA: 0x003059AF File Offset: 0x00303BAF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x0600A4B5 RID: 42165 RVA: 0x003059CD File Offset: 0x00303BCD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x0600A4B6 RID: 42166 RVA: 0x003059EC File Offset: 0x00303BEC
	private void RefreshTaskLayout()
	{
		List<FloroRanchTaskData> taskDataByTabType = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetTaskDataByTabType(this.CurTaskTabType);
		this.TaskLayout.RefreshByData(taskDataByTabType, delegate
		{
			this.TaskLayout.ScrollToTop(0);
		}, true);
	}

	// Token: 0x0600A4B7 RID: 42167 RVA: 0x00305A2C File Offset: 0x00303C2C
	private void RefreshProgressItem()
	{
		List<FloroRanchMilestoneData> floroRanchMilestoneDataList = this.ActivityData.GetFloroRanchMilestoneDataList();
		int milestoneItemCount = this.ActivityData.GetMilestoneItemCount();
		this.ProgressItem.RefreshProgressItem((float)milestoneItemCount, floroRanchMilestoneDataList);
	}

	// Token: 0x0600A4B8 RID: 42168 RVA: 0x00305A60 File Offset: 0x00303C60
	private void RefreshTimeText()
	{
		if (!this.ActivityData.IsInLimitTime())
		{
			this.RemoveTimeHandle();
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.GetLimitTimeActivityEndTime(), localTextNew);
		UUIText text = base.GetText(9);
		if (text == null)
		{
			return;
		}
		text.SetText(remainTimeText, true);
	}

	// Token: 0x0600A4B9 RID: 42169 RVA: 0x00305AC2 File Offset: 0x00303CC2
	private void RemoveTimeHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600A4BA RID: 42170 RVA: 0x00305AE4 File Offset: 0x00303CE4
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimeHandle();
	}

	// Token: 0x0600A4BB RID: 42171 RVA: 0x00305AEC File Offset: 0x00303CEC
	private void OnRefreshView(int activityId)
	{
		if (this.ActivityData.Id == activityId)
		{
			this.TabLayout.RefreshWithoutDataSync();
			this.RefreshTaskLayout();
			this.RefreshProgressItem();
		}
	}

	// Token: 0x0600A4BC RID: 42172 RVA: 0x00305B13 File Offset: 0x00303D13
	private void OnTabClickCallBack(int gridIndex, EFloroRanchTaskTabType taskTabType)
	{
		this.TabLayout.SelectGridProxy(gridIndex, false);
		this.CurTaskTabType = taskTabType;
		this.RefreshTaskLayout();
	}

	// Token: 0x0600A4BD RID: 42173 RVA: 0x00305B30 File Offset: 0x00303D30
	private void OnTaskClickCallBack()
	{
		List<int> floroRanchReceivableTaskIds = this.ActivityData.GetFloroRanchReceivableTaskIds(true, this.CurTaskTabType);
		FloroRanchController.Instance.RequestTaskReward(floroRanchReceivableTaskIds.ToArray());
	}

	// Token: 0x0600A4BE RID: 42174 RVA: 0x00305B60 File Offset: 0x00303D60
	private void OnClickGetProgressReward()
	{
		List<int> floroRanchReceivableMilestoneIds = this.ActivityData.GetFloroRanchReceivableMilestoneIds();
		if (floroRanchReceivableMilestoneIds.Count > 0)
		{
			FloroRanchController.Instance.RequestMilestoneReward(floroRanchReceivableMilestoneIds.ToArray());
		}
	}

	// Token: 0x0600A4BF RID: 42175 RVA: 0x00305B92 File Offset: 0x00303D92
	private FloroRanchTaskTabItem CreateTabItem()
	{
		return new FloroRanchTaskTabItem
		{
			OnToggleCallBack = new Action<int, EFloroRanchTaskTabType>(this.OnTabClickCallBack)
		};
	}

	// Token: 0x0600A4C0 RID: 42176 RVA: 0x00305BAB File Offset: 0x00303DAB
	private FloroRanchTaskItem CreateTaskItem()
	{
		return new FloroRanchTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x0600A4C1 RID: 42177 RVA: 0x00305BC4 File Offset: 0x00303DC4
	private void OnCardDetailBtnClick()
	{
		int cardItemId = this.ActivityData.GetFloroRanchParamConfig().CardItemId;
		ItemController.Instance.OpenItemTipsByItemId(cardItemId, true, null, false);
	}

	// Token: 0x0600A4C2 RID: 42178 RVA: 0x00305BF3 File Offset: 0x00303DF3
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006096 RID: 24726
	private FloroRanchActivityData ActivityData;

	// Token: 0x04006097 RID: 24727
	private EFloroRanchTaskTabType CurTaskTabType = EFloroRanchTaskTabType.Dungeon;

	// Token: 0x04006098 RID: 24728
	private GenericLayout<FloroRanchTaskTabItem, FloroRanchTaskTab> TabLayout;

	// Token: 0x04006099 RID: 24729
	private GenericScrollViewNew<FloroRanchTaskItem, FloroRanchTaskData> TaskLayout;

	// Token: 0x0400609A RID: 24730
	private TimerHandle TimerHandle;

	// Token: 0x0400609B RID: 24731
	private FloroRanchMilestoneItem ProgressItem;

	// Token: 0x02007266 RID: 29286
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040253CB RID: 152523
		public const int ItemCaption = 0;

		// Token: 0x040253CC RID: 152524
		public const int TextureCardImage = 1;

		// Token: 0x040253CD RID: 152525
		public const int TextCardName = 2;

		// Token: 0x040253CE RID: 152526
		public const int ScrollLayoutTask = 3;

		// Token: 0x040253CF RID: 152527
		public const int ItemTask = 4;

		// Token: 0x040253D0 RID: 152528
		public const int ButtonCardDetail = 5;

		// Token: 0x040253D1 RID: 152529
		public const int LayoutTab = 6;

		// Token: 0x040253D2 RID: 152530
		public const int ItemTab = 7;

		// Token: 0x040253D3 RID: 152531
		public const int ItemProgress = 8;

		// Token: 0x040253D4 RID: 152532
		public const int TextRemainTime = 9;
	}
}
