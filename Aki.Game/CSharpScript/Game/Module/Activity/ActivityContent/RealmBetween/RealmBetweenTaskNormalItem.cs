using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005202 RID: 20994
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskNormalItem : RealmBetweenTaskItemBase<ActivityTaskData>
	{
		// Token: 0x06034461 RID: 214113 RVA: 0x00E9F708 File Offset: 0x00E9D908
		public RealmBetweenTaskNormalItem(ActivityRealmBetweenData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x06034462 RID: 214114 RVA: 0x00E9F714 File Offset: 0x00E9D914
		public override void Refresh(ActivityTaskData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			bool flag = taskData.Status == EActivityTaskState.FinishedAndClaimed;
			bool uiActive = value.JumpId > 0 && taskData.Status == EActivityTaskState.Active;
			bool flag2 = taskData.Status == EActivityTaskState.FinishedAndUnclaimed;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(taskData.Current, taskData.Target));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.RefreshRewardData(value.TaskReward);
			this.ButtonItem.SetUiActive(uiActive);
			this.RewardButtonItem.SetUiActive(flag2);
			base.GetItem(6).SetUIActive(value.JumpId == 0 && !flag && !flag2);
			base.GetItem(5).SetUIActive(flag);
		}

		// Token: 0x06034463 RID: 214115 RVA: 0x00E9F830 File Offset: 0x00E9DA30
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

		// Token: 0x06034464 RID: 214116 RVA: 0x00E9F8C0 File Offset: 0x00E9DAC0
		protected override void OnClickedButton()
		{
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x06034465 RID: 214117 RVA: 0x00E9F901 File Offset: 0x00E9DB01
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x06034466 RID: 214118 RVA: 0x00E9F90A File Offset: 0x00E9DB0A
		protected override void OnClickedRewardButton()
		{
			if (this.ClickRewardBtnCb != null)
			{
				this.ClickRewardBtnCb();
				return;
			}
			ActivityRealmBetweenController.Instance.RequestMultiRealmBetweenTaskReward(new int[]
			{
				this.TaskData.Id
			});
		}

		// Token: 0x0401BBFB RID: 113659
		protected new ActivityTaskData TaskData;

		// Token: 0x0401BBFC RID: 113660
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
