using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B1F RID: 2847
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsMissionItem : GridProxyAbstract<int>
{
	// Token: 0x0600757E RID: 30078 RVA: 0x00244800 File Offset: 0x00242A00
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x0600757F RID: 30079 RVA: 0x002448C8 File Offset: 0x00242AC8
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
		this.ConfirmQuick = new ButtonItem(base.GetButton(6).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickReceive));
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x00244929 File Offset: 0x00242B29
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x00244932 File Offset: 0x00242B32
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.IsHadReward)
		};
	}

	// Token: 0x06007582 RID: 30082 RVA: 0x0024494C File Offset: 0x00242B4C
	public override void Refresh(int taskId, bool isSelected, int gridIndex)
	{
		this.TaskId = taskId;
		this.IsHadReward = false;
		WuWuWeekTask? weekTaskById = WuWuLogisticsConfig.Instance.GetWeekTaskById(taskId);
		if (weekTaskById == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(weekTaskById.Value.Title);
		}
		int activityId = WuWuLogisticsActivityController.Instance.ActivityId;
		WuWuLogisticsActivityData wuWuLogisticsActivityData = ActivityModel.Instance.GetActivityById(activityId) as WuWuLogisticsActivityData;
		WuWuTaskData wuWuTaskData = (wuWuLogisticsActivityData != null) ? wuWuLogisticsActivityData.GetTaskById(taskId) : null;
		if (wuWuTaskData == null)
		{
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			this.UpdateStateInfoItem(EWuWuTaskState.Running);
			this.RefreshRewardItems(weekTaskById.Value.DropId);
			return;
		}
		this.IsHadReward = wuWuTaskData.IsRewarded;
		this.RefreshRewardItems(weekTaskById.Value.DropId);
		int progress = wuWuTaskData.Progress;
		int targetProgress = wuWuTaskData.TargetProgress;
		string conditionProgress = this.GetConditionProgress((EWuWuTaskConditionProgressShowType)weekTaskById.Value.ProgressType, progress, targetProgress);
		UUIText text3 = base.GetText(1);
		if (text3 != null)
		{
			text3.SetUIActive(true);
		}
		UUIText text4 = base.GetText(1);
		if (text4 != null)
		{
			text4.SetText(conditionProgress, true);
		}
		this.UpdateStateInfoItem(wuWuTaskData.State);
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x00244A7C File Offset: 0x00242C7C
	private void UpdateStateInfoItem(EWuWuTaskState state)
	{
		bool uiactive = state == EWuWuTaskState.Running;
		bool flag = state == EWuWuTaskState.Finish;
		bool flag2 = state == EWuWuTaskState.Taken;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(flag || flag2);
		}
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(flag2);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		ButtonItem confirmQuick = this.ConfirmQuick;
		if (confirmQuick == null)
		{
			return;
		}
		confirmQuick.SetRedDotVisible(flag);
	}

	// Token: 0x06007584 RID: 30084 RVA: 0x00244B04 File Offset: 0x00242D04
	[NullableContext(2)]
	private string GetConditionProgress(EWuWuTaskConditionProgressShowType type, int progress, int target)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (type == EWuWuTaskConditionProgressShowType.ShowCompleteCount)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (type != EWuWuTaskConditionProgressShowType.ShowTargetConditionProgress)
		{
			return null;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(target);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06007585 RID: 30085 RVA: 0x00244B64 File Offset: 0x00242D64
	private void RefreshRewardItems(int dropId)
	{
		if (dropId <= 0)
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView == null)
		{
			return;
		}
		rewardScrollView.RefreshByData(dropPackagePreviewItemList, null, false);
	}

	// Token: 0x06007586 RID: 30086 RVA: 0x00244B95 File Offset: 0x00242D95
	private void OnClickReceive(int data)
	{
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.TaskId);
	}

	// Token: 0x04004A2E RID: 18990
	private int TaskId;

	// Token: 0x04004A2F RID: 18991
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x04004A30 RID: 18992
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004A31 RID: 18993
	[Nullable(2)]
	protected ButtonItem ConfirmQuick;

	// Token: 0x04004A32 RID: 18994
	private bool IsHadReward;
}
