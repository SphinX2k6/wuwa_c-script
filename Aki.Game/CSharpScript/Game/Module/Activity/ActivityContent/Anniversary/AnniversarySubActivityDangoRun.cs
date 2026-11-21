using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200586D RID: 22637
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityDangoRun : AnniversarySubActivityDataBase
	{
		// Token: 0x06037CE8 RID: 228584 RVA: 0x00F9B44C File Offset: 0x00F9964C
		public AnniversarySubActivityDangoRun(int id) : base(id)
		{
		}

		// Token: 0x17006B2A RID: 27434
		// (get) Token: 0x06037CE9 RID: 228585 RVA: 0x00F9B455 File Offset: 0x00F99655
		public RacingBetsSeasonData ActivityData
		{
			get
			{
				if (this.ActivityDataCache == null)
				{
					this.ActivityDataCache = (base.GetActivityData() as RacingBetsSeasonData);
				}
				return this.ActivityDataCache;
			}
		}

		// Token: 0x06037CEA RID: 228586 RVA: 0x00F9B478 File Offset: 0x00F99678
		public string GetCurrentDangoIconStr()
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			if (racingBetsSeasonData == null)
			{
				return null;
			}
			RacingBetsLegMatchData curLegMatchData = racingBetsSeasonData.GetCurLegMatchData();
			if (curLegMatchData == null || !curLegMatchData.HasBetting || curLegMatchData.BetDangoId == 0)
			{
				return null;
			}
			if (racingBetsSeasonData.IsFinalLegMatch(curLegMatchData.Id) && curLegMatchData.GetLegMatchState() >= ERacingBetsLegMatchState.EndOfMatch)
			{
				return null;
			}
			Dango? dangoById = DangoConfig.Instance.GetDangoById(curLegMatchData.BetDangoId);
			if (dangoById == null)
			{
				return null;
			}
			return dangoById.Value.IconSmall;
		}

		// Token: 0x06037CEB RID: 228587 RVA: 0x00F9B4F8 File Offset: 0x00F996F8
		[NullableContext(0)]
		public override ValueTuple<int, int> GetCurrentProgress()
		{
			int num = 0;
			int num2 = 0;
			int activityId = this.ActivityId;
			IReadOnlyList<RacingBetsReward> racingBetsRewardList = RacingBetsConfig.Instance.GetRacingBetsRewardList(activityId);
			if (racingBetsRewardList != null)
			{
				foreach (RacingBetsReward racingBetsReward in racingBetsRewardList)
				{
					if (racingBetsReward.RewardType == 1 || racingBetsReward.RewardType == 3)
					{
						for (int i = 0; i < racingBetsReward.TargetRewardLength; i++)
						{
							DicIntInt? dicIntInt = racingBetsReward.TargetReward(i);
							if (dicIntInt != null && dicIntInt.Value.Key == 74)
							{
								num += dicIntInt.Value.Value;
							}
						}
					}
				}
			}
			RacingBetsSeasonData activityData = this.ActivityData;
			if (activityData == null || activityData.CheckIfClose())
			{
				int progressFromAnniversaryRemainder = this.GetProgressFromAnniversaryRemainder();
				num2 = Math.Max(0, Math.Min(progressFromAnniversaryRemainder, num));
				return new ValueTuple<int, int>(num2, num);
			}
			RacingBetsGroupRewardData groupRewardData = activityData.GetGroupRewardData(ERacingBetsRewardType.BetsCount);
			RacingBetsGroupRewardData groupRewardData2 = activityData.GetGroupRewardData(ERacingBetsRewardType.DailyEarn);
			foreach (RacingBetsRewardData racingBetsRewardData in groupRewardData.GetRewardDataList())
			{
				RacingBetsReward? rewardConfig = racingBetsRewardData.RewardConfig;
				if (rewardConfig != null)
				{
					for (int j = 0; j < rewardConfig.Value.TargetRewardLength; j++)
					{
						DicIntInt? dicIntInt2 = rewardConfig.Value.TargetReward(j);
						if (dicIntInt2 != null && dicIntInt2.Value.Key == 74 && racingBetsRewardData.IsTaskReceived())
						{
							num2 += dicIntInt2.Value.Value;
						}
					}
				}
			}
			foreach (RacingBetsRewardData racingBetsRewardData2 in groupRewardData2.GetRewardDataList())
			{
				RacingBetsReward? rewardConfig2 = racingBetsRewardData2.RewardConfig;
				if (rewardConfig2 != null)
				{
					for (int k = 0; k < rewardConfig2.Value.TargetRewardLength; k++)
					{
						DicIntInt? dicIntInt3 = rewardConfig2.Value.TargetReward(k);
						if (dicIntInt3 != null && dicIntInt3.Value.Key == 74 && racingBetsRewardData2.IsTaskReceived())
						{
							num2 += dicIntInt3.Value.Value;
						}
					}
				}
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x06037CEC RID: 228588 RVA: 0x00F9B790 File Offset: 0x00F99990
		private int GetProgressFromAnniversaryRemainder()
		{
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(97);
			if (activitiesByType == null || activitiesByType.Count == 0)
			{
				return 0;
			}
			AnniversaryActivityData anniversaryActivityData = activitiesByType[0] as AnniversaryActivityData;
			if (anniversaryActivityData == null)
			{
				return 0;
			}
			int personalCurProgress = anniversaryActivityData.GetPersonalCurProgress();
			int num = 0;
			foreach (EAnniversarySubId id in new EAnniversarySubId[]
			{
				EAnniversarySubId.AnniversaryGift,
				EAnniversarySubId.Pinball,
				EAnniversarySubId.WuWuPack
			})
			{
				AnniversarySubActivityDataBase targetSubActivityData = anniversaryActivityData.GetTargetSubActivityData(id);
				if (targetSubActivityData != null)
				{
					int item = targetSubActivityData.GetCurrentProgress().Item1;
					num += item;
				}
			}
			return personalCurProgress - num;
		}

		// Token: 0x0401D748 RID: 120648
		private RacingBetsSeasonData ActivityDataCache;
	}
}
