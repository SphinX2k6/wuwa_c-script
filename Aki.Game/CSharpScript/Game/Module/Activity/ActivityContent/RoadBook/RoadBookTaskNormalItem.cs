using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E8 RID: 25064
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskNormalItem : RoadBookTaskItemBase<ActivityTaskData>
	{
		// Token: 0x0603F43C RID: 259132 RVA: 0x00F4972C File Offset: 0x00F4792C
		public RoadBookTaskNormalItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F43D RID: 259133 RVA: 0x00F49738 File Offset: 0x00F47938
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			RoadBookTask value = ActivityRoadBookConfig.Instance.GetRoadBookTaskConfig(this.TaskData.Id).Value;
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

		// Token: 0x0603F43E RID: 259134 RVA: 0x00F49850 File Offset: 0x00F47A50
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

		// Token: 0x0603F43F RID: 259135 RVA: 0x00F498E0 File Offset: 0x00F47AE0
		protected override void OnClickedButton()
		{
			RoadBookTask value = ActivityRoadBookConfig.Instance.GetRoadBookTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x0603F440 RID: 259136 RVA: 0x00F49921 File Offset: 0x00F47B21
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x0603F441 RID: 259137 RVA: 0x00F4992A File Offset: 0x00F47B2A
		protected override void OnClickedRewardButton()
		{
			Action clickRewardBtnCb = this.ClickRewardBtnCb;
			if (clickRewardBtnCb == null)
			{
				return;
			}
			clickRewardBtnCb();
		}

		// Token: 0x04020FDA RID: 135130
		protected new ActivityTaskData TaskData;

		// Token: 0x04020FDB RID: 135131
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
