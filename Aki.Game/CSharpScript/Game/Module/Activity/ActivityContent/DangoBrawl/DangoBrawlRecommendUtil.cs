using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067DD RID: 26589
	public static class DangoBrawlRecommendUtil
	{
		// Token: 0x06042364 RID: 271204 RVA: 0x0100FCC8 File Offset: 0x0100DEC8
		public static bool IsItemRecommended(int itemConfigId, int roleId, int challengeId, int roundNum)
		{
			int occupationId = DangoBrawlRecommendUtil.GetOccupationId(roleId);
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(itemConfigId);
			return dangoBrawlItemById != null && DangoBrawlRecommendUtil.CheckOccupation(dangoBrawlItemById.Value.GetRecommendOccupationArray(), occupationId) && DangoBrawlRecommendUtil.CheckRoundQuality(dangoBrawlItemById.Value, challengeId, roundNum);
		}

		// Token: 0x06042365 RID: 271205 RVA: 0x0100FD20 File Offset: 0x0100DF20
		public static bool IsEvtRecommended(int evtConfigId, int roleId)
		{
			DangoBrawlShopEvt? shopEvtConfigById = DangoBrawlConfig.Instance.GetShopEvtConfigById(evtConfigId);
			return shopEvtConfigById != null && DangoBrawlRecommendUtil.CheckOccupation(shopEvtConfigById.Value.GetRecommendOccupationArray(), DangoBrawlRecommendUtil.GetOccupationId(roleId));
		}

		// Token: 0x06042366 RID: 271206 RVA: 0x0100FD60 File Offset: 0x0100DF60
		private static int GetOccupationId(int roleId)
		{
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleId);
			if (roleConfigById == null)
			{
				return 0;
			}
			return roleConfigById.GetValueOrDefault().OccupationId;
		}

		// Token: 0x06042367 RID: 271207 RVA: 0x0100FD94 File Offset: 0x0100DF94
		[NullableContext(1)]
		private static bool CheckOccupation(int[] recommendOccupations, int occupation)
		{
			if (recommendOccupations.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < recommendOccupations.Length; i++)
			{
				if (recommendOccupations[i] == occupation)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06042368 RID: 271208 RVA: 0x0100FDC0 File Offset: 0x0100DFC0
		private static bool CheckRoundQuality(DangoBrawlItem item, int challengeId, int roundNum)
		{
			DangoBrawlChallenge? dangoBrawlChallengeById = DangoBrawlConfig.Instance.GetDangoBrawlChallengeById(challengeId);
			if (dangoBrawlChallengeById == null)
			{
				return false;
			}
			int num = roundNum - 1;
			if (num < 0 || num >= dangoBrawlChallengeById.Value.RecommendQualityLength)
			{
				return false;
			}
			DicIntInt? dicIntInt = dangoBrawlChallengeById.Value.RecommendQuality(num);
			return dicIntInt != null && item.Quality >= dicIntInt.Value.Value;
		}
	}
}
