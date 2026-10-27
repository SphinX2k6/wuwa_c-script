using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057AF RID: 22447
	[NullableContext(2)]
	public interface IExploreRewardViewData
	{
		// Token: 0x170088DA RID: 35034
		// (get) Token: 0x060390B0 RID: 233648
		// (set) Token: 0x060390B1 RID: 233649
		int ConfigId { get; set; }

		// Token: 0x170088DB RID: 35035
		// (get) Token: 0x060390B2 RID: 233650
		// (set) Token: 0x060390B3 RID: 233651
		bool IsSuccess { get; set; }

		// Token: 0x170088DC RID: 35036
		// (get) Token: 0x060390B4 RID: 233652
		// (set) Token: 0x060390B5 RID: 233653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<RewardItemData> RewardItemDataList { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170088DD RID: 35037
		// (get) Token: 0x060390B6 RID: 233654
		// (set) Token: 0x060390B7 RID: 233655
		IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x170088DE RID: 35038
		// (get) Token: 0x060390B8 RID: 233656
		// (set) Token: 0x060390B9 RID: 233657
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

		// Token: 0x170088DF RID: 35039
		// (get) Token: 0x060390BA RID: 233658
		// (set) Token: 0x060390BB RID: 233659
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

		// Token: 0x170088E0 RID: 35040
		// (get) Token: 0x060390BC RID: 233660
		// (set) Token: 0x060390BD RID: 233661
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

		// Token: 0x170088E1 RID: 35041
		// (get) Token: 0x060390BE RID: 233662
		// (set) Token: 0x060390BF RID: 233663
		IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x170088E2 RID: 35042
		// (get) Token: 0x060390C0 RID: 233664
		// (set) Token: 0x060390C1 RID: 233665
		Action OnCloseCallback { get; set; }

		// Token: 0x170088E3 RID: 35043
		// (get) Token: 0x060390C2 RID: 233666
		// (set) Token: 0x060390C3 RID: 233667
		string Tip { get; set; }

		// Token: 0x170088E4 RID: 35044
		// (get) Token: 0x060390C4 RID: 233668
		// (set) Token: 0x060390C5 RID: 233669
		Action<bool> FinishCallback { get; set; }

		// Token: 0x170088E5 RID: 35045
		// (get) Token: 0x060390C6 RID: 233670
		// (set) Token: 0x060390C7 RID: 233671
		bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x170088E6 RID: 35046
		// (get) Token: 0x060390C8 RID: 233672
		// (set) Token: 0x060390C9 RID: 233673
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

		// Token: 0x170088E7 RID: 35047
		// (get) Token: 0x060390CA RID: 233674
		// (set) Token: 0x060390CB RID: 233675
		ReachTargetData ScoreReachedData { get; set; }

		// Token: 0x170088E8 RID: 35048
		// (get) Token: 0x060390CC RID: 233676
		// (set) Token: 0x060390CD RID: 233677
		bool? IsRewardMultiLine { get; set; }

		// Token: 0x170088E9 RID: 35049
		// (get) Token: 0x060390CE RID: 233678
		// (set) Token: 0x060390CF RID: 233679
		AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x170088EA RID: 35050
		// (get) Token: 0x060390D0 RID: 233680
		// (set) Token: 0x060390D1 RID: 233681
		string TitleTextId { get; set; }

		// Token: 0x170088EB RID: 35051
		// (get) Token: 0x060390D2 RID: 233682
		// (set) Token: 0x060390D3 RID: 233683
		IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x170088EC RID: 35052
		// (get) Token: 0x060390D4 RID: 233684
		// (set) Token: 0x060390D5 RID: 233685
		bool? IsBagFull { get; set; }

		// Token: 0x170088ED RID: 35053
		// (get) Token: 0x060390D6 RID: 233686
		// (set) Token: 0x060390D7 RID: 233687
		IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x170088EE RID: 35054
		// (get) Token: 0x060390D8 RID: 233688
		// (set) Token: 0x060390D9 RID: 233689
		IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x170088EF RID: 35055
		// (get) Token: 0x060390DA RID: 233690
		// (set) Token: 0x060390DB RID: 233691
		IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
