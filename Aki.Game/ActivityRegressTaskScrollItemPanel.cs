using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014AF RID: 5295
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressTaskScrollItemPanel : UiPanelBase
{
	// Token: 0x06009600 RID: 38400 RVA: 0x002059AC File Offset: 0x00203BAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x06009601 RID: 38401 RVA: 0x00205AB8 File Offset: 0x00203CB8
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(4).GetOwner());
		this.ItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleClicked));
		UUIItem item = base.GetItem(7);
		this.ButtonItemE = new ButtonItem(item);
		this.ButtonItemE.SetFunction(new Action<int>(this.OnConfirmBtnClick));
		this.ButtonItemE.SetShowText("RecallActivity_Go");
		UUIItem item2 = base.GetItem(10);
		this.ButtonItemB = new ButtonItem(item2);
		this.ButtonItemB.SetFunction(new Action<int>(this.OnConfirmBtnClick));
	}

	// Token: 0x06009602 RID: 38402 RVA: 0x00205B90 File Offset: 0x00203D90
	[NullableContext(1)]
	public void RefreshByData(ActivityRegressTaskDynamicData data)
	{
		this.Data = data;
		RegressQuest? config = data.Config;
		ERegressRewardState taskRewardStateForShow = this.GetTaskRewardStateForShow();
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, config.Value.TargetName, Array.Empty<object>());
		UUIText text2 = base.GetText(8);
		if (data.TaskType == ERegressTaskType.Constant)
		{
			this.SetupConstantTaskVisuals();
		}
		else
		{
			this.SetupDailyTaskVisuals();
		}
		if (taskRewardStateForShow == ERegressRewardState.Claim)
		{
			text2.SetText("", true);
		}
		IRegressRewardItemInfo regressTaskRewardItemInfo = ActivityRegressModel.Instance.GetRegressTaskRewardItemInfo(config.Value);
		ActivityRegressHelper.RefreshItemGridByData(this.ItemGrid, regressTaskRewardItemInfo);
		ItemInfo? itemInfo = regressTaskRewardItemInfo.ItemInfo;
		int itemCount = regressTaskRewardItemInfo.ItemCount;
		bool item = regressTaskRewardItemInfo.RewardState == ERegressRewardState.UnReach;
		bool item2 = false;
		bool item3 = regressTaskRewardItemInfo.RewardState == ERegressRewardState.Claim;
		ActivityRegressHelper.RefreshItemGrid(this.ItemGrid, itemInfo.Value, itemCount, new ValueTuple<bool, bool, bool>(item, item2, item3));
		this.ButtonItemE.SetUiActive(taskRewardStateForShow == ERegressRewardState.UnReach);
		this.ButtonItemB.SetUiActive(taskRewardStateForShow == ERegressRewardState.Reached);
		base.GetText(6).SetUIActive(false);
		base.GetItem(5).SetUIActive(taskRewardStateForShow == ERegressRewardState.Claim);
		base.GetItem(9).SetUIActive(taskRewardStateForShow == ERegressRewardState.Claim);
	}

	// Token: 0x06009603 RID: 38403 RVA: 0x00205CC0 File Offset: 0x00203EC0
	private void SetupConstantTaskVisuals()
	{
		RegressQuest? config = this.Data.Config;
		int id = config.Value.Id;
		ValueTuple<int, int> taskProgressTuple = ActivityRegressModel.Instance.ActivityData.GetTaskProgressTuple(id);
		int item = taskProgressTuple.Item1;
		int item2 = taskProgressTuple.Item2;
		UUIText text = base.GetText(3);
		text.SetUIActive(true);
		UUIText uuitext = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		LguiUtil.Instance.SetLocalTextNew(text, "RecallActivity_Task_Tips", new <>z__ReadOnlyArray<object>(new object[]
		{
			item.ToString(),
			item2.ToString()
		}));
		base.GetItem(2).SetUIActive(true);
		int taskSubType = config.Value.TaskSubType;
		if (taskSubType == 1)
		{
			global::Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(1);
			global::RoleQuest firstShowRoleQuest = ActivityRegressModel.Instance.GetFirstShowRoleQuest();
			if (firstShowQuestByType == null && firstShowRoleQuest == null && taskRewardState != ERegressRewardState.Reached)
			{
				base.GetItem(2).SetUIActive(false);
				text.SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Recall_task_new_Finish01", Array.Empty<object>());
				base.GetText(8).SetText("", true);
			}
			else if (firstShowQuestByType != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RecallActivity_Recommended_Role", new <>z__ReadOnlySingleElementList<object>(firstShowQuestByType.Name));
			}
			else if (firstShowRoleQuest != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RecallActivity_Recommended_Role", new <>z__ReadOnlySingleElementList<object>(firstShowRoleQuest.Name));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RecallActivity_Recommended_Role_Lock", Array.Empty<object>());
			}
		}
		if (taskSubType == 2)
		{
			bool flag = ExploreProgressModel.Instance.IsCollectAllStageReward();
			if (flag && taskRewardState != ERegressRewardState.Reached)
			{
				base.GetItem(2).SetUIActive(false);
				text.SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Recall_task_new_Finish02", Array.Empty<object>());
			}
			else
			{
				Area? minExploreAreaInfo = ActivityRegressHelper.GetMinExploreAreaInfo();
				if (minExploreAreaInfo != null)
				{
					int deliveryMarkId = minExploreAreaInfo.Value.DeliveryMarkId;
					MapMark? configMark = MapConfig.Instance.GetConfigMark(deliveryMarkId);
					string multiText = TextConfig.Instance.GetMultiText(configMark.Value.MarkTitle, Array.Empty<string>());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RecallActivity_Recommended_Area", new <>z__ReadOnlySingleElementList<object>(multiText));
				}
			}
			if (flag)
			{
				base.GetText(8).SetText("", true);
			}
		}
	}

	// Token: 0x06009604 RID: 38404 RVA: 0x00205F5C File Offset: 0x0020415C
	private void SetupDailyTaskVisuals()
	{
		RegressQuest? config = this.Data.Config;
		int id = config.Value.Id;
		ValueTuple<int, int> taskProgressTuple = ActivityRegressModel.Instance.ActivityData.GetTaskProgressTuple(id);
		int item = taskProgressTuple.Item1;
		int item2 = taskProgressTuple.Item2;
		UUIText text = base.GetText(3);
		text.SetUIActive(true);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendLiteral("(");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetText(8).SetText("", true);
	}

	// Token: 0x06009605 RID: 38405 RVA: 0x00206010 File Offset: 0x00204210
	private ERegressRewardState GetTaskRewardStateForShow()
	{
		RegressQuest? config = this.Data.Config;
		int id = config.Value.Id;
		bool taskType = config.Value.TaskType != 0;
		ERegressRewardState eregressRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(id);
		if (taskType)
		{
			return eregressRewardState;
		}
		int taskSubType = this.Data.Config.Value.TaskSubType;
		if (taskSubType == 1)
		{
			int? firstUnFinishMainQuestId = ActivityRegressModel.Instance.GetFirstUnFinishMainQuestId();
			global::RoleQuest firstShowRoleQuest = ActivityRegressModel.Instance.GetFirstShowRoleQuest();
			if (firstUnFinishMainQuestId == null && firstShowRoleQuest == null && eregressRewardState != ERegressRewardState.Reached)
			{
				eregressRewardState = ERegressRewardState.Claim;
			}
		}
		if (taskSubType == 2 && ExploreProgressModel.Instance.IsCollectAllStageReward() && eregressRewardState != ERegressRewardState.Reached)
		{
			eregressRewardState = ERegressRewardState.Claim;
		}
		return eregressRewardState;
	}

	// Token: 0x06009606 RID: 38406 RVA: 0x002060C0 File Offset: 0x002042C0
	private void OnConfirmBtnClick(int _)
	{
		RegressQuest? config = this.Data.Config;
		ERegressRewardState taskRewardState = ActivityRegressModel.Instance.ActivityData.GetTaskRewardState(config.Value.Id);
		if (taskRewardState == ERegressRewardState.UnReach)
		{
			ActivityRegressController.Instance.JumpByQuestConfig(this.Data.Config.Value);
			return;
		}
		if (taskRewardState == ERegressRewardState.Reached)
		{
			if (ActivityRegressModel.Instance.ActivityData.IsRegressTaskScoreOverExp())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Task_Max", Array.Empty<object>());
			}
			ActivityRegressController.Instance.RequestClaimTaskReward(config.Value.Id);
		}
	}

	// Token: 0x06009607 RID: 38407 RVA: 0x0020615C File Offset: 0x0020435C
	[NullableContext(1)]
	private void OnExtendToggleClicked(MediumItemGridExtendCallback _)
	{
		RegressQuest? config = this.Data.Config;
		int id = ActivityRegressModel.Instance.GetRegressTaskRewardItemInfo(config.Value).ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null);
	}

	// Token: 0x04004246 RID: 16966
	private SmallItemGrid ItemGrid;

	// Token: 0x04004247 RID: 16967
	private ActivityRegressTaskDynamicData Data;

	// Token: 0x04004248 RID: 16968
	private ButtonItem ButtonItemE;

	// Token: 0x04004249 RID: 16969
	private ButtonItem ButtonItemB;

	// Token: 0x02007AE6 RID: 31462
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040286D7 RID: 165591
		public const int StripBtn = 0;

		// Token: 0x040286D8 RID: 165592
		public const int NameTxt = 1;

		// Token: 0x040286D9 RID: 165593
		public const int LinePanel = 2;

		// Token: 0x040286DA RID: 165594
		public const int NumTxt = 3;

		// Token: 0x040286DB RID: 165595
		public const int ItemBaseB = 4;

		// Token: 0x040286DC RID: 165596
		public const int DoneSpr = 5;

		// Token: 0x040286DD RID: 165597
		public const int DoingTxt = 6;

		// Token: 0x040286DE RID: 165598
		public const int BtnSecConfirm = 7;

		// Token: 0x040286DF RID: 165599
		public const int RecommendTxt = 8;

		// Token: 0x040286E0 RID: 165600
		public const int SprDone = 9;

		// Token: 0x040286E1 RID: 165601
		public const int BtnSecConfirmB = 10;
	}
}
