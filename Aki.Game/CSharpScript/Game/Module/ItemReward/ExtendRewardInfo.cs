using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B2 RID: 22450
	[NullableContext(2)]
	[Nullable(0)]
	public class ExtendRewardInfo : IExtendRewardInfo
	{
		// Token: 0x17008915 RID: 35093
		// (get) Token: 0x06039127 RID: 233767 RVA: 0x00D8FB12 File Offset: 0x00D8DD12
		// (set) Token: 0x06039128 RID: 233768 RVA: 0x00D8FB1A File Offset: 0x00D8DD1A
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

		// Token: 0x17008916 RID: 35094
		// (get) Token: 0x06039129 RID: 233769 RVA: 0x00D8FB23 File Offset: 0x00D8DD23
		// (set) Token: 0x0603912A RID: 233770 RVA: 0x00D8FB2B File Offset: 0x00D8DD2B
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

		// Token: 0x17008917 RID: 35095
		// (get) Token: 0x0603912B RID: 233771 RVA: 0x00D8FB34 File Offset: 0x00D8DD34
		// (set) Token: 0x0603912C RID: 233772 RVA: 0x00D8FB3C File Offset: 0x00D8DD3C
		public IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17008918 RID: 35096
		// (get) Token: 0x0603912D RID: 233773 RVA: 0x00D8FB45 File Offset: 0x00D8DD45
		// (set) Token: 0x0603912E RID: 233774 RVA: 0x00D8FB4D File Offset: 0x00D8DD4D
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

		// Token: 0x17008919 RID: 35097
		// (get) Token: 0x0603912F RID: 233775 RVA: 0x00D8FB56 File Offset: 0x00D8DD56
		// (set) Token: 0x06039130 RID: 233776 RVA: 0x00D8FB5E File Offset: 0x00D8DD5E
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

		// Token: 0x1700891A RID: 35098
		// (get) Token: 0x06039131 RID: 233777 RVA: 0x00D8FB67 File Offset: 0x00D8DD67
		// (set) Token: 0x06039132 RID: 233778 RVA: 0x00D8FB6F File Offset: 0x00D8DD6F
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

		// Token: 0x1700891B RID: 35099
		// (get) Token: 0x06039133 RID: 233779 RVA: 0x00D8FB78 File Offset: 0x00D8DD78
		// (set) Token: 0x06039134 RID: 233780 RVA: 0x00D8FB80 File Offset: 0x00D8DD80
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

		// Token: 0x1700891C RID: 35100
		// (get) Token: 0x06039135 RID: 233781 RVA: 0x00D8FB89 File Offset: 0x00D8DD89
		// (set) Token: 0x06039136 RID: 233782 RVA: 0x00D8FB91 File Offset: 0x00D8DD91
		public IRewardExploreScoreBelongHalfArea ScoreHalfArea { get; set; }

		// Token: 0x1700891D RID: 35101
		// (get) Token: 0x06039137 RID: 233783 RVA: 0x00D8FB9A File Offset: 0x00D8DD9A
		// (set) Token: 0x06039138 RID: 233784 RVA: 0x00D8FBA2 File Offset: 0x00D8DDA2
		public ReachTargetData ScoreReached { get; set; }

		// Token: 0x1700891E RID: 35102
		// (get) Token: 0x06039139 RID: 233785 RVA: 0x00D8FBAB File Offset: 0x00D8DDAB
		// (set) Token: 0x0603913A RID: 233786 RVA: 0x00D8FBB3 File Offset: 0x00D8DDB3
		public IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x1700891F RID: 35103
		// (get) Token: 0x0603913B RID: 233787 RVA: 0x00D8FBBC File Offset: 0x00D8DDBC
		// (set) Token: 0x0603913C RID: 233788 RVA: 0x00D8FBC4 File Offset: 0x00D8DDC4
		public AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17008920 RID: 35104
		// (get) Token: 0x0603913D RID: 233789 RVA: 0x00D8FBCD File Offset: 0x00D8DDCD
		// (set) Token: 0x0603913E RID: 233790 RVA: 0x00D8FBD5 File Offset: 0x00D8DDD5
		public IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17008921 RID: 35105
		// (get) Token: 0x0603913F RID: 233791 RVA: 0x00D8FBDE File Offset: 0x00D8DDDE
		// (set) Token: 0x06039140 RID: 233792 RVA: 0x00D8FBE6 File Offset: 0x00D8DDE6
		public IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17008922 RID: 35106
		// (get) Token: 0x06039141 RID: 233793 RVA: 0x00D8FBEF File Offset: 0x00D8DDEF
		// (set) Token: 0x06039142 RID: 233794 RVA: 0x00D8FBF7 File Offset: 0x00D8DDF7
		public IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17008923 RID: 35107
		// (get) Token: 0x06039143 RID: 233795 RVA: 0x00D8FC00 File Offset: 0x00D8DE00
		// (set) Token: 0x06039144 RID: 233796 RVA: 0x00D8FC08 File Offset: 0x00D8DE08
		public IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
