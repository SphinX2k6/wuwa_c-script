using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200691B RID: 26907
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityAnniversaryGift : AnniversarySubActivityDataBase
	{
		// Token: 0x0604318B RID: 274827 RVA: 0x01059ACC File Offset: 0x01057CCC
		public AnniversarySubActivityAnniversaryGift(int id) : base(id)
		{
		}

		// Token: 0x170097E9 RID: 38889
		// (get) Token: 0x0604318C RID: 274828 RVA: 0x01059AD5 File Offset: 0x01057CD5
		public ActivityTimePointRewardData ActivityData
		{
			get
			{
				if (this.ActivityDataCache == null)
				{
					this.ActivityDataCache = (base.GetActivityData() as ActivityTimePointRewardData);
				}
				return this.ActivityDataCache;
			}
		}

		// Token: 0x0604318D RID: 274829 RVA: 0x01059AF8 File Offset: 0x01057CF8
		[NullableContext(0)]
		public override ValueTuple<int, int> GetCurrentProgress()
		{
			int num = 0;
			int num2 = 0;
			IReadOnlyList<TimePointRewardActivity> timePointRewardListByActivityId = ActivityTimePointRewardConfig.Instance.GetTimePointRewardListByActivityId(this.ActivityId);
			if (timePointRewardListByActivityId != null)
			{
				foreach (TimePointRewardActivity timePointRewardActivity in timePointRewardListByActivityId)
				{
					for (int i = 0; i < timePointRewardActivity.RewardsLength; i++)
					{
						IntPair? intPair = timePointRewardActivity.Rewards(i);
						if (intPair != null && intPair.Value.Item1 == 74)
						{
							num += intPair.Value.Item2;
						}
					}
				}
			}
			ActivityTimePointRewardData activityTimePointRewardData = base.GetActivityData() as ActivityTimePointRewardData;
			List<TimePointRewardData> list = (activityTimePointRewardData != null) ? activityTimePointRewardData.GetRewardDataList() : null;
			if (list != null)
			{
				foreach (TimePointRewardData timePointRewardData in list)
				{
					TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(timePointRewardData.Id);
					if (timePointRewardById != null)
					{
						for (int j = 0; j < timePointRewardById.Value.RewardsLength; j++)
						{
							IntPair? intPair2 = timePointRewardById.Value.Rewards(j);
							if (intPair2 != null && intPair2.Value.Item1 == 74 && timePointRewardData.RewardState == ETimePointRewardState.UnlockAndClaimed)
							{
								num2 += intPair2.Value.Item2;
							}
						}
					}
				}
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x04022EEB RID: 143083
		private ActivityTimePointRewardData ActivityDataCache;
	}
}
