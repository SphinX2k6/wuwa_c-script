using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000964 RID: 2404
public class ActivityRegressTaskSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x0600699F RID: 27039 RVA: 0x0020F154 File Offset: 0x0020D354
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060069A0 RID: 27040 RVA: 0x0020F240 File Offset: 0x0020D440
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060069A1 RID: 27041 RVA: 0x0020F283 File Offset: 0x0020D483
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.RefreshView();
	}

	// Token: 0x060069A2 RID: 27042 RVA: 0x0020F291 File Offset: 0x0020D491
	protected override void OnUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x060069A3 RID: 27043 RVA: 0x0020F299 File Offset: 0x0020D499
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.ClearTimer();
	}

	// Token: 0x060069A4 RID: 27044 RVA: 0x0020F2A7 File Offset: 0x0020D4A7
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.TaskDynamicScrollItemList = null;
	}

	// Token: 0x060069A5 RID: 27045 RVA: 0x0020F2CA File Offset: 0x0020D4CA
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x060069A6 RID: 27046 RVA: 0x0020F2F6 File Offset: 0x0020D4F6
	protected override void OnStart()
	{
		base.OnStart();
		this.RecallTaskScoreRewardLayout = new GenericScrollViewNew<ActivityRegressTaskLayoutItemPanel, ActivityRegressTaskScoreRewardGridData>(base.GetScrollViewWithScrollbar(1), new Func<ActivityRegressTaskLayoutItemPanel>(this.InitScoreRewardGridItem), null, false, null);
	}

	// Token: 0x060069A7 RID: 27047 RVA: 0x0020F320 File Offset: 0x0020D520
	[NullableContext(1)]
	private ActivityRegressTaskDynamicScrollItem CreateItemFunc(ActivityRegressTaskDynamicData data, UUIItem uiItem, int index)
	{
		ActivityRegressTaskDynamicScrollItem activityRegressTaskDynamicScrollItem = new ActivityRegressTaskDynamicScrollItem();
		this.TaskDynamicScrollItemList.Add(activityRegressTaskDynamicScrollItem);
		return activityRegressTaskDynamicScrollItem;
	}

	// Token: 0x060069A8 RID: 27048 RVA: 0x0020F340 File Offset: 0x0020D540
	[NullableContext(1)]
	private ActivityRegressTaskLayoutItemPanel InitScoreRewardGridItem()
	{
		return new ActivityRegressTaskLayoutItemPanel();
	}

	// Token: 0x060069A9 RID: 27049 RVA: 0x0020F348 File Offset: 0x0020D548
	private void RefreshScoreRewards()
	{
		UUIText text = base.GetText(3);
		int regressTaskScore = ActivityRegressModel.Instance.ActivityData.GetRegressTaskScore();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(regressTaskScore);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		List<ActivityRegressTaskScoreRewardGridData> regressMainTaskScoreRewardGridDataArr = ActivityRegressModel.Instance.GetRegressMainTaskScoreRewardGridDataArr();
		int index = -1;
		for (int i = 0; i < regressMainTaskScoreRewardGridDataArr.Count; i++)
		{
			if (regressMainTaskScoreRewardGridDataArr[i].RewardState == ERegressRewardState.Reached)
			{
				index = i;
				break;
			}
		}
		if (index == -1)
		{
			for (int j = 0; j < regressMainTaskScoreRewardGridDataArr.Count; j++)
			{
				if (regressMainTaskScoreRewardGridDataArr[j].RewardState == ERegressRewardState.UnReach)
				{
					index = j;
					break;
				}
			}
		}
		index = ((index != -1) ? index : 0);
		this.RecallTaskScoreRewardLayout.RefreshByData(regressMainTaskScoreRewardGridDataArr, delegate
		{
			UUIItem itemByIndex = this.RecallTaskScoreRewardLayout.GetItemByIndex(index);
			this.RecallTaskScoreRewardLayout.LateScrollTo(itemByIndex, null, false);
		}, false);
		this.RefreshMainTaskScoreRewardRedDotIndexes(regressMainTaskScoreRewardGridDataArr);
	}

	// Token: 0x060069AA RID: 27050 RVA: 0x0020F454 File Offset: 0x0020D654
	private void RefreshRegressTasks()
	{
		List<ActivityRegressTaskDynamicData> regressMainTaskGridDataGroupByTypeAndSortedArr = ActivityRegressModel.Instance.GetRegressMainTaskGridDataGroupByTypeAndSortedArr();
		this.ContentGenericLayout.RefreshByData(regressMainTaskGridDataGroupByTypeAndSortedArr.ToArray(), false, false);
	}

	// Token: 0x060069AB RID: 27051 RVA: 0x0020F480 File Offset: 0x0020D680
	private void RefreshView()
	{
		this.RefreshScoreRewards();
		this.RefreshRegressTasks();
		base.GetItem(4).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Normal);
		base.GetItem(5).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Hyper);
		base.GetTexture(6).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Hyper);
	}

	// Token: 0x060069AC RID: 27052 RVA: 0x0020F4E4 File Offset: 0x0020D6E4
	[NullableContext(1)]
	private void RefreshMainTaskScoreRewardRedDotIndexes(List<ActivityRegressTaskScoreRewardGridData> gridDataList)
	{
		if (!ActivityRegressModel.Instance.ActivityData.CheckRegressScoreRewardReached())
		{
			this.MinAndMaxScoreRewardIndexTuple = new ValueTuple<int?, int?>(null, null);
			return;
		}
		int num = gridDataList.Count;
		int num2 = -1;
		for (int i = 0; i < gridDataList.Count; i++)
		{
			if (gridDataList[i].RewardState == ERegressRewardState.Reached)
			{
				if (i < num)
				{
					num = i;
				}
				if (i > num2)
				{
					num2 = i;
				}
			}
		}
		this.MinAndMaxScoreRewardIndexTuple = new ValueTuple<int?, int?>(new int?(num), new int?(num2));
	}

	// Token: 0x060069AD RID: 27053 RVA: 0x0020F56C File Offset: 0x0020D76C
	private void OnScrollUpdateRedDot(FVector2D _)
	{
		if (this.MinAndMaxScoreRewardIndexTuple.Item1 == null && this.MinAndMaxScoreRewardIndexTuple.Item2 == null)
		{
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			return;
		}
		int displayGridStartIndex = this.ContentGenericLayout.GetDisplayGridStartIndex();
		int displayGridEndIndex = this.ContentGenericLayout.GetDisplayGridEndIndex();
		int valueOrDefault = this.MinAndMaxScoreRewardIndexTuple.Item1.GetValueOrDefault(displayGridStartIndex);
		int valueOrDefault2 = this.MinAndMaxScoreRewardIndexTuple.Item2.GetValueOrDefault(displayGridEndIndex);
		base.GetItem(7).SetUIActive(valueOrDefault < displayGridStartIndex);
		base.GetItem(8).SetUIActive(valueOrDefault2 > displayGridEndIndex);
	}

	// Token: 0x040042E2 RID: 17122
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ActivityRegressTaskDynamicScrollItem, ActivityRegressTaskDynamicItem, ActivityRegressTaskDynamicData> ContentGenericLayout;

	// Token: 0x040042E3 RID: 17123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTaskDynamicScrollItem> TaskDynamicScrollItemList;

	// Token: 0x040042E4 RID: 17124
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x040042E5 RID: 17125
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivityRegressTaskLayoutItemPanel, ActivityRegressTaskScoreRewardGridData> RecallTaskScoreRewardLayout;

	// Token: 0x040042E6 RID: 17126
	private ValueTuple<int?, int?> MinAndMaxScoreRewardIndexTuple = new ValueTuple<int?, int?>(null, null);

	// Token: 0x02006C6C RID: 27756
	private class EComponents
	{
		// Token: 0x040239FE RID: 145918
		public const int DynScrollView = 0;

		// Token: 0x040239FF RID: 145919
		public const int RewardScrollView = 1;

		// Token: 0x04023A00 RID: 145920
		public const int PnlItem = 2;

		// Token: 0x04023A01 RID: 145921
		public const int TxtNum = 3;

		// Token: 0x04023A02 RID: 145922
		public const int PnlNor = 4;

		// Token: 0x04023A03 RID: 145923
		public const int PnlSenior = 5;

		// Token: 0x04023A04 RID: 145924
		public const int TexSeniorBg = 6;

		// Token: 0x04023A05 RID: 145925
		public const int LeftRedPoint = 7;

		// Token: 0x04023A06 RID: 145926
		public const int RightRedPoint = 8;
	}
}
