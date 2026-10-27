using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B0 RID: 22448
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardViewData : IExploreRewardViewData
	{
		// Token: 0x170088F0 RID: 35056
		// (get) Token: 0x060390DC RID: 233692 RVA: 0x00D8F994 File Offset: 0x00D8DB94
		// (set) Token: 0x060390DD RID: 233693 RVA: 0x00D8F99C File Offset: 0x00D8DB9C
		public int ConfigId { get; set; }

		// Token: 0x170088F1 RID: 35057
		// (get) Token: 0x060390DE RID: 233694 RVA: 0x00D8F9A5 File Offset: 0x00D8DBA5
		// (set) Token: 0x060390DF RID: 233695 RVA: 0x00D8F9AD File Offset: 0x00D8DBAD
		public bool IsSuccess { get; set; }

		// Token: 0x170088F2 RID: 35058
		// (get) Token: 0x060390E0 RID: 233696 RVA: 0x00D8F9B6 File Offset: 0x00D8DBB6
		// (set) Token: 0x060390E1 RID: 233697 RVA: 0x00D8F9BE File Offset: 0x00D8DBBE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> RewardItemDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170088F3 RID: 35059
		// (get) Token: 0x060390E2 RID: 233698 RVA: 0x00D8F9C7 File Offset: 0x00D8DBC7
		// (set) Token: 0x060390E3 RID: 233699 RVA: 0x00D8F9CF File Offset: 0x00D8DBCF
		public IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x170088F4 RID: 35060
		// (get) Token: 0x060390E4 RID: 233700 RVA: 0x00D8F9D8 File Offset: 0x00D8DBD8
		// (set) Token: 0x060390E5 RID: 233701 RVA: 0x00D8F9E0 File Offset: 0x00D8DBE0
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

		// Token: 0x170088F5 RID: 35061
		// (get) Token: 0x060390E6 RID: 233702 RVA: 0x00D8F9E9 File Offset: 0x00D8DBE9
		// (set) Token: 0x060390E7 RID: 233703 RVA: 0x00D8F9F1 File Offset: 0x00D8DBF1
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

		// Token: 0x170088F6 RID: 35062
		// (get) Token: 0x060390E8 RID: 233704 RVA: 0x00D8F9FA File Offset: 0x00D8DBFA
		// (set) Token: 0x060390E9 RID: 233705 RVA: 0x00D8FA02 File Offset: 0x00D8DC02
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

		// Token: 0x170088F7 RID: 35063
		// (get) Token: 0x060390EA RID: 233706 RVA: 0x00D8FA0B File Offset: 0x00D8DC0B
		// (set) Token: 0x060390EB RID: 233707 RVA: 0x00D8FA13 File Offset: 0x00D8DC13
		public IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x170088F8 RID: 35064
		// (get) Token: 0x060390EC RID: 233708 RVA: 0x00D8FA1C File Offset: 0x00D8DC1C
		// (set) Token: 0x060390ED RID: 233709 RVA: 0x00D8FA24 File Offset: 0x00D8DC24
		public Action OnCloseCallback { get; set; }

		// Token: 0x170088F9 RID: 35065
		// (get) Token: 0x060390EE RID: 233710 RVA: 0x00D8FA2D File Offset: 0x00D8DC2D
		// (set) Token: 0x060390EF RID: 233711 RVA: 0x00D8FA35 File Offset: 0x00D8DC35
		public string Tip { get; set; }

		// Token: 0x170088FA RID: 35066
		// (get) Token: 0x060390F0 RID: 233712 RVA: 0x00D8FA3E File Offset: 0x00D8DC3E
		// (set) Token: 0x060390F1 RID: 233713 RVA: 0x00D8FA46 File Offset: 0x00D8DC46
		public Action<bool> FinishCallback { get; set; }

		// Token: 0x170088FB RID: 35067
		// (get) Token: 0x060390F2 RID: 233714 RVA: 0x00D8FA4F File Offset: 0x00D8DC4F
		// (set) Token: 0x060390F3 RID: 233715 RVA: 0x00D8FA57 File Offset: 0x00D8DC57
		public bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x170088FC RID: 35068
		// (get) Token: 0x060390F4 RID: 233716 RVA: 0x00D8FA60 File Offset: 0x00D8DC60
		// (set) Token: 0x060390F5 RID: 233717 RVA: 0x00D8FA68 File Offset: 0x00D8DC68
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

		// Token: 0x170088FD RID: 35069
		// (get) Token: 0x060390F6 RID: 233718 RVA: 0x00D8FA71 File Offset: 0x00D8DC71
		// (set) Token: 0x060390F7 RID: 233719 RVA: 0x00D8FA79 File Offset: 0x00D8DC79
		public ReachTargetData ScoreReachedData { get; set; }

		// Token: 0x170088FE RID: 35070
		// (get) Token: 0x060390F8 RID: 233720 RVA: 0x00D8FA82 File Offset: 0x00D8DC82
		// (set) Token: 0x060390F9 RID: 233721 RVA: 0x00D8FA8A File Offset: 0x00D8DC8A
		public bool? IsRewardMultiLine { get; set; }

		// Token: 0x170088FF RID: 35071
		// (get) Token: 0x060390FA RID: 233722 RVA: 0x00D8FA93 File Offset: 0x00D8DC93
		// (set) Token: 0x060390FB RID: 233723 RVA: 0x00D8FA9B File Offset: 0x00D8DC9B
		public AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17008900 RID: 35072
		// (get) Token: 0x060390FC RID: 233724 RVA: 0x00D8FAA4 File Offset: 0x00D8DCA4
		// (set) Token: 0x060390FD RID: 233725 RVA: 0x00D8FAAC File Offset: 0x00D8DCAC
		public string TitleTextId { get; set; }

		// Token: 0x17008901 RID: 35073
		// (get) Token: 0x060390FE RID: 233726 RVA: 0x00D8FAB5 File Offset: 0x00D8DCB5
		// (set) Token: 0x060390FF RID: 233727 RVA: 0x00D8FABD File Offset: 0x00D8DCBD
		public IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17008902 RID: 35074
		// (get) Token: 0x06039100 RID: 233728 RVA: 0x00D8FAC6 File Offset: 0x00D8DCC6
		// (set) Token: 0x06039101 RID: 233729 RVA: 0x00D8FACE File Offset: 0x00D8DCCE
		public bool? IsBagFull { get; set; }

		// Token: 0x17008903 RID: 35075
		// (get) Token: 0x06039102 RID: 233730 RVA: 0x00D8FAD7 File Offset: 0x00D8DCD7
		// (set) Token: 0x06039103 RID: 233731 RVA: 0x00D8FADF File Offset: 0x00D8DCDF
		public IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17008904 RID: 35076
		// (get) Token: 0x06039104 RID: 233732 RVA: 0x00D8FAE8 File Offset: 0x00D8DCE8
		// (set) Token: 0x06039105 RID: 233733 RVA: 0x00D8FAF0 File Offset: 0x00D8DCF0
		public IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17008905 RID: 35077
		// (get) Token: 0x06039106 RID: 233734 RVA: 0x00D8FAF9 File Offset: 0x00D8DCF9
		// (set) Token: 0x06039107 RID: 233735 RVA: 0x00D8FB01 File Offset: 0x00D8DD01
		public IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
