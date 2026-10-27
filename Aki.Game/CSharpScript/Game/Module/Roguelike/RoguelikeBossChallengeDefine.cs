using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DCA RID: 19914
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeDefine
	{
		// Token: 0x0603366A RID: 210538 RVA: 0x00C0033D File Offset: 0x00BFE53D
		public static ERoguelikeBossChallengeBossState ConvertProtoToBossState(RogueTowerTrialBossState protoState)
		{
			switch (protoState)
			{
			case RogueTowerTrialBossState.IsLock:
				return ERoguelikeBossChallengeBossState.Locked;
			case RogueTowerTrialBossState.Selectable:
				return ERoguelikeBossChallengeBossState.Processing;
			case RogueTowerTrialBossState.Completed:
				return ERoguelikeBossChallengeBossState.Finished;
			default:
				return ERoguelikeBossChallengeBossState.Locked;
			}
		}

		// Token: 0x0603366B RID: 210539 RVA: 0x00C0035A File Offset: 0x00BFE55A
		private static int GetBossStateSortPriority(ERoguelikeBossChallengeBossState state)
		{
			switch (state)
			{
			case ERoguelikeBossChallengeBossState.Finished:
				return 0;
			case ERoguelikeBossChallengeBossState.Processing:
				return 1;
			case ERoguelikeBossChallengeBossState.Locked:
				return 2;
			default:
				return 3;
			}
		}

		// Token: 0x0603366C RID: 210540 RVA: 0x00C00378 File Offset: 0x00BFE578
		public static List<RoguelikeBossChallengeBossData> SortBossDataListStable(List<RoguelikeBossChallengeBossData> dataList)
		{
			List<RoguelikeBossChallengeDefine.IndexedBossData> list = new List<RoguelikeBossChallengeDefine.IndexedBossData>();
			for (int i = 0; i < dataList.Count; i++)
			{
				list.Add(new RoguelikeBossChallengeDefine.IndexedBossData
				{
					BossData = dataList[i],
					OriginalIndex = i
				});
			}
			list.Sort(delegate(RoguelikeBossChallengeDefine.IndexedBossData a, RoguelikeBossChallengeDefine.IndexedBossData b)
			{
				int num = RoguelikeBossChallengeDefine.GetBossStateSortPriority(a.BossData.State) - RoguelikeBossChallengeDefine.GetBossStateSortPriority(b.BossData.State);
				if (num == 0)
				{
					return a.OriginalIndex - b.OriginalIndex;
				}
				return num;
			});
			List<RoguelikeBossChallengeBossData> list2 = new List<RoguelikeBossChallengeBossData>();
			foreach (RoguelikeBossChallengeDefine.IndexedBossData indexedBossData in list)
			{
				list2.Add(indexedBossData.BossData);
			}
			return list2;
		}

		// Token: 0x0401B4AA RID: 111786
		public const int ROGUELIKE_BOSS_CHALLENGE_INSTANCE_SUCCESS = 3032;

		// Token: 0x0200AF40 RID: 44864
		private interface IIndexedBossData
		{
			// Token: 0x1700A161 RID: 41313
			// (get) Token: 0x0604E183 RID: 319875
			// (set) Token: 0x0604E184 RID: 319876
			RoguelikeBossChallengeBossData BossData { get; set; }

			// Token: 0x1700A162 RID: 41314
			// (get) Token: 0x0604E185 RID: 319877
			// (set) Token: 0x0604E186 RID: 319878
			int OriginalIndex { get; set; }
		}

		// Token: 0x0200AF41 RID: 44865
		[Nullable(0)]
		private class IndexedBossData : RoguelikeBossChallengeDefine.IIndexedBossData
		{
			// Token: 0x1700A163 RID: 41315
			// (get) Token: 0x0604E187 RID: 319879 RVA: 0x014B02E1 File Offset: 0x014AE4E1
			// (set) Token: 0x0604E188 RID: 319880 RVA: 0x014B02E9 File Offset: 0x014AE4E9
			public RoguelikeBossChallengeBossData BossData { get; set; } = new RoguelikeBossChallengeBossData();

			// Token: 0x1700A164 RID: 41316
			// (get) Token: 0x0604E189 RID: 319881 RVA: 0x014B02F2 File Offset: 0x014AE4F2
			// (set) Token: 0x0604E18A RID: 319882 RVA: 0x014B02FA File Offset: 0x014AE4FA
			public int OriginalIndex { get; set; }
		}
	}
}
