using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048DB RID: 18651
	public class InfrastructureDefine
	{
		// Token: 0x04018D7F RID: 101759
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, string> difficultySpriteResourceId = new Dictionary<int, string>
		{
			{
				1,
				"SP_InfrastructureMapStar1"
			},
			{
				2,
				"SP_InfrastructureMapStar2"
			},
			{
				3,
				"SP_InfrastructureMapStar3"
			}
		};

		// Token: 0x04018D80 RID: 101760
		public const int MAX_INFR_MARK_INFO_LINE_NUM = 3;

		// Token: 0x04018D81 RID: 101761
		public const int INFR_BATTLE_MATERIAL_ID = 80700001;

		// Token: 0x04018D82 RID: 101762
		public const int INFR_COLLECTION_MATERIAL_ID = 80700002;

		// Token: 0x04018D83 RID: 101763
		public const int INFR_QUEST_MATERIAL_ID = 80700003;

		// Token: 0x04018D84 RID: 101764
		public const int INFR_SHOP_CURRENCY_ID = 80700004;

		// Token: 0x04018D85 RID: 101765
		public const int INFR_OBSERVATORY_MARK_ID = 342011;

		// Token: 0x04018D86 RID: 101766
		[Nullable(1)]
		public const string INFR_ACTIVITY_MALE_TEXTURE = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainMale.T_AcivityMainMale";

		// Token: 0x04018D87 RID: 101767
		[Nullable(1)]
		public const string INFR_ACTIVITY_FEMALE_TEXTURE = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainFemale.T_AcivityMainFemale";

		// Token: 0x04018D88 RID: 101768
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<InfrTaskStatusPb, EActivityRewardState> infrTaskStateToRewardStateResolver = new Dictionary<InfrTaskStatusPb, EActivityRewardState>
		{
			{
				InfrTaskStatusPb.InfrTaskRunning,
				EActivityRewardState.Disabled
			},
			{
				InfrTaskStatusPb.InfrTaskFinish,
				EActivityRewardState.Enable
			},
			{
				InfrTaskStatusPb.InfrTaskTaken,
				EActivityRewardState.Claimed
			}
		};

		// Token: 0x04018D89 RID: 101769
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<InfrTaskStatusPb, string> infrTaskStateToRewardText = new Dictionary<InfrTaskStatusPb, string>
		{
			{
				InfrTaskStatusPb.InfrTaskRunning,
				"CollectActivity_state_open"
			},
			{
				InfrTaskStatusPb.InfrTaskFinish,
				"CollectActivity_state_CanRecive"
			},
			{
				InfrTaskStatusPb.InfrTaskTaken,
				"CollectActivity_state_recived"
			}
		};

		// Token: 0x04018D8A RID: 101770
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, string> infrShopTabMenuName = new Dictionary<int, string>
		{
			{
				2,
				"BuildShop_Title_1"
			},
			{
				3,
				"BuildShop_Title_2"
			},
			{
				4,
				"BuildShop_Title_3"
			}
		};

		// Token: 0x0200A55C RID: 42332
		public enum EMainMissionIndex
		{
			// Token: 0x040332C9 RID: 209609
			Quest,
			// Token: 0x040332CA RID: 209610
			BuildTarget
		}

		// Token: 0x0200A55D RID: 42333
		public interface IInfrRoadData
		{
			// Token: 0x170079BE RID: 31166
			// (get) Token: 0x06045FDB RID: 286683
			// (set) Token: 0x06045FDC RID: 286684
			int RoadId { get; set; }

			// Token: 0x170079BF RID: 31167
			// (get) Token: 0x06045FDD RID: 286685
			// (set) Token: 0x06045FDE RID: 286686
			InfrStatusPb Status { get; set; }

			// Token: 0x170079C0 RID: 31168
			// (get) Token: 0x06045FDF RID: 286687
			// (set) Token: 0x06045FE0 RID: 286688
			int CompleteTime { get; set; }

			// Token: 0x170079C1 RID: 31169
			// (get) Token: 0x06045FE1 RID: 286689
			// (set) Token: 0x06045FE2 RID: 286690
			int TotalGiftCount { get; set; }

			// Token: 0x170079C2 RID: 31170
			// (get) Token: 0x06045FE3 RID: 286691
			// (set) Token: 0x06045FE4 RID: 286692
			int LastGiftTime { get; set; }
		}

		// Token: 0x0200A55E RID: 42334
		public class InfrRoadData : InfrastructureDefine.IInfrRoadData
		{
			// Token: 0x170079C3 RID: 31171
			// (get) Token: 0x06045FE5 RID: 286693 RVA: 0x0150AF26 File Offset: 0x01509126
			// (set) Token: 0x06045FE6 RID: 286694 RVA: 0x0150AF2E File Offset: 0x0150912E
			public int RoadId { get; set; }

			// Token: 0x170079C4 RID: 31172
			// (get) Token: 0x06045FE7 RID: 286695 RVA: 0x0150AF37 File Offset: 0x01509137
			// (set) Token: 0x06045FE8 RID: 286696 RVA: 0x0150AF3F File Offset: 0x0150913F
			public InfrStatusPb Status { get; set; }

			// Token: 0x170079C5 RID: 31173
			// (get) Token: 0x06045FE9 RID: 286697 RVA: 0x0150AF48 File Offset: 0x01509148
			// (set) Token: 0x06045FEA RID: 286698 RVA: 0x0150AF50 File Offset: 0x01509150
			public int CompleteTime { get; set; }

			// Token: 0x170079C6 RID: 31174
			// (get) Token: 0x06045FEB RID: 286699 RVA: 0x0150AF59 File Offset: 0x01509159
			// (set) Token: 0x06045FEC RID: 286700 RVA: 0x0150AF61 File Offset: 0x01509161
			public int TotalGiftCount { get; set; }

			// Token: 0x170079C7 RID: 31175
			// (get) Token: 0x06045FED RID: 286701 RVA: 0x0150AF6A File Offset: 0x0150916A
			// (set) Token: 0x06045FEE RID: 286702 RVA: 0x0150AF72 File Offset: 0x01509172
			public int LastGiftTime { get; set; }
		}

		// Token: 0x0200A55F RID: 42335
		public interface IInfrLibraryTaskData
		{
			// Token: 0x170079C8 RID: 31176
			// (get) Token: 0x06045FF0 RID: 286704
			// (set) Token: 0x06045FF1 RID: 286705
			int TaskId { get; set; }

			// Token: 0x170079C9 RID: 31177
			// (get) Token: 0x06045FF2 RID: 286706
			// (set) Token: 0x06045FF3 RID: 286707
			int Target { get; set; }

			// Token: 0x170079CA RID: 31178
			// (get) Token: 0x06045FF4 RID: 286708
			// (set) Token: 0x06045FF5 RID: 286709
			InfrTaskStatusPb Status { get; set; }
		}

		// Token: 0x0200A560 RID: 42336
		public class InfrLibraryTaskData : InfrastructureDefine.IInfrLibraryTaskData
		{
			// Token: 0x170079CB RID: 31179
			// (get) Token: 0x06045FF6 RID: 286710 RVA: 0x0150AF83 File Offset: 0x01509183
			// (set) Token: 0x06045FF7 RID: 286711 RVA: 0x0150AF8B File Offset: 0x0150918B
			public int TaskId { get; set; }

			// Token: 0x170079CC RID: 31180
			// (get) Token: 0x06045FF8 RID: 286712 RVA: 0x0150AF94 File Offset: 0x01509194
			// (set) Token: 0x06045FF9 RID: 286713 RVA: 0x0150AF9C File Offset: 0x0150919C
			public int Target { get; set; }

			// Token: 0x170079CD RID: 31181
			// (get) Token: 0x06045FFA RID: 286714 RVA: 0x0150AFA5 File Offset: 0x015091A5
			// (set) Token: 0x06045FFB RID: 286715 RVA: 0x0150AFAD File Offset: 0x015091AD
			public InfrTaskStatusPb Status { get; set; }
		}

		// Token: 0x0200A561 RID: 42337
		public interface IInfrMaterialsDeliveryOpenParam
		{
			// Token: 0x170079CE RID: 31182
			// (get) Token: 0x06045FFD RID: 286717
			// (set) Token: 0x06045FFE RID: 286718
			InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource { get; set; }

			// Token: 0x170079CF RID: 31183
			// (get) Token: 0x06045FFF RID: 286719
			// (set) Token: 0x06046000 RID: 286720
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079D0 RID: 31184
			// (get) Token: 0x06046001 RID: 286721
			// (set) Token: 0x06046002 RID: 286722
			int RoadId { get; set; }

			// Token: 0x170079D1 RID: 31185
			// (get) Token: 0x06046003 RID: 286723
			// (set) Token: 0x06046004 RID: 286724
			int? ActionId { get; set; }
		}

		// Token: 0x0200A562 RID: 42338
		public class InfrMaterialsDeliveryOpenParam : InfrastructureDefine.IInfrMaterialsDeliveryOpenParam
		{
			// Token: 0x170079D2 RID: 31186
			// (get) Token: 0x06046005 RID: 286725 RVA: 0x0150AFBE File Offset: 0x015091BE
			// (set) Token: 0x06046006 RID: 286726 RVA: 0x0150AFC6 File Offset: 0x015091C6
			public InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource { get; set; }

			// Token: 0x170079D3 RID: 31187
			// (get) Token: 0x06046007 RID: 286727 RVA: 0x0150AFCF File Offset: 0x015091CF
			// (set) Token: 0x06046008 RID: 286728 RVA: 0x0150AFD7 File Offset: 0x015091D7
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079D4 RID: 31188
			// (get) Token: 0x06046009 RID: 286729 RVA: 0x0150AFE0 File Offset: 0x015091E0
			// (set) Token: 0x0604600A RID: 286730 RVA: 0x0150AFE8 File Offset: 0x015091E8
			public int RoadId { get; set; }

			// Token: 0x170079D5 RID: 31189
			// (get) Token: 0x0604600B RID: 286731 RVA: 0x0150AFF1 File Offset: 0x015091F1
			// (set) Token: 0x0604600C RID: 286732 RVA: 0x0150AFF9 File Offset: 0x015091F9
			public int? ActionId { get; set; }
		}

		// Token: 0x0200A563 RID: 42339
		[NullableContext(1)]
		public interface IInfrRoadNetworkInfoOpenParam
		{
			// Token: 0x170079D6 RID: 31190
			// (get) Token: 0x0604600E RID: 286734
			// (set) Token: 0x0604600F RID: 286735
			InfrastructureDefine.IInfrMaterialsDeliveryOpenParam InfoParam { get; set; }

			// Token: 0x170079D7 RID: 31191
			// (get) Token: 0x06046010 RID: 286736
			// (set) Token: 0x06046011 RID: 286737
			Action BuildCb { get; set; }

			// Token: 0x170079D8 RID: 31192
			// (get) Token: 0x06046012 RID: 286738
			// (set) Token: 0x06046013 RID: 286739
			Action CloseCb { get; set; }
		}

		// Token: 0x0200A564 RID: 42340
		[NullableContext(1)]
		[Nullable(0)]
		public class InfrRoadNetworkInfoOpenParam : InfrastructureDefine.IInfrRoadNetworkInfoOpenParam
		{
			// Token: 0x170079D9 RID: 31193
			// (get) Token: 0x06046014 RID: 286740 RVA: 0x0150B00A File Offset: 0x0150920A
			// (set) Token: 0x06046015 RID: 286741 RVA: 0x0150B012 File Offset: 0x01509212
			public InfrastructureDefine.IInfrMaterialsDeliveryOpenParam InfoParam { get; set; }

			// Token: 0x170079DA RID: 31194
			// (get) Token: 0x06046016 RID: 286742 RVA: 0x0150B01B File Offset: 0x0150921B
			// (set) Token: 0x06046017 RID: 286743 RVA: 0x0150B023 File Offset: 0x01509223
			public Action BuildCb { get; set; }

			// Token: 0x170079DB RID: 31195
			// (get) Token: 0x06046018 RID: 286744 RVA: 0x0150B02C File Offset: 0x0150922C
			// (set) Token: 0x06046019 RID: 286745 RVA: 0x0150B034 File Offset: 0x01509234
			public Action CloseCb { get; set; }
		}

		// Token: 0x0200A565 RID: 42341
		public interface IInfrRoadNetworkOpenParam
		{
			// Token: 0x170079DC RID: 31196
			// (get) Token: 0x0604601B RID: 286747
			// (set) Token: 0x0604601C RID: 286748
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079DD RID: 31197
			// (get) Token: 0x0604601D RID: 286749
			// (set) Token: 0x0604601E RID: 286750
			int RoadId { get; set; }

			// Token: 0x170079DE RID: 31198
			// (get) Token: 0x0604601F RID: 286751
			// (set) Token: 0x06046020 RID: 286752
			bool? NeedPlayFinishSeq { get; set; }
		}

		// Token: 0x0200A566 RID: 42342
		public class InfrRoadNetworkOpenParam : InfrastructureDefine.IInfrRoadNetworkOpenParam
		{
			// Token: 0x170079DF RID: 31199
			// (get) Token: 0x06046021 RID: 286753 RVA: 0x0150B045 File Offset: 0x01509245
			// (set) Token: 0x06046022 RID: 286754 RVA: 0x0150B04D File Offset: 0x0150924D
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079E0 RID: 31200
			// (get) Token: 0x06046023 RID: 286755 RVA: 0x0150B056 File Offset: 0x01509256
			// (set) Token: 0x06046024 RID: 286756 RVA: 0x0150B05E File Offset: 0x0150925E
			public int RoadId { get; set; }

			// Token: 0x170079E1 RID: 31201
			// (get) Token: 0x06046025 RID: 286757 RVA: 0x0150B067 File Offset: 0x01509267
			// (set) Token: 0x06046026 RID: 286758 RVA: 0x0150B06F File Offset: 0x0150926F
			public bool? NeedPlayFinishSeq { get; set; }
		}

		// Token: 0x0200A567 RID: 42343
		public interface IInfrSettleViewOpenParam
		{
			// Token: 0x170079E2 RID: 31202
			// (get) Token: 0x06046028 RID: 286760
			// (set) Token: 0x06046029 RID: 286761
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079E3 RID: 31203
			// (get) Token: 0x0604602A RID: 286762
			// (set) Token: 0x0604602B RID: 286763
			int RoadId { get; set; }
		}

		// Token: 0x0200A568 RID: 42344
		public class InfrSettleViewOpenParam : InfrastructureDefine.IInfrSettleViewOpenParam
		{
			// Token: 0x170079E4 RID: 31204
			// (get) Token: 0x0604602C RID: 286764 RVA: 0x0150B080 File Offset: 0x01509280
			// (set) Token: 0x0604602D RID: 286765 RVA: 0x0150B088 File Offset: 0x01509288
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x170079E5 RID: 31205
			// (get) Token: 0x0604602E RID: 286766 RVA: 0x0150B091 File Offset: 0x01509291
			// (set) Token: 0x0604602F RID: 286767 RVA: 0x0150B099 File Offset: 0x01509299
			public int RoadId { get; set; }
		}

		// Token: 0x0200A569 RID: 42345
		[NullableContext(2)]
		public interface IInfrMainViewOpenParam
		{
			// Token: 0x170079E6 RID: 31206
			// (get) Token: 0x06046031 RID: 286769
			// (set) Token: 0x06046032 RID: 286770
			bool NeedFocusBuildQuest { get; set; }

			// Token: 0x170079E7 RID: 31207
			// (get) Token: 0x06046033 RID: 286771
			// (set) Token: 0x06046034 RID: 286772
			bool? NeedPlayBuildSuccessSeq { get; set; }

			// Token: 0x170079E8 RID: 31208
			// (get) Token: 0x06046035 RID: 286773
			// (set) Token: 0x06046036 RID: 286774
			InfrastructureDefine.IInfrSettleViewOpenParam SettleInfo { get; set; }
		}

		// Token: 0x0200A56A RID: 42346
		[NullableContext(2)]
		[Nullable(0)]
		public class InfrMainViewOpenParam : InfrastructureDefine.IInfrMainViewOpenParam
		{
			// Token: 0x170079E9 RID: 31209
			// (get) Token: 0x06046037 RID: 286775 RVA: 0x0150B0AA File Offset: 0x015092AA
			// (set) Token: 0x06046038 RID: 286776 RVA: 0x0150B0B2 File Offset: 0x015092B2
			public bool NeedFocusBuildQuest { get; set; }

			// Token: 0x170079EA RID: 31210
			// (get) Token: 0x06046039 RID: 286777 RVA: 0x0150B0BB File Offset: 0x015092BB
			// (set) Token: 0x0604603A RID: 286778 RVA: 0x0150B0C3 File Offset: 0x015092C3
			public bool? NeedPlayBuildSuccessSeq { get; set; }

			// Token: 0x170079EB RID: 31211
			// (get) Token: 0x0604603B RID: 286779 RVA: 0x0150B0CC File Offset: 0x015092CC
			// (set) Token: 0x0604603C RID: 286780 RVA: 0x0150B0D4 File Offset: 0x015092D4
			public InfrastructureDefine.IInfrSettleViewOpenParam SettleInfo { get; set; }
		}

		// Token: 0x0200A56B RID: 42347
		public interface IInfrShopOpenParam
		{
			// Token: 0x170079EC RID: 31212
			// (get) Token: 0x0604603E RID: 286782
			// (set) Token: 0x0604603F RID: 286783
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A56C RID: 42348
		public class InfrShopOpenParam : InfrastructureDefine.IInfrShopOpenParam
		{
			// Token: 0x170079ED RID: 31213
			// (get) Token: 0x06046040 RID: 286784 RVA: 0x0150B0E5 File Offset: 0x015092E5
			// (set) Token: 0x06046041 RID: 286785 RVA: 0x0150B0ED File Offset: 0x015092ED
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A56D RID: 42349
		public interface IInfrArchiveOpenParam
		{
			// Token: 0x170079EE RID: 31214
			// (get) Token: 0x06046043 RID: 286787
			// (set) Token: 0x06046044 RID: 286788
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A56E RID: 42350
		public class InfrArchiveOpenParam : InfrastructureDefine.IInfrArchiveOpenParam
		{
			// Token: 0x170079EF RID: 31215
			// (get) Token: 0x06046045 RID: 286789 RVA: 0x0150B0FE File Offset: 0x015092FE
			// (set) Token: 0x06046046 RID: 286790 RVA: 0x0150B106 File Offset: 0x01509306
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A56F RID: 42351
		public interface IInfrLimitTaskOpenParam
		{
			// Token: 0x170079F0 RID: 31216
			// (get) Token: 0x06046048 RID: 286792
			// (set) Token: 0x06046049 RID: 286793
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A570 RID: 42352
		public class InfrLimitTaskOpenParam : InfrastructureDefine.IInfrLimitTaskOpenParam
		{
			// Token: 0x170079F1 RID: 31217
			// (get) Token: 0x0604604A RID: 286794 RVA: 0x0150B117 File Offset: 0x01509317
			// (set) Token: 0x0604604B RID: 286795 RVA: 0x0150B11F File Offset: 0x0150931F
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200A571 RID: 42353
		[NullableContext(1)]
		public interface IInfrMaterialsDeliveryLockData
		{
			// Token: 0x170079F2 RID: 31218
			// (get) Token: 0x0604604D RID: 286797
			// (set) Token: 0x0604604E RID: 286798
			string LockDescriptionTextId { get; set; }

			// Token: 0x170079F3 RID: 31219
			// (get) Token: 0x0604604F RID: 286799
			// (set) Token: 0x06046050 RID: 286800
			[Nullable(new byte[]
			{
				2,
				1
			})]
			string[] LockDescriptionTextArgs { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }
		}

		// Token: 0x0200A572 RID: 42354
		[NullableContext(1)]
		[Nullable(0)]
		public class InfrMaterialsDeliveryLockData : InfrastructureDefine.IInfrMaterialsDeliveryLockData
		{
			// Token: 0x170079F4 RID: 31220
			// (get) Token: 0x06046051 RID: 286801 RVA: 0x0150B130 File Offset: 0x01509330
			// (set) Token: 0x06046052 RID: 286802 RVA: 0x0150B138 File Offset: 0x01509338
			public string LockDescriptionTextId { get; set; }

			// Token: 0x170079F5 RID: 31221
			// (get) Token: 0x06046053 RID: 286803 RVA: 0x0150B141 File Offset: 0x01509341
			// (set) Token: 0x06046054 RID: 286804 RVA: 0x0150B149 File Offset: 0x01509349
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public string[] LockDescriptionTextArgs { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1
			})] set; }
		}

		// Token: 0x0200A573 RID: 42355
		public class InfrNoticeData
		{
			// Token: 0x040332E7 RID: 209639
			public int RoadId;

			// Token: 0x040332E8 RID: 209640
			public int PasserId;

			// Token: 0x040332E9 RID: 209641
			public int GiftCount;

			// Token: 0x040332EA RID: 209642
			public long CreateTime;
		}

		// Token: 0x0200A574 RID: 42356
		public enum EInfrArchiveTabType
		{
			// Token: 0x040332EC RID: 209644
			CollectCard,
			// Token: 0x040332ED RID: 209645
			RoleCard
		}

		// Token: 0x0200A575 RID: 42357
		public enum EMaterialDeliveryOpenSource
		{
			// Token: 0x040332EF RID: 209647
			RoadNetworkMap,
			// Token: 0x040332F0 RID: 209648
			BigWorld
		}

		// Token: 0x0200A576 RID: 42358
		public enum EInfrViewOpenSource
		{
			// Token: 0x040332F2 RID: 209650
			Activity,
			// Token: 0x040332F3 RID: 209651
			Main,
			// Token: 0x040332F4 RID: 209652
			Delivery
		}
	}
}
