using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000963 RID: 2403
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressTaskScrollItemPanel : UiPanelBase
{
	// Token: 0x06006995 RID: 27029 RVA: 0x0020E918 File Offset: 0x0020CB18
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

	// Token: 0x06006996 RID: 27030 RVA: 0x0020EA24 File Offset: 0x0020CC24
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

	// Token: 0x06006997 RID: 27031 RVA: 0x0020EAFC File Offset: 0x0020CCFC
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

	// Token: 0x06006998 RID: 27032 RVA: 0x0020EC2C File Offset: 0x0020CE2C
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

	// Token: 0x06006999 RID: 27033 RVA: 0x0020EEC8 File Offset: 0x0020D0C8
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

	// Token: 0x0600699A RID: 27034 RVA: 0x0020EF7C File Offset: 0x0020D17C
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

	// Token: 0x0600699B RID: 27035 RVA: 0x0020F02C File Offset: 0x0020D22C
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

	// Token: 0x0600699C RID: 27036 RVA: 0x0020F0C8 File Offset: 0x0020D2C8
	[NullableContext(1)]
	private void OnExtendToggleClicked(MediumItemGridExtendCallback _)
	{
		RegressQuest? config = this.Data.Config;
		int id = ActivityRegressModel.Instance.GetRegressTaskRewardItemInfo(config.Value).ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null, false);
	}

	// Token: 0x040042DE RID: 17118
	private SmallItemGrid ItemGrid;

	// Token: 0x040042DF RID: 17119
	private ActivityRegressTaskDynamicData Data;

	// Token: 0x040042E0 RID: 17120
	private ButtonItem ButtonItemE;

	// Token: 0x040042E1 RID: 17121
	private ButtonItem ButtonItemB;

	// Token: 0x02006C6A RID: 27754
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040239F1 RID: 145905
		public const int StripBtn = 0;

		// Token: 0x040239F2 RID: 145906
		public const int NameTxt = 1;

		// Token: 0x040239F3 RID: 145907
		public const int LinePanel = 2;

		// Token: 0x040239F4 RID: 145908
		public const int NumTxt = 3;

		// Token: 0x040239F5 RID: 145909
		public const int ItemBaseB = 4;

		// Token: 0x040239F6 RID: 145910
		public const int DoneSpr = 5;

		// Token: 0x040239F7 RID: 145911
		public const int DoingTxt = 6;

		// Token: 0x040239F8 RID: 145912
		public const int BtnSecConfirm = 7;

		// Token: 0x040239F9 RID: 145913
		public const int RecommendTxt = 8;

		// Token: 0x040239FA RID: 145914
		public const int SprDone = 9;

		// Token: 0x040239FB RID: 145915
		public const int BtnSecConfirmB = 10;
	}
}
