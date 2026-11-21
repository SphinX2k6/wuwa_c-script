using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004788 RID: 18312
	[NullableContext(2)]
	public interface IExtendRewardInfo
	{
		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x0602E019 RID: 188441
		// (set) Token: 0x0602E01A RID: 188442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<RewardItemData> ItemList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x0602E01B RID: 188443
		// (set) Token: 0x0602E01C RID: 188444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<IRewardProgress> ProgressQueue { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x0602E01D RID: 188445
		// (set) Token: 0x0602E01E RID: 188446
		IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x0602E01F RID: 188447
		// (set) Token: 0x0602E020 RID: 188448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<IRewardExploreBar> ExploreBarDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0602E021 RID: 188449
		// (set) Token: 0x0602E022 RID: 188450
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<IRewardExploreFriendData> ExploreFriendDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0602E023 RID: 188451
		// (set) Token: 0x0602E024 RID: 188452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<IRewardExploreConfirmButton> ButtonInfoList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x0602E025 RID: 188453
		// (set) Token: 0x0602E026 RID: 188454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<IRewardExploreTargetReached> TargetReached { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x0602E027 RID: 188455
		// (set) Token: 0x0602E028 RID: 188456
		IRewardExploreScoreBelongHalfArea ScoreHalfArea { get; set; }

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x0602E029 RID: 188457
		// (set) Token: 0x0602E02A RID: 188458
		ReachTargetData ScoreReached { get; set; }

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x0602E02B RID: 188459
		// (set) Token: 0x0602E02C RID: 188460
		IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x0602E02D RID: 188461
		// (set) Token: 0x0602E02E RID: 188462
		AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x0602E02F RID: 188463
		// (set) Token: 0x0602E030 RID: 188464
		IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x0602E031 RID: 188465
		// (set) Token: 0x0602E032 RID: 188466
		IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x0602E033 RID: 188467
		// (set) Token: 0x0602E034 RID: 188468
		IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x0602E035 RID: 188469
		// (set) Token: 0x0602E036 RID: 188470
		IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
