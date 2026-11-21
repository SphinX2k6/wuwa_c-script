using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005166 RID: 20838
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskNormalItem : RoadBookTaskItemBase<ActivityTaskData>
	{
		// Token: 0x060340FD RID: 213245 RVA: 0x00E90684 File Offset: 0x00E8E884
		public RoadBookTaskNormalItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x060340FE RID: 213246 RVA: 0x00E90690 File Offset: 0x00E8E890
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

		// Token: 0x060340FF RID: 213247 RVA: 0x00E907A8 File Offset: 0x00E8E9A8
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

		// Token: 0x06034100 RID: 213248 RVA: 0x00E90838 File Offset: 0x00E8EA38
		protected override void OnClickedButton()
		{
			RoadBookTask value = ActivityRoadBookConfig.Instance.GetRoadBookTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x06034101 RID: 213249 RVA: 0x00E90879 File Offset: 0x00E8EA79
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x06034102 RID: 213250 RVA: 0x00E90882 File Offset: 0x00E8EA82
		protected override void OnClickedRewardButton()
		{
			Action clickRewardBtnCb = this.ClickRewardBtnCb;
			if (clickRewardBtnCb == null)
			{
				return;
			}
			clickRewardBtnCb();
		}

		// Token: 0x0401B909 RID: 112905
		protected new ActivityTaskData TaskData;

		// Token: 0x0401B90A RID: 112906
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
