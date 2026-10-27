using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061EA RID: 25066
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorChallengeItem : RoadBookTaskItemBase<ActivityTaskData>
	{
		// Token: 0x0603F445 RID: 259141 RVA: 0x00F499E9 File Offset: 0x00F47BE9
		public MotorChallengeItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F446 RID: 259142 RVA: 0x00F499F4 File Offset: 0x00F47BF4
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			MotorcycleChallenge value = ActivityRoadBookConfig.Instance.GetMotorChallengeConfig(this.TaskData.Id).Value;
			bool uiactive = taskData.Status == EActivityTaskState.FinishedAndClaimed;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.ScoreText, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.RefreshRewardData(value.Reward);
			this.RewardButtonItem.SetUiActive(taskData.Status == EActivityTaskState.FinishedAndUnclaimed);
			base.GetItem(6).SetUIActive(taskData.Status == EActivityTaskState.Active);
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x0603F447 RID: 259143 RVA: 0x00F49AD3 File Offset: 0x00F47CD3
		public void SetClickRewardCb(Action clickRewardCb)
		{
			this.OnClickRewardCb = clickRewardCb;
		}

		// Token: 0x0603F448 RID: 259144 RVA: 0x00F49ADC File Offset: 0x00F47CDC
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

		// Token: 0x0603F449 RID: 259145 RVA: 0x00F49B6C File Offset: 0x00F47D6C
		protected override void OnClickedRewardButton()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x04020FDD RID: 135133
		protected new ActivityTaskData TaskData;

		// Token: 0x04020FDE RID: 135134
		[Nullable(2)]
		private Action OnClickRewardCb;
	}
}
