using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004789 RID: 18313
	[NullableContext(2)]
	[Nullable(0)]
	public class ExtendRewardInfo : IExtendRewardInfo
	{
		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x0602E037 RID: 188471 RVA: 0x00CDE94A File Offset: 0x00CDCB4A
		// (set) Token: 0x0602E038 RID: 188472 RVA: 0x00CDE952 File Offset: 0x00CDCB52
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> ItemList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x0602E039 RID: 188473 RVA: 0x00CDE95B File Offset: 0x00CDCB5B
		// (set) Token: 0x0602E03A RID: 188474 RVA: 0x00CDE963 File Offset: 0x00CDCB63
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardProgress> ProgressQueue { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x0602E03B RID: 188475 RVA: 0x00CDE96C File Offset: 0x00CDCB6C
		// (set) Token: 0x0602E03C RID: 188476 RVA: 0x00CDE974 File Offset: 0x00CDCB74
		public IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x0602E03D RID: 188477 RVA: 0x00CDE97D File Offset: 0x00CDCB7D
		// (set) Token: 0x0602E03E RID: 188478 RVA: 0x00CDE985 File Offset: 0x00CDCB85
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreBar> ExploreBarDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0602E03F RID: 188479 RVA: 0x00CDE98E File Offset: 0x00CDCB8E
		// (set) Token: 0x0602E040 RID: 188480 RVA: 0x00CDE996 File Offset: 0x00CDCB96
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreFriendData> ExploreFriendDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x0602E041 RID: 188481 RVA: 0x00CDE99F File Offset: 0x00CDCB9F
		// (set) Token: 0x0602E042 RID: 188482 RVA: 0x00CDE9A7 File Offset: 0x00CDCBA7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreConfirmButton> ButtonInfoList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x0602E043 RID: 188483 RVA: 0x00CDE9B0 File Offset: 0x00CDCBB0
		// (set) Token: 0x0602E044 RID: 188484 RVA: 0x00CDE9B8 File Offset: 0x00CDCBB8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRewardExploreTargetReached> TargetReached { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0602E045 RID: 188485 RVA: 0x00CDE9C1 File Offset: 0x00CDCBC1
		// (set) Token: 0x0602E046 RID: 188486 RVA: 0x00CDE9C9 File Offset: 0x00CDCBC9
		public IRewardExploreScoreBelongHalfArea ScoreHalfArea { get; set; }

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x0602E047 RID: 188487 RVA: 0x00CDE9D2 File Offset: 0x00CDCBD2
		// (set) Token: 0x0602E048 RID: 188488 RVA: 0x00CDE9DA File Offset: 0x00CDCBDA
		public ReachTargetData ScoreReached { get; set; }

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x0602E049 RID: 188489 RVA: 0x00CDE9E3 File Offset: 0x00CDCBE3
		// (set) Token: 0x0602E04A RID: 188490 RVA: 0x00CDE9EB File Offset: 0x00CDCBEB
		public IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x0602E04B RID: 188491 RVA: 0x00CDE9F4 File Offset: 0x00CDCBF4
		// (set) Token: 0x0602E04C RID: 188492 RVA: 0x00CDE9FC File Offset: 0x00CDCBFC
		public AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0602E04D RID: 188493 RVA: 0x00CDEA05 File Offset: 0x00CDCC05
		// (set) Token: 0x0602E04E RID: 188494 RVA: 0x00CDEA0D File Offset: 0x00CDCC0D
		public IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x0602E04F RID: 188495 RVA: 0x00CDEA16 File Offset: 0x00CDCC16
		// (set) Token: 0x0602E050 RID: 188496 RVA: 0x00CDEA1E File Offset: 0x00CDCC1E
		public IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x0602E051 RID: 188497 RVA: 0x00CDEA27 File Offset: 0x00CDCC27
		// (set) Token: 0x0602E052 RID: 188498 RVA: 0x00CDEA2F File Offset: 0x00CDCC2F
		public IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x0602E053 RID: 188499 RVA: 0x00CDEA38 File Offset: 0x00CDCC38
		// (set) Token: 0x0602E054 RID: 188500 RVA: 0x00CDEA40 File Offset: 0x00CDCC40
		public IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
