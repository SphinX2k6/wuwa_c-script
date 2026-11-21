using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D93 RID: 15763
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeDefine
	{
		// Token: 0x060284D7 RID: 165079 RVA: 0x00B4987D File Offset: 0x00B47A7D
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

		// Token: 0x060284D8 RID: 165080 RVA: 0x00B4989A File Offset: 0x00B47A9A
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

		// Token: 0x060284D9 RID: 165081 RVA: 0x00B498B8 File Offset: 0x00B47AB8
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

		// Token: 0x04015E7D RID: 89725
		public const int ROGUELIKE_BOSS_CHALLENGE_INSTANCE_SUCCESS = 3032;

		// Token: 0x02009975 RID: 39285
		private interface IIndexedBossData
		{
			// Token: 0x170078FF RID: 30975
			// (get) Token: 0x06044782 RID: 280450
			// (set) Token: 0x06044783 RID: 280451
			RoguelikeBossChallengeBossData BossData { get; set; }

			// Token: 0x17007900 RID: 30976
			// (get) Token: 0x06044784 RID: 280452
			// (set) Token: 0x06044785 RID: 280453
			int OriginalIndex { get; set; }
		}

		// Token: 0x02009976 RID: 39286
		[Nullable(0)]
		private class IndexedBossData : RoguelikeBossChallengeDefine.IIndexedBossData
		{
			// Token: 0x17007901 RID: 30977
			// (get) Token: 0x06044786 RID: 280454 RVA: 0x01469471 File Offset: 0x01467671
			// (set) Token: 0x06044787 RID: 280455 RVA: 0x01469479 File Offset: 0x01467679
			public RoguelikeBossChallengeBossData BossData { get; set; } = new RoguelikeBossChallengeBossData();

			// Token: 0x17007902 RID: 30978
			// (get) Token: 0x06044788 RID: 280456 RVA: 0x01469482 File Offset: 0x01467682
			// (set) Token: 0x06044789 RID: 280457 RVA: 0x0146948A File Offset: 0x0146768A
			public int OriginalIndex { get; set; }
		}
	}
}
