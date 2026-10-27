using System;
using System.Collections.Generic;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200691C RID: 26908
	public class AnniversarySubActivityAnniversaryGiftUiItem : AnniversaryActivityEnterItem
	{
		// Token: 0x0604318E RID: 274830 RVA: 0x01059C94 File Offset: 0x01057E94
		public override void ChildUpdateTips()
		{
			UUIText text = base.GetText(1);
			if (text == null || this.Data == null)
			{
				return;
			}
			text.SetUIActive(false);
			ActivityTimePointRewardData activityTimePointRewardData = this.Data.GetActivityData() as ActivityTimePointRewardData;
			if (activityTimePointRewardData == null)
			{
				return;
			}
			List<TimePointRewardData> rewardDataList = activityTimePointRewardData.GetRewardDataList();
			if (rewardDataList == null || rewardDataList.Count == 0)
			{
				return;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			long num = 0L;
			bool flag = false;
			foreach (TimePointRewardData timePointRewardData in rewardDataList)
			{
				if (timePointRewardData.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
				{
					flag = true;
					break;
				}
				if (timePointRewardData.RewardState == ETimePointRewardState.Lock && (double)timePointRewardData.RewardTime > serverTime && (num == 0L || timePointRewardData.RewardTime < num))
				{
					num = timePointRewardData.RewardTime;
				}
			}
			if (flag)
			{
				text.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(text, "Activity_Anniversary2_03_Reward", Array.Empty<object>());
				return;
			}
			if (num > 0L)
			{
				double num2 = (double)num * TimeUtil.Instance.Millisecond;
				if (num2 - serverTime > 0.0)
				{
					string text2 = TextConfig.Instance.GetMultiTextByKey("Activity_Anniversary2_03_Time") ?? "";
					string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)num2, text2);
					if (string.IsNullOrEmpty(remainTimeText))
					{
						return;
					}
					text.SetUIActive(true);
					text.SetText(remainTimeText, true);
					return;
				}
				else
				{
					text.SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(text, "Activity_Anniversary2_03_Reward", Array.Empty<object>());
				}
			}
		}
	}
}
