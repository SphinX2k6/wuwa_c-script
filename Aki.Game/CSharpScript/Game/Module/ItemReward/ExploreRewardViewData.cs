using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004787 RID: 18311
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardViewData : IExploreRewardViewData
	{
		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x0602DFEC RID: 188396 RVA: 0x00CDE7CC File Offset: 0x00CDC9CC
		// (set) Token: 0x0602DFED RID: 188397 RVA: 0x00CDE7D4 File Offset: 0x00CDC9D4
		public int ConfigId { get; set; }

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x0602DFEE RID: 188398 RVA: 0x00CDE7DD File Offset: 0x00CDC9DD
		// (set) Token: 0x0602DFEF RID: 188399 RVA: 0x00CDE7E5 File Offset: 0x00CDC9E5
		public bool IsSuccess { get; set; }

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x0602DFF0 RID: 188400 RVA: 0x00CDE7EE File Offset: 0x00CDC9EE
		// (set) Token: 0x0602DFF1 RID: 188401 RVA: 0x00CDE7F6 File Offset: 0x00CDC9F6
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

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x0602DFF2 RID: 188402 RVA: 0x00CDE7FF File Offset: 0x00CDC9FF
		// (set) Token: 0x0602DFF3 RID: 188403 RVA: 0x00CDE807 File Offset: 0x00CDCA07
		public IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x0602DFF4 RID: 188404 RVA: 0x00CDE810 File Offset: 0x00CDCA10
		// (set) Token: 0x0602DFF5 RID: 188405 RVA: 0x00CDE818 File Offset: 0x00CDCA18
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

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x0602DFF6 RID: 188406 RVA: 0x00CDE821 File Offset: 0x00CDCA21
		// (set) Token: 0x0602DFF7 RID: 188407 RVA: 0x00CDE829 File Offset: 0x00CDCA29
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

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x0602DFF8 RID: 188408 RVA: 0x00CDE832 File Offset: 0x00CDCA32
		// (set) Token: 0x0602DFF9 RID: 188409 RVA: 0x00CDE83A File Offset: 0x00CDCA3A
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

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0602DFFA RID: 188410 RVA: 0x00CDE843 File Offset: 0x00CDCA43
		// (set) Token: 0x0602DFFB RID: 188411 RVA: 0x00CDE84B File Offset: 0x00CDCA4B
		public IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0602DFFC RID: 188412 RVA: 0x00CDE854 File Offset: 0x00CDCA54
		// (set) Token: 0x0602DFFD RID: 188413 RVA: 0x00CDE85C File Offset: 0x00CDCA5C
		public Action OnCloseCallback { get; set; }

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0602DFFE RID: 188414 RVA: 0x00CDE865 File Offset: 0x00CDCA65
		// (set) Token: 0x0602DFFF RID: 188415 RVA: 0x00CDE86D File Offset: 0x00CDCA6D
		public string Tip { get; set; }

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x0602E000 RID: 188416 RVA: 0x00CDE876 File Offset: 0x00CDCA76
		// (set) Token: 0x0602E001 RID: 188417 RVA: 0x00CDE87E File Offset: 0x00CDCA7E
		public Action<bool> FinishCallback { get; set; }

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x0602E002 RID: 188418 RVA: 0x00CDE887 File Offset: 0x00CDCA87
		// (set) Token: 0x0602E003 RID: 188419 RVA: 0x00CDE88F File Offset: 0x00CDCA8F
		public bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0602E004 RID: 188420 RVA: 0x00CDE898 File Offset: 0x00CDCA98
		// (set) Token: 0x0602E005 RID: 188421 RVA: 0x00CDE8A0 File Offset: 0x00CDCAA0
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

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0602E006 RID: 188422 RVA: 0x00CDE8A9 File Offset: 0x00CDCAA9
		// (set) Token: 0x0602E007 RID: 188423 RVA: 0x00CDE8B1 File Offset: 0x00CDCAB1
		public ReachTargetData ScoreReachedData { get; set; }

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x0602E008 RID: 188424 RVA: 0x00CDE8BA File Offset: 0x00CDCABA
		// (set) Token: 0x0602E009 RID: 188425 RVA: 0x00CDE8C2 File Offset: 0x00CDCAC2
		public bool? IsRewardMultiLine { get; set; }

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x0602E00A RID: 188426 RVA: 0x00CDE8CB File Offset: 0x00CDCACB
		// (set) Token: 0x0602E00B RID: 188427 RVA: 0x00CDE8D3 File Offset: 0x00CDCAD3
		public AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0602E00C RID: 188428 RVA: 0x00CDE8DC File Offset: 0x00CDCADC
		// (set) Token: 0x0602E00D RID: 188429 RVA: 0x00CDE8E4 File Offset: 0x00CDCAE4
		public string TitleTextId { get; set; }

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x0602E00E RID: 188430 RVA: 0x00CDE8ED File Offset: 0x00CDCAED
		// (set) Token: 0x0602E00F RID: 188431 RVA: 0x00CDE8F5 File Offset: 0x00CDCAF5
		public IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x0602E010 RID: 188432 RVA: 0x00CDE8FE File Offset: 0x00CDCAFE
		// (set) Token: 0x0602E011 RID: 188433 RVA: 0x00CDE906 File Offset: 0x00CDCB06
		public bool? IsBagFull { get; set; }

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x0602E012 RID: 188434 RVA: 0x00CDE90F File Offset: 0x00CDCB0F
		// (set) Token: 0x0602E013 RID: 188435 RVA: 0x00CDE917 File Offset: 0x00CDCB17
		public IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x0602E014 RID: 188436 RVA: 0x00CDE920 File Offset: 0x00CDCB20
		// (set) Token: 0x0602E015 RID: 188437 RVA: 0x00CDE928 File Offset: 0x00CDCB28
		public IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x0602E016 RID: 188438 RVA: 0x00CDE931 File Offset: 0x00CDCB31
		// (set) Token: 0x0602E017 RID: 188439 RVA: 0x00CDE939 File Offset: 0x00CDCB39
		public IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
