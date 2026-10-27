using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x0200691D RID: 26909
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityDangoRun : AnniversarySubActivityDataBase
	{
		// Token: 0x06043190 RID: 274832 RVA: 0x01059E20 File Offset: 0x01058020
		public AnniversarySubActivityDangoRun(int id) : base(id)
		{
		}

		// Token: 0x170097EA RID: 38890
		// (get) Token: 0x06043191 RID: 274833 RVA: 0x01059E29 File Offset: 0x01058029
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

		// Token: 0x06043192 RID: 274834 RVA: 0x01059E4C File Offset: 0x0105804C
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

		// Token: 0x06043193 RID: 274835 RVA: 0x01059ECC File Offset: 0x010580CC
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

		// Token: 0x06043194 RID: 274836 RVA: 0x0105A164 File Offset: 0x01058364
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

		// Token: 0x04022EEC RID: 143084
		private RacingBetsSeasonData ActivityDataCache;
	}
}
