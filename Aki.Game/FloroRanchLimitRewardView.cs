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

// Token: 0x02001B6A RID: 7018
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchLimitRewardView : UiViewBase
{
	// Token: 0x0600D0A0 RID: 53408 RVA: 0x002FA6D3 File Offset: 0x002F88D3
	public FloroRanchLimitRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0A1 RID: 53409 RVA: 0x002FA6E4 File Offset: 0x002F88E4
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

	// Token: 0x0600D0A2 RID: 53410 RVA: 0x002FA894 File Offset: 0x002F8A94
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchLimitRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchLimitRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0A3 RID: 53411 RVA: 0x002FA8D7 File Offset: 0x002F8AD7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x0600D0A4 RID: 53412 RVA: 0x002FA8F5 File Offset: 0x002F8AF5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshView));
	}

	// Token: 0x0600D0A5 RID: 53413 RVA: 0x002FA914 File Offset: 0x002F8B14
	private void RefreshTaskLayout()
	{
		List<FloroRanchTaskData> taskDataByTabType = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetTaskDataByTabType(this.CurTaskTabType);
		this.TaskLayout.RefreshByData(taskDataByTabType, delegate
		{
			this.TaskLayout.ScrollToTop(0);
		}, true);
	}

	// Token: 0x0600D0A6 RID: 53414 RVA: 0x002FA954 File Offset: 0x002F8B54
	private void RefreshProgressItem()
	{
		List<FloroRanchMilestoneData> floroRanchMilestoneDataList = this.ActivityData.GetFloroRanchMilestoneDataList();
		int milestoneItemCount = this.ActivityData.GetMilestoneItemCount();
		this.ProgressItem.RefreshProgressItem((float)milestoneItemCount, floroRanchMilestoneDataList);
	}

	// Token: 0x0600D0A7 RID: 53415 RVA: 0x002FA988 File Offset: 0x002F8B88
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

	// Token: 0x0600D0A8 RID: 53416 RVA: 0x002FA9EA File Offset: 0x002F8BEA
	private void RemoveTimeHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600D0A9 RID: 53417 RVA: 0x002FAA0C File Offset: 0x002F8C0C
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimeHandle();
	}

	// Token: 0x0600D0AA RID: 53418 RVA: 0x002FAA14 File Offset: 0x002F8C14
	private void OnRefreshView(int activityId)
	{
		if (this.ActivityData.Id == activityId)
		{
			this.TabLayout.RefreshWithoutDataSync();
			this.RefreshTaskLayout();
			this.RefreshProgressItem();
		}
	}

	// Token: 0x0600D0AB RID: 53419 RVA: 0x002FAA3B File Offset: 0x002F8C3B
	private void OnTabClickCallBack(int gridIndex, EFloroRanchTaskTabType taskTabType)
	{
		this.TabLayout.SelectGridProxy(gridIndex, false);
		this.CurTaskTabType = taskTabType;
		this.RefreshTaskLayout();
	}

	// Token: 0x0600D0AC RID: 53420 RVA: 0x002FAA58 File Offset: 0x002F8C58
	private void OnTaskClickCallBack()
	{
		List<int> floroRanchReceivableTaskIds = this.ActivityData.GetFloroRanchReceivableTaskIds(true, this.CurTaskTabType);
		FloroRanchController.Instance.RequestTaskReward(floroRanchReceivableTaskIds.ToArray());
	}

	// Token: 0x0600D0AD RID: 53421 RVA: 0x002FAA88 File Offset: 0x002F8C88
	private void OnClickGetProgressReward()
	{
		List<int> floroRanchReceivableMilestoneIds = this.ActivityData.GetFloroRanchReceivableMilestoneIds();
		if (floroRanchReceivableMilestoneIds.Count > 0)
		{
			FloroRanchController.Instance.RequestMilestoneReward(floroRanchReceivableMilestoneIds.ToArray());
		}
	}

	// Token: 0x0600D0AE RID: 53422 RVA: 0x002FAABA File Offset: 0x002F8CBA
	private FloroRanchTaskTabItem CreateTabItem()
	{
		return new FloroRanchTaskTabItem
		{
			OnToggleCallBack = new Action<int, EFloroRanchTaskTabType>(this.OnTabClickCallBack)
		};
	}

	// Token: 0x0600D0AF RID: 53423 RVA: 0x002FAAD3 File Offset: 0x002F8CD3
	private FloroRanchTaskItem CreateTaskItem()
	{
		return new FloroRanchTaskItem
		{
			OnGetBtnClick = new Action(this.OnTaskClickCallBack)
		};
	}

	// Token: 0x0600D0B0 RID: 53424 RVA: 0x002FAAEC File Offset: 0x002F8CEC
	private void OnCardDetailBtnClick()
	{
		int cardItemId = this.ActivityData.GetFloroRanchParamConfig().CardItemId;
		ItemController.Instance.OpenItemTipsByItemId(cardItemId, true, null);
	}

	// Token: 0x0600D0B1 RID: 53425 RVA: 0x002FAB1A File Offset: 0x002F8D1A
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005FC7 RID: 24519
	private FloroRanchActivityData ActivityData;

	// Token: 0x04005FC8 RID: 24520
	private EFloroRanchTaskTabType CurTaskTabType = EFloroRanchTaskTabType.Dungeon;

	// Token: 0x04005FC9 RID: 24521
	private GenericLayout<FloroRanchTaskTabItem, FloroRanchTaskTab> TabLayout;

	// Token: 0x04005FCA RID: 24522
	private GenericScrollViewNew<FloroRanchTaskItem, FloroRanchTaskData> TaskLayout;

	// Token: 0x04005FCB RID: 24523
	private TimerHandle TimerHandle;

	// Token: 0x04005FCC RID: 24524
	private FloroRanchMilestoneItem ProgressItem;

	// Token: 0x020080D8 RID: 32984
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A097 RID: 172183
		public const int ItemCaption = 0;

		// Token: 0x0402A098 RID: 172184
		public const int TextureCardImage = 1;

		// Token: 0x0402A099 RID: 172185
		public const int TextCardName = 2;

		// Token: 0x0402A09A RID: 172186
		public const int ScrollLayoutTask = 3;

		// Token: 0x0402A09B RID: 172187
		public const int ItemTask = 4;

		// Token: 0x0402A09C RID: 172188
		public const int ButtonCardDetail = 5;

		// Token: 0x0402A09D RID: 172189
		public const int LayoutTab = 6;

		// Token: 0x0402A09E RID: 172190
		public const int ItemTab = 7;

		// Token: 0x0402A09F RID: 172191
		public const int ItemProgress = 8;

		// Token: 0x0402A0A0 RID: 172192
		public const int TextRemainTime = 9;
	}
}
