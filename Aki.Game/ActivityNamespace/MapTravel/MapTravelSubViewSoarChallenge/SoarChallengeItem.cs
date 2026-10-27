using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewSoarChallenge
{
	// Token: 0x020044DB RID: 17627
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SoarChallengeItem : TaskItemBase<ActivityTaskData>
	{
		// Token: 0x0602D6A8 RID: 186024 RVA: 0x00A401A7 File Offset: 0x00A3E3A7
		public SoarChallengeItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0602D6A9 RID: 186025 RVA: 0x00A401B0 File Offset: 0x00A3E3B0
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			SoarChallenge value = ActivityMapTravelConfig.Instance.GetSoarChallengeConfig(this.TaskData.Id).Value;
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

		// Token: 0x0602D6AA RID: 186026 RVA: 0x00A4028F File Offset: 0x00A3E48F
		public void SetClickRewardCb(Action clickRewardCb)
		{
			this.OnClickRewardCb = clickRewardCb;
		}

		// Token: 0x0602D6AB RID: 186027 RVA: 0x00A40298 File Offset: 0x00A3E498
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

		// Token: 0x0602D6AC RID: 186028 RVA: 0x00A40328 File Offset: 0x00A3E528
		protected override void OnClickedRewardButton()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x04018498 RID: 99480
		[Nullable(2)]
		private Action OnClickRewardCb;
	}
}
