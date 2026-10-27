using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B1 RID: 22449
	[NullableContext(2)]
	public interface IExtendRewardInfo
	{
		// Token: 0x17008906 RID: 35078
		// (get) Token: 0x06039109 RID: 233737
		// (set) Token: 0x0603910A RID: 233738
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

		// Token: 0x17008907 RID: 35079
		// (get) Token: 0x0603910B RID: 233739
		// (set) Token: 0x0603910C RID: 233740
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

		// Token: 0x17008908 RID: 35080
		// (get) Token: 0x0603910D RID: 233741
		// (set) Token: 0x0603910E RID: 233742
		IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17008909 RID: 35081
		// (get) Token: 0x0603910F RID: 233743
		// (set) Token: 0x06039110 RID: 233744
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

		// Token: 0x1700890A RID: 35082
		// (get) Token: 0x06039111 RID: 233745
		// (set) Token: 0x06039112 RID: 233746
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

		// Token: 0x1700890B RID: 35083
		// (get) Token: 0x06039113 RID: 233747
		// (set) Token: 0x06039114 RID: 233748
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

		// Token: 0x1700890C RID: 35084
		// (get) Token: 0x06039115 RID: 233749
		// (set) Token: 0x06039116 RID: 233750
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

		// Token: 0x1700890D RID: 35085
		// (get) Token: 0x06039117 RID: 233751
		// (set) Token: 0x06039118 RID: 233752
		IRewardExploreScoreBelongHalfArea ScoreHalfArea { get; set; }

		// Token: 0x1700890E RID: 35086
		// (get) Token: 0x06039119 RID: 233753
		// (set) Token: 0x0603911A RID: 233754
		ReachTargetData ScoreReached { get; set; }

		// Token: 0x1700890F RID: 35087
		// (get) Token: 0x0603911B RID: 233755
		// (set) Token: 0x0603911C RID: 233756
		IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x17008910 RID: 35088
		// (get) Token: 0x0603911D RID: 233757
		// (set) Token: 0x0603911E RID: 233758
		AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17008911 RID: 35089
		// (get) Token: 0x0603911F RID: 233759
		// (set) Token: 0x06039120 RID: 233760
		IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17008912 RID: 35090
		// (get) Token: 0x06039121 RID: 233761
		// (set) Token: 0x06039122 RID: 233762
		IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17008913 RID: 35091
		// (get) Token: 0x06039123 RID: 233763
		// (set) Token: 0x06039124 RID: 233764
		IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17008914 RID: 35092
		// (get) Token: 0x06039125 RID: 233765
		// (set) Token: 0x06039126 RID: 233766
		IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
