using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006286 RID: 25222
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorChallengeItem : RealmBetweenTaskItemBase<ActivityTaskData>
	{
		// Token: 0x0603F7A9 RID: 260009 RVA: 0x00F58AB0 File Offset: 0x00F56CB0
		public MotorChallengeItem(ActivityRealmBetweenData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F7AA RID: 260010 RVA: 0x00F58ABC File Offset: 0x00F56CBC
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			RealmBetweenChallenge value = ActivityRealmBetweenConfig.Instance.GetMotorChallengeConfig(this.TaskData.Id).Value;
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

		// Token: 0x0603F7AB RID: 260011 RVA: 0x00F58B9B File Offset: 0x00F56D9B
		public void SetClickRewardCb(Action clickRewardCb)
		{
			this.OnClickRewardCb = clickRewardCb;
		}

		// Token: 0x0603F7AC RID: 260012 RVA: 0x00F58BA4 File Offset: 0x00F56DA4
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

		// Token: 0x0603F7AD RID: 260013 RVA: 0x00F58C34 File Offset: 0x00F56E34
		protected override void OnClickedRewardButton()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x040212CF RID: 135887
		protected new ActivityTaskData TaskData;

		// Token: 0x040212D0 RID: 135888
		[Nullable(2)]
		private Action OnClickRewardCb;
	}
}
