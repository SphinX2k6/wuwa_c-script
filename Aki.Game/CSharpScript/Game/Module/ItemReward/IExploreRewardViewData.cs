using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004786 RID: 18310
	[NullableContext(2)]
	public interface IExploreRewardViewData
	{
		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x0602DFC0 RID: 188352
		// (set) Token: 0x0602DFC1 RID: 188353
		int ConfigId { get; set; }

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x0602DFC2 RID: 188354
		// (set) Token: 0x0602DFC3 RID: 188355
		bool IsSuccess { get; set; }

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x0602DFC4 RID: 188356
		// (set) Token: 0x0602DFC5 RID: 188357
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

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x0602DFC6 RID: 188358
		// (set) Token: 0x0602DFC7 RID: 188359
		IRewardExploreRecord ExploreRecordInfo { get; set; }

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x0602DFC8 RID: 188360
		// (set) Token: 0x0602DFC9 RID: 188361
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

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x0602DFCA RID: 188362
		// (set) Token: 0x0602DFCB RID: 188363
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

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0602DFCC RID: 188364
		// (set) Token: 0x0602DFCD RID: 188365
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

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0602DFCE RID: 188366
		// (set) Token: 0x0602DFCF RID: 188367
		IRewardExploreToggle StateToggle { get; set; }

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0602DFD0 RID: 188368
		// (set) Token: 0x0602DFD1 RID: 188369
		Action OnCloseCallback { get; set; }

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x0602DFD2 RID: 188370
		// (set) Token: 0x0602DFD3 RID: 188371
		string Tip { get; set; }

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x0602DFD4 RID: 188372
		// (set) Token: 0x0602DFD5 RID: 188373
		Action<bool> FinishCallback { get; set; }

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x0602DFD6 RID: 188374
		// (set) Token: 0x0602DFD7 RID: 188375
		bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x0602DFD8 RID: 188376
		// (set) Token: 0x0602DFD9 RID: 188377
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

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x0602DFDA RID: 188378
		// (set) Token: 0x0602DFDB RID: 188379
		ReachTargetData ScoreReachedData { get; set; }

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0602DFDC RID: 188380
		// (set) Token: 0x0602DFDD RID: 188381
		bool? IsRewardMultiLine { get; set; }

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0602DFDE RID: 188382
		// (set) Token: 0x0602DFDF RID: 188383
		AccumulatedScoreData AccumulatedScoreData { get; set; }

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0602DFE0 RID: 188384
		// (set) Token: 0x0602DFE1 RID: 188385
		string TitleTextId { get; set; }

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x0602DFE2 RID: 188386
		// (set) Token: 0x0602DFE3 RID: 188387
		IBabelTowerSuccessData BabelTowerSuccessData { get; set; }

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x0602DFE4 RID: 188388
		// (set) Token: 0x0602DFE5 RID: 188389
		bool? IsBagFull { get; set; }

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x0602DFE6 RID: 188390
		// (set) Token: 0x0602DFE7 RID: 188391
		IDangoAbyssSuccessData DangoAbyssSuccessData { get; set; }

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x0602DFE8 RID: 188392
		// (set) Token: 0x0602DFE9 RID: 188393
		IHonamiTowerSuccessData HonamiTowerSuccessData { get; set; }

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x0602DFEA RID: 188394
		// (set) Token: 0x0602DFEB RID: 188395
		IRoguelikeBossChallengeData RoguelikeBossChallengeData { get; set; }
	}
}
