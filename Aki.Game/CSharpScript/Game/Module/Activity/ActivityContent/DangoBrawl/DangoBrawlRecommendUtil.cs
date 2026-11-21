using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200572D RID: 22317
	public static class DangoBrawlRecommendUtil
	{
		// Token: 0x06036EBA RID: 224954 RVA: 0x00F51198 File Offset: 0x00F4F398
		public static bool IsItemRecommended(int itemConfigId, int roleId, int challengeId, int roundNum)
		{
			int occupationId = DangoBrawlRecommendUtil.GetOccupationId(roleId);
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(itemConfigId);
			return dangoBrawlItemById != null && DangoBrawlRecommendUtil.CheckOccupation(dangoBrawlItemById.Value.GetRecommendOccupationArray(), occupationId) && DangoBrawlRecommendUtil.CheckRoundQuality(dangoBrawlItemById.Value, challengeId, roundNum);
		}

		// Token: 0x06036EBB RID: 224955 RVA: 0x00F511F0 File Offset: 0x00F4F3F0
		public static bool IsEvtRecommended(int evtConfigId, int roleId)
		{
			DangoBrawlShopEvt? shopEvtConfigById = DangoBrawlConfig.Instance.GetShopEvtConfigById(evtConfigId);
			return shopEvtConfigById != null && DangoBrawlRecommendUtil.CheckOccupation(shopEvtConfigById.Value.GetRecommendOccupationArray(), DangoBrawlRecommendUtil.GetOccupationId(roleId));
		}

		// Token: 0x06036EBC RID: 224956 RVA: 0x00F51230 File Offset: 0x00F4F430
		private static int GetOccupationId(int roleId)
		{
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleId);
			if (roleConfigById == null)
			{
				return 0;
			}
			return roleConfigById.GetValueOrDefault().OccupationId;
		}

		// Token: 0x06036EBD RID: 224957 RVA: 0x00F51264 File Offset: 0x00F4F464
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

		// Token: 0x06036EBE RID: 224958 RVA: 0x00F51290 File Offset: 0x00F4F490
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
