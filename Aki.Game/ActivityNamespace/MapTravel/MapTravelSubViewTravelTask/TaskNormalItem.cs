using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x02002F65 RID: 12133
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TaskNormalItem : TaskItemBase<ActivityTaskData>
	{
		// Token: 0x0601CBC8 RID: 117704 RVA: 0x008C55D4 File Offset: 0x008C37D4
		public TaskNormalItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0601CBC9 RID: 117705 RVA: 0x008C55E0 File Offset: 0x008C37E0
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

		// Token: 0x0601CBCA RID: 117706 RVA: 0x008C56F8 File Offset: 0x008C38F8
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

		// Token: 0x0601CBCB RID: 117707 RVA: 0x008C5788 File Offset: 0x008C3988
		protected override void OnClickedButton()
		{
			TravelTask? travelTaskConfig = ActivityMapTravelConfig.Instance.GetTravelTaskConfig(this.TaskData.Id);
			if (travelTaskConfig.Value.JumpId > 0)
			{
				SkipTaskManager.RunByConfigId(travelTaskConfig.Value.JumpId, null);
			}
		}

		// Token: 0x0601CBCC RID: 117708 RVA: 0x008C57D2 File Offset: 0x008C39D2
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x0601CBCD RID: 117709 RVA: 0x008C57DB File Offset: 0x008C39DB
		protected override void OnClickedRewardButton()
		{
			Action clickRewardBtnCb = this.ClickRewardBtnCb;
			if (clickRewardBtnCb == null)
			{
				return;
			}
			clickRewardBtnCb();
		}

		// Token: 0x0400F239 RID: 62009
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
