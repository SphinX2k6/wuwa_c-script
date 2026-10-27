using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006284 RID: 25220
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskNormalItem : RealmBetweenTaskItemBase<ActivityTaskData>
	{
		// Token: 0x0603F7A0 RID: 260000 RVA: 0x00F587AC File Offset: 0x00F569AC
		public RealmBetweenTaskNormalItem(ActivityRealmBetweenData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F7A1 RID: 260001 RVA: 0x00F587B8 File Offset: 0x00F569B8
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

		// Token: 0x0603F7A2 RID: 260002 RVA: 0x00F588D4 File Offset: 0x00F56AD4
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

		// Token: 0x0603F7A3 RID: 260003 RVA: 0x00F58964 File Offset: 0x00F56B64
		protected override void OnClickedButton()
		{
			RealmBetweenTask value = ActivityRealmBetweenConfig.Instance.GetRealmBetweenTaskConfig(this.TaskData.Id).Value;
			if (value.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(value.JumpId, null);
			}
		}

		// Token: 0x0603F7A4 RID: 260004 RVA: 0x00F589A5 File Offset: 0x00F56BA5
		public void SetBtnClickCallback(Action callback)
		{
			this.ClickRewardBtnCb = callback;
		}

		// Token: 0x0603F7A5 RID: 260005 RVA: 0x00F589AE File Offset: 0x00F56BAE
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

		// Token: 0x040212CC RID: 135884
		protected new ActivityTaskData TaskData;

		// Token: 0x040212CD RID: 135885
		[Nullable(2)]
		private Action ClickRewardBtnCb;
	}
}
