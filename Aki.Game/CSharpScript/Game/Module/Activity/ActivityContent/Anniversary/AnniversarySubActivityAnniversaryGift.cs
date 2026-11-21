using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200586B RID: 22635
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityAnniversaryGift : AnniversarySubActivityDataBase
	{
		// Token: 0x06037CE3 RID: 228579 RVA: 0x00F9B0F8 File Offset: 0x00F992F8
		public AnniversarySubActivityAnniversaryGift(int id) : base(id)
		{
		}

		// Token: 0x17006B29 RID: 27433
		// (get) Token: 0x06037CE4 RID: 228580 RVA: 0x00F9B101 File Offset: 0x00F99301
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

		// Token: 0x06037CE5 RID: 228581 RVA: 0x00F9B124 File Offset: 0x00F99324
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

		// Token: 0x0401D747 RID: 120647
		private ActivityTimePointRewardData ActivityDataCache;
	}
}
