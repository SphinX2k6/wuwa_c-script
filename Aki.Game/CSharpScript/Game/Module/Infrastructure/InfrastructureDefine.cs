using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005902 RID: 22786
	public class InfrastructureDefine
	{
		// Token: 0x0401E2E2 RID: 123618
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

		// Token: 0x0401E2E3 RID: 123619
		public const int MAX_INFR_MARK_INFO_LINE_NUM = 3;

		// Token: 0x0401E2E4 RID: 123620
		public const int INFR_BATTLE_MATERIAL_ID = 80700001;

		// Token: 0x0401E2E5 RID: 123621
		public const int INFR_COLLECTION_MATERIAL_ID = 80700002;

		// Token: 0x0401E2E6 RID: 123622
		public const int INFR_QUEST_MATERIAL_ID = 80700003;

		// Token: 0x0401E2E7 RID: 123623
		public const int INFR_SHOP_CURRENCY_ID = 80700004;

		// Token: 0x0401E2E8 RID: 123624
		public const int INFR_OBSERVATORY_MARK_ID = 342011;

		// Token: 0x0401E2E9 RID: 123625
		[Nullable(1)]
		public const string INFR_ACTIVITY_MALE_TEXTURE = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainMale.T_AcivityMainMale";

		// Token: 0x0401E2EA RID: 123626
		[Nullable(1)]
		public const string INFR_ACTIVITY_FEMALE_TEXTURE = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainFemale.T_AcivityMainFemale";

		// Token: 0x0401E2EB RID: 123627
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

		// Token: 0x0401E2EC RID: 123628
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

		// Token: 0x0401E2ED RID: 123629
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

		// Token: 0x0200BB46 RID: 47942
		public enum EMainMissionIndex
		{
			// Token: 0x040388D1 RID: 231633
			Quest,
			// Token: 0x040388D2 RID: 231634
			BuildTarget
		}

		// Token: 0x0200BB47 RID: 47943
		public interface IInfrRoadData
		{
			// Token: 0x1700A221 RID: 41505
			// (get) Token: 0x0604FA53 RID: 326227
			// (set) Token: 0x0604FA54 RID: 326228
			int RoadId { get; set; }

			// Token: 0x1700A222 RID: 41506
			// (get) Token: 0x0604FA55 RID: 326229
			// (set) Token: 0x0604FA56 RID: 326230
			InfrStatusPb Status { get; set; }

			// Token: 0x1700A223 RID: 41507
			// (get) Token: 0x0604FA57 RID: 326231
			// (set) Token: 0x0604FA58 RID: 326232
			int CompleteTime { get; set; }

			// Token: 0x1700A224 RID: 41508
			// (get) Token: 0x0604FA59 RID: 326233
			// (set) Token: 0x0604FA5A RID: 326234
			int TotalGiftCount { get; set; }

			// Token: 0x1700A225 RID: 41509
			// (get) Token: 0x0604FA5B RID: 326235
			// (set) Token: 0x0604FA5C RID: 326236
			int LastGiftTime { get; set; }
		}

		// Token: 0x0200BB48 RID: 47944
		public class InfrRoadData : InfrastructureDefine.IInfrRoadData
		{
			// Token: 0x1700A226 RID: 41510
			// (get) Token: 0x0604FA5D RID: 326237 RVA: 0x01551802 File Offset: 0x0154FA02
			// (set) Token: 0x0604FA5E RID: 326238 RVA: 0x0155180A File Offset: 0x0154FA0A
			public int RoadId { get; set; }

			// Token: 0x1700A227 RID: 41511
			// (get) Token: 0x0604FA5F RID: 326239 RVA: 0x01551813 File Offset: 0x0154FA13
			// (set) Token: 0x0604FA60 RID: 326240 RVA: 0x0155181B File Offset: 0x0154FA1B
			public InfrStatusPb Status { get; set; }

			// Token: 0x1700A228 RID: 41512
			// (get) Token: 0x0604FA61 RID: 326241 RVA: 0x01551824 File Offset: 0x0154FA24
			// (set) Token: 0x0604FA62 RID: 326242 RVA: 0x0155182C File Offset: 0x0154FA2C
			public int CompleteTime { get; set; }

			// Token: 0x1700A229 RID: 41513
			// (get) Token: 0x0604FA63 RID: 326243 RVA: 0x01551835 File Offset: 0x0154FA35
			// (set) Token: 0x0604FA64 RID: 326244 RVA: 0x0155183D File Offset: 0x0154FA3D
			public int TotalGiftCount { get; set; }

			// Token: 0x1700A22A RID: 41514
			// (get) Token: 0x0604FA65 RID: 326245 RVA: 0x01551846 File Offset: 0x0154FA46
			// (set) Token: 0x0604FA66 RID: 326246 RVA: 0x0155184E File Offset: 0x0154FA4E
			public int LastGiftTime { get; set; }
		}

		// Token: 0x0200BB49 RID: 47945
		public interface IInfrLibraryTaskData
		{
			// Token: 0x1700A22B RID: 41515
			// (get) Token: 0x0604FA68 RID: 326248
			// (set) Token: 0x0604FA69 RID: 326249
			int TaskId { get; set; }

			// Token: 0x1700A22C RID: 41516
			// (get) Token: 0x0604FA6A RID: 326250
			// (set) Token: 0x0604FA6B RID: 326251
			int Target { get; set; }

			// Token: 0x1700A22D RID: 41517
			// (get) Token: 0x0604FA6C RID: 326252
			// (set) Token: 0x0604FA6D RID: 326253
			InfrTaskStatusPb Status { get; set; }
		}

		// Token: 0x0200BB4A RID: 47946
		public class InfrLibraryTaskData : InfrastructureDefine.IInfrLibraryTaskData
		{
			// Token: 0x1700A22E RID: 41518
			// (get) Token: 0x0604FA6E RID: 326254 RVA: 0x0155185F File Offset: 0x0154FA5F
			// (set) Token: 0x0604FA6F RID: 326255 RVA: 0x01551867 File Offset: 0x0154FA67
			public int TaskId { get; set; }

			// Token: 0x1700A22F RID: 41519
			// (get) Token: 0x0604FA70 RID: 326256 RVA: 0x01551870 File Offset: 0x0154FA70
			// (set) Token: 0x0604FA71 RID: 326257 RVA: 0x01551878 File Offset: 0x0154FA78
			public int Target { get; set; }

			// Token: 0x1700A230 RID: 41520
			// (get) Token: 0x0604FA72 RID: 326258 RVA: 0x01551881 File Offset: 0x0154FA81
			// (set) Token: 0x0604FA73 RID: 326259 RVA: 0x01551889 File Offset: 0x0154FA89
			public InfrTaskStatusPb Status { get; set; }
		}

		// Token: 0x0200BB4B RID: 47947
		public interface IInfrMaterialsDeliveryOpenParam
		{
			// Token: 0x1700A231 RID: 41521
			// (get) Token: 0x0604FA75 RID: 326261
			// (set) Token: 0x0604FA76 RID: 326262
			InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource { get; set; }

			// Token: 0x1700A232 RID: 41522
			// (get) Token: 0x0604FA77 RID: 326263
			// (set) Token: 0x0604FA78 RID: 326264
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A233 RID: 41523
			// (get) Token: 0x0604FA79 RID: 326265
			// (set) Token: 0x0604FA7A RID: 326266
			int RoadId { get; set; }

			// Token: 0x1700A234 RID: 41524
			// (get) Token: 0x0604FA7B RID: 326267
			// (set) Token: 0x0604FA7C RID: 326268
			int? ActionId { get; set; }
		}

		// Token: 0x0200BB4C RID: 47948
		public class InfrMaterialsDeliveryOpenParam : InfrastructureDefine.IInfrMaterialsDeliveryOpenParam
		{
			// Token: 0x1700A235 RID: 41525
			// (get) Token: 0x0604FA7D RID: 326269 RVA: 0x0155189A File Offset: 0x0154FA9A
			// (set) Token: 0x0604FA7E RID: 326270 RVA: 0x015518A2 File Offset: 0x0154FAA2
			public InfrastructureDefine.EMaterialDeliveryOpenSource OpenSource { get; set; }

			// Token: 0x1700A236 RID: 41526
			// (get) Token: 0x0604FA7F RID: 326271 RVA: 0x015518AB File Offset: 0x0154FAAB
			// (set) Token: 0x0604FA80 RID: 326272 RVA: 0x015518B3 File Offset: 0x0154FAB3
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A237 RID: 41527
			// (get) Token: 0x0604FA81 RID: 326273 RVA: 0x015518BC File Offset: 0x0154FABC
			// (set) Token: 0x0604FA82 RID: 326274 RVA: 0x015518C4 File Offset: 0x0154FAC4
			public int RoadId { get; set; }

			// Token: 0x1700A238 RID: 41528
			// (get) Token: 0x0604FA83 RID: 326275 RVA: 0x015518CD File Offset: 0x0154FACD
			// (set) Token: 0x0604FA84 RID: 326276 RVA: 0x015518D5 File Offset: 0x0154FAD5
			public int? ActionId { get; set; }
		}

		// Token: 0x0200BB4D RID: 47949
		[NullableContext(1)]
		public interface IInfrRoadNetworkInfoOpenParam
		{
			// Token: 0x1700A239 RID: 41529
			// (get) Token: 0x0604FA86 RID: 326278
			// (set) Token: 0x0604FA87 RID: 326279
			InfrastructureDefine.IInfrMaterialsDeliveryOpenParam InfoParam { get; set; }

			// Token: 0x1700A23A RID: 41530
			// (get) Token: 0x0604FA88 RID: 326280
			// (set) Token: 0x0604FA89 RID: 326281
			Action BuildCb { get; set; }

			// Token: 0x1700A23B RID: 41531
			// (get) Token: 0x0604FA8A RID: 326282
			// (set) Token: 0x0604FA8B RID: 326283
			Action CloseCb { get; set; }
		}

		// Token: 0x0200BB4E RID: 47950
		[NullableContext(1)]
		[Nullable(0)]
		public class InfrRoadNetworkInfoOpenParam : InfrastructureDefine.IInfrRoadNetworkInfoOpenParam
		{
			// Token: 0x1700A23C RID: 41532
			// (get) Token: 0x0604FA8C RID: 326284 RVA: 0x015518E6 File Offset: 0x0154FAE6
			// (set) Token: 0x0604FA8D RID: 326285 RVA: 0x015518EE File Offset: 0x0154FAEE
			public InfrastructureDefine.IInfrMaterialsDeliveryOpenParam InfoParam { get; set; }

			// Token: 0x1700A23D RID: 41533
			// (get) Token: 0x0604FA8E RID: 326286 RVA: 0x015518F7 File Offset: 0x0154FAF7
			// (set) Token: 0x0604FA8F RID: 326287 RVA: 0x015518FF File Offset: 0x0154FAFF
			public Action BuildCb { get; set; }

			// Token: 0x1700A23E RID: 41534
			// (get) Token: 0x0604FA90 RID: 326288 RVA: 0x01551908 File Offset: 0x0154FB08
			// (set) Token: 0x0604FA91 RID: 326289 RVA: 0x01551910 File Offset: 0x0154FB10
			public Action CloseCb { get; set; }
		}

		// Token: 0x0200BB4F RID: 47951
		public interface IInfrRoadNetworkOpenParam
		{
			// Token: 0x1700A23F RID: 41535
			// (get) Token: 0x0604FA93 RID: 326291
			// (set) Token: 0x0604FA94 RID: 326292
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A240 RID: 41536
			// (get) Token: 0x0604FA95 RID: 326293
			// (set) Token: 0x0604FA96 RID: 326294
			int RoadId { get; set; }

			// Token: 0x1700A241 RID: 41537
			// (get) Token: 0x0604FA97 RID: 326295
			// (set) Token: 0x0604FA98 RID: 326296
			bool? NeedPlayFinishSeq { get; set; }
		}

		// Token: 0x0200BB50 RID: 47952
		public class InfrRoadNetworkOpenParam : InfrastructureDefine.IInfrRoadNetworkOpenParam
		{
			// Token: 0x1700A242 RID: 41538
			// (get) Token: 0x0604FA99 RID: 326297 RVA: 0x01551921 File Offset: 0x0154FB21
			// (set) Token: 0x0604FA9A RID: 326298 RVA: 0x01551929 File Offset: 0x0154FB29
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A243 RID: 41539
			// (get) Token: 0x0604FA9B RID: 326299 RVA: 0x01551932 File Offset: 0x0154FB32
			// (set) Token: 0x0604FA9C RID: 326300 RVA: 0x0155193A File Offset: 0x0154FB3A
			public int RoadId { get; set; }

			// Token: 0x1700A244 RID: 41540
			// (get) Token: 0x0604FA9D RID: 326301 RVA: 0x01551943 File Offset: 0x0154FB43
			// (set) Token: 0x0604FA9E RID: 326302 RVA: 0x0155194B File Offset: 0x0154FB4B
			public bool? NeedPlayFinishSeq { get; set; }
		}

		// Token: 0x0200BB51 RID: 47953
		public interface IInfrSettleViewOpenParam
		{
			// Token: 0x1700A245 RID: 41541
			// (get) Token: 0x0604FAA0 RID: 326304
			// (set) Token: 0x0604FAA1 RID: 326305
			ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A246 RID: 41542
			// (get) Token: 0x0604FAA2 RID: 326306
			// (set) Token: 0x0604FAA3 RID: 326307
			int RoadId { get; set; }
		}

		// Token: 0x0200BB52 RID: 47954
		public class InfrSettleViewOpenParam : InfrastructureDefine.IInfrSettleViewOpenParam
		{
			// Token: 0x1700A247 RID: 41543
			// (get) Token: 0x0604FAA4 RID: 326308 RVA: 0x0155195C File Offset: 0x0154FB5C
			// (set) Token: 0x0604FAA5 RID: 326309 RVA: 0x01551964 File Offset: 0x0154FB64
			public ActionInfrastructureItemDeliveryType DeliveryType { get; set; }

			// Token: 0x1700A248 RID: 41544
			// (get) Token: 0x0604FAA6 RID: 326310 RVA: 0x0155196D File Offset: 0x0154FB6D
			// (set) Token: 0x0604FAA7 RID: 326311 RVA: 0x01551975 File Offset: 0x0154FB75
			public int RoadId { get; set; }
		}

		// Token: 0x0200BB53 RID: 47955
		[NullableContext(2)]
		public interface IInfrMainViewOpenParam
		{
			// Token: 0x1700A249 RID: 41545
			// (get) Token: 0x0604FAA9 RID: 326313
			// (set) Token: 0x0604FAAA RID: 326314
			bool NeedFocusBuildQuest { get; set; }

			// Token: 0x1700A24A RID: 41546
			// (get) Token: 0x0604FAAB RID: 326315
			// (set) Token: 0x0604FAAC RID: 326316
			bool? NeedPlayBuildSuccessSeq { get; set; }

			// Token: 0x1700A24B RID: 41547
			// (get) Token: 0x0604FAAD RID: 326317
			// (set) Token: 0x0604FAAE RID: 326318
			InfrastructureDefine.IInfrSettleViewOpenParam SettleInfo { get; set; }
		}

		// Token: 0x0200BB54 RID: 47956
		[NullableContext(2)]
		[Nullable(0)]
		public class InfrMainViewOpenParam : InfrastructureDefine.IInfrMainViewOpenParam
		{
			// Token: 0x1700A24C RID: 41548
			// (get) Token: 0x0604FAAF RID: 326319 RVA: 0x01551986 File Offset: 0x0154FB86
			// (set) Token: 0x0604FAB0 RID: 326320 RVA: 0x0155198E File Offset: 0x0154FB8E
			public bool NeedFocusBuildQuest { get; set; }

			// Token: 0x1700A24D RID: 41549
			// (get) Token: 0x0604FAB1 RID: 326321 RVA: 0x01551997 File Offset: 0x0154FB97
			// (set) Token: 0x0604FAB2 RID: 326322 RVA: 0x0155199F File Offset: 0x0154FB9F
			public bool? NeedPlayBuildSuccessSeq { get; set; }

			// Token: 0x1700A24E RID: 41550
			// (get) Token: 0x0604FAB3 RID: 326323 RVA: 0x015519A8 File Offset: 0x0154FBA8
			// (set) Token: 0x0604FAB4 RID: 326324 RVA: 0x015519B0 File Offset: 0x0154FBB0
			public InfrastructureDefine.IInfrSettleViewOpenParam SettleInfo { get; set; }
		}

		// Token: 0x0200BB55 RID: 47957
		public interface IInfrShopOpenParam
		{
			// Token: 0x1700A24F RID: 41551
			// (get) Token: 0x0604FAB6 RID: 326326
			// (set) Token: 0x0604FAB7 RID: 326327
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB56 RID: 47958
		public class InfrShopOpenParam : InfrastructureDefine.IInfrShopOpenParam
		{
			// Token: 0x1700A250 RID: 41552
			// (get) Token: 0x0604FAB8 RID: 326328 RVA: 0x015519C1 File Offset: 0x0154FBC1
			// (set) Token: 0x0604FAB9 RID: 326329 RVA: 0x015519C9 File Offset: 0x0154FBC9
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB57 RID: 47959
		public interface IInfrArchiveOpenParam
		{
			// Token: 0x1700A251 RID: 41553
			// (get) Token: 0x0604FABB RID: 326331
			// (set) Token: 0x0604FABC RID: 326332
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB58 RID: 47960
		public class InfrArchiveOpenParam : InfrastructureDefine.IInfrArchiveOpenParam
		{
			// Token: 0x1700A252 RID: 41554
			// (get) Token: 0x0604FABD RID: 326333 RVA: 0x015519DA File Offset: 0x0154FBDA
			// (set) Token: 0x0604FABE RID: 326334 RVA: 0x015519E2 File Offset: 0x0154FBE2
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB59 RID: 47961
		public interface IInfrLimitTaskOpenParam
		{
			// Token: 0x1700A253 RID: 41555
			// (get) Token: 0x0604FAC0 RID: 326336
			// (set) Token: 0x0604FAC1 RID: 326337
			InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB5A RID: 47962
		public class InfrLimitTaskOpenParam : InfrastructureDefine.IInfrLimitTaskOpenParam
		{
			// Token: 0x1700A254 RID: 41556
			// (get) Token: 0x0604FAC2 RID: 326338 RVA: 0x015519F3 File Offset: 0x0154FBF3
			// (set) Token: 0x0604FAC3 RID: 326339 RVA: 0x015519FB File Offset: 0x0154FBFB
			public InfrastructureDefine.EInfrViewOpenSource OpenSource { get; set; }
		}

		// Token: 0x0200BB5B RID: 47963
		[NullableContext(1)]
		public interface IInfrMaterialsDeliveryLockData
		{
			// Token: 0x1700A255 RID: 41557
			// (get) Token: 0x0604FAC5 RID: 326341
			// (set) Token: 0x0604FAC6 RID: 326342
			string LockDescriptionTextId { get; set; }

			// Token: 0x1700A256 RID: 41558
			// (get) Token: 0x0604FAC7 RID: 326343
			// (set) Token: 0x0604FAC8 RID: 326344
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

		// Token: 0x0200BB5C RID: 47964
		[NullableContext(1)]
		[Nullable(0)]
		public class InfrMaterialsDeliveryLockData : InfrastructureDefine.IInfrMaterialsDeliveryLockData
		{
			// Token: 0x1700A257 RID: 41559
			// (get) Token: 0x0604FAC9 RID: 326345 RVA: 0x01551A0C File Offset: 0x0154FC0C
			// (set) Token: 0x0604FACA RID: 326346 RVA: 0x01551A14 File Offset: 0x0154FC14
			public string LockDescriptionTextId { get; set; }

			// Token: 0x1700A258 RID: 41560
			// (get) Token: 0x0604FACB RID: 326347 RVA: 0x01551A1D File Offset: 0x0154FC1D
			// (set) Token: 0x0604FACC RID: 326348 RVA: 0x01551A25 File Offset: 0x0154FC25
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

		// Token: 0x0200BB5D RID: 47965
		public class InfrNoticeData
		{
			// Token: 0x040388EF RID: 231663
			public int RoadId;

			// Token: 0x040388F0 RID: 231664
			public int PasserId;

			// Token: 0x040388F1 RID: 231665
			public int GiftCount;

			// Token: 0x040388F2 RID: 231666
			public long CreateTime;
		}

		// Token: 0x0200BB5E RID: 47966
		public enum EInfrArchiveTabType
		{
			// Token: 0x040388F4 RID: 231668
			CollectCard,
			// Token: 0x040388F5 RID: 231669
			RoleCard
		}

		// Token: 0x0200BB5F RID: 47967
		public enum EMaterialDeliveryOpenSource
		{
			// Token: 0x040388F7 RID: 231671
			RoadNetworkMap,
			// Token: 0x040388F8 RID: 231672
			BigWorld
		}

		// Token: 0x0200BB60 RID: 47968
		public enum EInfrViewOpenSource
		{
			// Token: 0x040388FA RID: 231674
			Activity,
			// Token: 0x040388FB RID: 231675
			Main,
			// Token: 0x040388FC RID: 231676
			Delivery
		}
	}
}
