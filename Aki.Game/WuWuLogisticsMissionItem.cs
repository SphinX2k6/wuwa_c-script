using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001667 RID: 5735
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsMissionItem : GridProxyAbstract<int>
{
	// Token: 0x0600A1A0 RID: 41376 RVA: 0x0023A964 File Offset: 0x00238B64
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

	// Token: 0x0600A1A1 RID: 41377 RVA: 0x0023AA2C File Offset: 0x00238C2C
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
		this.ConfirmQuick = new ButtonItem(base.GetButton(6).RootUIComp);
		this.ConfirmQuick.SetFunction(new Action<int>(this.OnClickReceive));
	}

	// Token: 0x0600A1A2 RID: 41378 RVA: 0x0023AA8D File Offset: 0x00238C8D
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x0600A1A3 RID: 41379 RVA: 0x0023AA96 File Offset: 0x00238C96
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.IsHadReward)
		};
	}

	// Token: 0x0600A1A4 RID: 41380 RVA: 0x0023AAB0 File Offset: 0x00238CB0
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

	// Token: 0x0600A1A5 RID: 41381 RVA: 0x0023ABE0 File Offset: 0x00238DE0
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

	// Token: 0x0600A1A6 RID: 41382 RVA: 0x0023AC68 File Offset: 0x00238E68
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

	// Token: 0x0600A1A7 RID: 41383 RVA: 0x0023ACC8 File Offset: 0x00238EC8
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

	// Token: 0x0600A1A8 RID: 41384 RVA: 0x0023ACF9 File Offset: 0x00238EF9
	private void OnClickReceive(int data)
	{
		Action<int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this.TaskId);
	}

	// Token: 0x04004988 RID: 18824
	private int TaskId;

	// Token: 0x04004989 RID: 18825
	private Action<int> ClickCallback = delegate(int _)
	{
	};

	// Token: 0x0400498A RID: 18826
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x0400498B RID: 18827
	[Nullable(2)]
	protected ButtonItem ConfirmQuick;

	// Token: 0x0400498C RID: 18828
	private bool IsHadReward;
}
