using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014B0 RID: 5296
public class ActivityRegressTaskSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x0600960A RID: 38410 RVA: 0x002061E8 File Offset: 0x002043E8
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

	// Token: 0x0600960B RID: 38411 RVA: 0x002062D4 File Offset: 0x002044D4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressTaskSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressTaskSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600960C RID: 38412 RVA: 0x00206317 File Offset: 0x00204517
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.RefreshView();
	}

	// Token: 0x0600960D RID: 38413 RVA: 0x00206325 File Offset: 0x00204525
	protected override void OnUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x0600960E RID: 38414 RVA: 0x0020632D File Offset: 0x0020452D
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.ClearTimer();
	}

	// Token: 0x0600960F RID: 38415 RVA: 0x0020633B File Offset: 0x0020453B
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.TaskDynamicScrollItemList = null;
	}

	// Token: 0x06009610 RID: 38416 RVA: 0x0020635E File Offset: 0x0020455E
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x06009611 RID: 38417 RVA: 0x0020638A File Offset: 0x0020458A
	protected override void OnStart()
	{
		base.OnStart();
		this.RecallTaskScoreRewardLayout = new GenericScrollViewNew<ActivityRegressTaskLayoutItemPanel, ActivityRegressTaskScoreRewardGridData>(base.GetScrollViewWithScrollbar(1), new Func<ActivityRegressTaskLayoutItemPanel>(this.InitScoreRewardGridItem), null, false, null);
	}

	// Token: 0x06009612 RID: 38418 RVA: 0x002063B4 File Offset: 0x002045B4
	[NullableContext(1)]
	private ActivityRegressTaskDynamicScrollItem CreateItemFunc(ActivityRegressTaskDynamicData data, UUIItem uiItem, int index)
	{
		ActivityRegressTaskDynamicScrollItem activityRegressTaskDynamicScrollItem = new ActivityRegressTaskDynamicScrollItem();
		this.TaskDynamicScrollItemList.Add(activityRegressTaskDynamicScrollItem);
		return activityRegressTaskDynamicScrollItem;
	}

	// Token: 0x06009613 RID: 38419 RVA: 0x002063D4 File Offset: 0x002045D4
	[NullableContext(1)]
	private ActivityRegressTaskLayoutItemPanel InitScoreRewardGridItem()
	{
		return new ActivityRegressTaskLayoutItemPanel();
	}

	// Token: 0x06009614 RID: 38420 RVA: 0x002063DC File Offset: 0x002045DC
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

	// Token: 0x06009615 RID: 38421 RVA: 0x002064E8 File Offset: 0x002046E8
	private void RefreshRegressTasks()
	{
		List<ActivityRegressTaskDynamicData> regressMainTaskGridDataGroupByTypeAndSortedArr = ActivityRegressModel.Instance.GetRegressMainTaskGridDataGroupByTypeAndSortedArr();
		this.ContentGenericLayout.RefreshByData(regressMainTaskGridDataGroupByTypeAndSortedArr.ToArray(), false, false);
	}

	// Token: 0x06009616 RID: 38422 RVA: 0x00206514 File Offset: 0x00204714
	private void RefreshView()
	{
		this.RefreshScoreRewards();
		this.RefreshRegressTasks();
		base.GetItem(4).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Normal);
		base.GetItem(5).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Hyper);
		base.GetTexture(6).SetUIActive(ActivityRegressModel.Instance.Grade == ERegressGrade.Hyper);
	}

	// Token: 0x06009617 RID: 38423 RVA: 0x00206578 File Offset: 0x00204778
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

	// Token: 0x06009618 RID: 38424 RVA: 0x00206600 File Offset: 0x00204800
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

	// Token: 0x0400424A RID: 16970
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ActivityRegressTaskDynamicScrollItem, ActivityRegressTaskDynamicItem, ActivityRegressTaskDynamicData> ContentGenericLayout;

	// Token: 0x0400424B RID: 16971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTaskDynamicScrollItem> TaskDynamicScrollItemList;

	// Token: 0x0400424C RID: 16972
	[Nullable(2)]
	private TimerHandle RefreshTimerHandle;

	// Token: 0x0400424D RID: 16973
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivityRegressTaskLayoutItemPanel, ActivityRegressTaskScoreRewardGridData> RecallTaskScoreRewardLayout;

	// Token: 0x0400424E RID: 16974
	private ValueTuple<int?, int?> MinAndMaxScoreRewardIndexTuple = new ValueTuple<int?, int?>(null, null);

	// Token: 0x02007AE8 RID: 31464
	private class EComponents
	{
		// Token: 0x040286E4 RID: 165604
		public const int DynScrollView = 0;

		// Token: 0x040286E5 RID: 165605
		public const int RewardScrollView = 1;

		// Token: 0x040286E6 RID: 165606
		public const int PnlItem = 2;

		// Token: 0x040286E7 RID: 165607
		public const int TxtNum = 3;

		// Token: 0x040286E8 RID: 165608
		public const int PnlNor = 4;

		// Token: 0x040286E9 RID: 165609
		public const int PnlSenior = 5;

		// Token: 0x040286EA RID: 165610
		public const int TexSeniorBg = 6;

		// Token: 0x040286EB RID: 165611
		public const int LeftRedPoint = 7;

		// Token: 0x040286EC RID: 165612
		public const int RightRedPoint = 8;
	}
}
