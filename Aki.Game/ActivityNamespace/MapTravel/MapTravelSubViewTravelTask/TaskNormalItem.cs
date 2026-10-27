using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x020044D8 RID: 17624
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TaskNormalItem : TaskItemBase<ActivityTaskData>
	{
		// Token: 0x0602D68A RID: 185994 RVA: 0x00A3F970 File Offset: 0x00A3DB70
		public TaskNormalItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0602D68B RID: 185995 RVA: 0x00A3F97C File Offset: 0x00A3DB7C
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			TravelTask value = ActivityMapTravelConfig.Instance.GetTravelTaskConfig(this.TaskData.Id).Value;
			bool flag = taskData.Status == EActivityTaskState.FinishedAndClaimed;
			bool uiActive = value.JumpId > 0 && taskData.Status == EActivityTaskState.Active;
			bool uiActive2 = taskData.Status == EActivityTaskState.FinishedAndUnclaimed;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(taskData.Current, taskData.Target));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.RefreshRewardData(value.TaskReward);
			this.ButtonItem.SetUiActive(uiActive);
			this.RewardButtonItem.SetUiActive(uiActive2);
			base.GetItem(6).SetUIActive(value.JumpId == 0 && !flag);
			base.GetItem(5).SetUIActive(flag);
		}

		// Token: 0x0602D68C RID: 185996 RVA: 0x00A3FA94 File Offset: 0x00A3DC94
		private void RefreshRewardData(int rewardId)
		{
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId))
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = (this.TaskData.Status == EActivityTaskState.FinishedAndClaimed)
				};
				list.Add(item2);
			}
			this.RewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x0602D68D RID: 185997 RVA: 0x00A3FB24 File Offset: 0x00A3DD24
		protected override void OnClickedButton()
		{
			TravelTask? travelTaskConfig = ActivityMapTravelConfig.Instance.GetTravelTaskConfig(this.TaskData.Id);
			if (travelTaskConfig.Value.JumpId > 0)
			{
				SkipTaskManager.RunByConfigId(travelTaskConfig.Value.JumpId, null);
			}
		}

		// Token: 0x0602D68E RID: 185998 RVA: 0x00A3FB6E File Offset: 0x00A3DD6E
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x0602D68F RID: 185999 RVA: 0x00A3FB77 File Offset: 0x00A3DD77
		protected override void OnClickedRewardButton()
		{
			Action clickRewardBtnCb = this.ClickRewardBtnCb;
			if (clickRewardBtnCb == null)
			{
				return;
			}
			clickRewardBtnCb();
		}

		// Token: 0x04018491 RID: 99473
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
