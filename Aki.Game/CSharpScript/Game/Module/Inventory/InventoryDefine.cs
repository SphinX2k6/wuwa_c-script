using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using FilterDefine;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005832 RID: 22578
	[NullableContext(1)]
	[Nullable(0)]
	public class InventoryDefine
	{
		// Token: 0x0401DFEE RID: 122862
		public const int CONFIG_ID = 1;

		// Token: 0x0401DFEF RID: 122863
		public const int LEVEL = 2;

		// Token: 0x0401DFF0 RID: 122864
		public const int QUALITY_ID = 3;

		// Token: 0x0401DFF1 RID: 122865
		public const int COUNT = 4;

		// Token: 0x0401DFF2 RID: 122866
		public const int SORT_INDEX = 5;

		// Token: 0x0401DFF3 RID: 122867
		public const int UNIQUE_ID = 6;

		// Token: 0x0401DFF4 RID: 122868
		public const int COMMON_COIN = 2;

		// Token: 0x0401DFF5 RID: 122869
		public const int ADVANCED_COIN = 3;

		// Token: 0x0401DFF6 RID: 122870
		public const int WAVEPLATE_COIN = 5;

		// Token: 0x0401DFF7 RID: 122871
		public const int WAVEPLATE_CRYSTAL_COIN = 6;

		// Token: 0x0401DFF8 RID: 122872
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<FilterDefine.EFilterType, InventoryDefine.ESettingGridType> recFilterRuleToGirdType = new Dictionary<FilterDefine.EFilterType, InventoryDefine.ESettingGridType>
		{
			{
				FilterDefine.EFilterType.VisionDestroyQuality,
				InventoryDefine.ESettingGridType.Small
			},
			{
				FilterDefine.EFilterType.PhantomManageCost,
				InventoryDefine.ESettingGridType.Small
			},
			{
				FilterDefine.EFilterType.VisionDestroyFetterGroup,
				InventoryDefine.ESettingGridType.Big
			},
			{
				FilterDefine.EFilterType.PhantomManageFirstMainProp,
				InventoryDefine.ESettingGridType.Big
			}
		};

		// Token: 0x0401DFF9 RID: 122873
		[StaticVariableRuleIgnore]
		public static readonly int[] weaponIdRange = new int[]
		{
			20000000,
			29999999
		};

		// Token: 0x0401DFFA RID: 122874
		[StaticVariableRuleIgnore]
		public static readonly int[] phantomIdRange = new int[]
		{
			60000000,
			60999999
		};

		// Token: 0x0401DFFB RID: 122875
		[StaticVariableRuleIgnore]
		public static readonly int[] phantomSpecificIdRange = new int[]
		{
			69000000,
			69999999
		};

		// Token: 0x0401DFFC RID: 122876
		[StaticVariableRuleIgnore]
		public static readonly int[] roleIdRange = new int[]
		{
			1000,
			2999
		};

		// Token: 0x0401DFFD RID: 122877
		[StaticVariableRuleIgnore]
		public static readonly int[] virtualIdRange = new int[]
		{
			1,
			999
		};

		// Token: 0x0401DFFE RID: 122878
		[StaticVariableRuleIgnore]
		public static readonly int[] cardIdRange = new int[]
		{
			80060000,
			80069999
		};

		// Token: 0x0401DFFF RID: 122879
		[StaticVariableRuleIgnore]
		public static readonly int[] previewItemIdRange = new int[]
		{
			30000,
			39999
		};

		// Token: 0x0401E000 RID: 122880
		[StaticVariableRuleIgnore]
		public static readonly int[] rogueCurrencyIdRange = new int[]
		{
			80100000,
			80100099
		};

		// Token: 0x0401E001 RID: 122881
		[StaticVariableRuleIgnore]
		public static readonly int[] rogueResCurrencyIdRange = new int[]
		{
			80100100,
			80109999
		};

		// Token: 0x0401E002 RID: 122882
		[StaticVariableRuleIgnore]
		public static readonly int[] weaponSkinIdRange = new int[]
		{
			80080000,
			80089999
		};

		// Token: 0x0401E003 RID: 122883
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatDialogItemRange = new int[]
		{
			80810000,
			80819999
		};

		// Token: 0x0401E004 RID: 122884
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatBackGroundItemRange = new int[]
		{
			80820000,
			80829999
		};

		// Token: 0x0401E005 RID: 122885
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatThemeItemRange = new int[]
		{
			80891001,
			80891999
		};

		// Token: 0x0401E006 RID: 122886
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatCharmItemRange = new int[]
		{
			80892001,
			80892999
		};

		// Token: 0x0401E007 RID: 122887
		[StaticVariableRuleIgnore]
		public static readonly int[] roleSkinIdRange = new int[]
		{
			81000000,
			81999999
		};

		// Token: 0x0401E008 RID: 122888
		[StaticVariableRuleIgnore]
		public static readonly int[] playerHeadRange = new int[]
		{
			82000000,
			82999999
		};

		// Token: 0x0401E009 RID: 122889
		[StaticVariableRuleIgnore]
		public static readonly int[] playerTitleRange = new int[]
		{
			82000000,
			82999999
		};

		// Token: 0x0401E00A RID: 122890
		[StaticVariableRuleIgnore]
		public static readonly int[] DangoAbyssItemRange = new int[]
		{
			83000000,
			83999999
		};

		// Token: 0x0401E00B RID: 122891
		[StaticVariableRuleIgnore]
		public static readonly int[] flySkinIdRange = new int[]
		{
			84000000,
			84999999
		};

		// Token: 0x0401E00C RID: 122892
		[StaticVariableRuleIgnore]
		public static readonly int[] calabashSkinIdRange = new int[]
		{
			86000000,
			86099999
		};

		// Token: 0x0401E00D RID: 122893
		[StaticVariableRuleIgnore]
		public static readonly int[] InfrastructureItemRange = new int[]
		{
			86100000,
			86199999
		};

		// Token: 0x0401E00E RID: 122894
		[StaticVariableRuleIgnore]
		public static readonly int[] PhantomArenaCardItemRange = new int[]
		{
			700000,
			750000
		};

		// Token: 0x0401E00F RID: 122895
		[StaticVariableRuleIgnore]
		public static readonly int[] PhantomArenaBadgeItemRange = new int[]
		{
			75001,
			80000
		};

		// Token: 0x0401E010 RID: 122896
		[StaticVariableRuleIgnore]
		public static readonly int[] HonamiStoryItemRange = new int[]
		{
			87000000,
			87999999
		};

		// Token: 0x0401E011 RID: 122897
		[StaticVariableRuleIgnore]
		public static readonly int[] HonamiStoryWeaponRange = new int[]
		{
			88000000,
			88999999
		};

		// Token: 0x0401E012 RID: 122898
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorFrameItemRange = new int[]
		{
			89400000,
			89499999
		};

		// Token: 0x0401E013 RID: 122899
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorStickerItemRange = new int[]
		{
			89100000,
			89199999
		};

		// Token: 0x0401E014 RID: 122900
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorDecorationItemRange = new int[]
		{
			89300000,
			89399999
		};

		// Token: 0x0401E015 RID: 122901
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorSkinItemRange = new int[]
		{
			89200000,
			89299999
		};

		// Token: 0x0401E016 RID: 122902
		[StaticVariableRuleIgnore]
		public static readonly int[] FurnitureItemRange = new int[]
		{
			80830001,
			80839999
		};

		// Token: 0x0401E017 RID: 122903
		[StaticVariableRuleIgnore]
		public static readonly int[] OrnamentItemRange = new int[]
		{
			80870001,
			80879999
		};

		// Token: 0x0401E018 RID: 122904
		[StaticVariableRuleIgnore]
		public static readonly int[] PinballRoleItemRange = new int[]
		{
			80850001,
			80859999
		};

		// Token: 0x0401E019 RID: 122905
		[StaticVariableRuleIgnore]
		public static readonly int[] PinballWeaponItemRange = new int[]
		{
			80860001,
			80869999
		};

		// Token: 0x0401E01A RID: 122906
		[StaticVariableRuleIgnore]
		public static readonly int[] roverRogueCurrencyIdRange = new int[]
		{
			89000000,
			89000099
		};

		// Token: 0x0401E01B RID: 122907
		[StaticVariableRuleIgnore]
		public static readonly int[] dangoBrawlRoleIdRange = new int[]
		{
			80700016,
			80700040
		};

		// Token: 0x0401E01C RID: 122908
		public const int MANAGE_CONFIG_FUNCTION_ID = 10096;

		// Token: 0x0401E01D RID: 122909
		public const int MANAGE_CONFIG_HELP_ID = 356;

		// Token: 0x0401E01E RID: 122910
		public const string EMPTY_CONFIG_TEXT_ID = "PhantomProject_EmptyProject";

		// Token: 0x0401E01F RID: 122911
		public const string EMPTY_RULE_TEXT_ID = "PhantomProject_EmptyChose";

		// Token: 0x0401E020 RID: 122912
		public const string EMPTY_CHECK_TEXT_ID = "PhantomProject_Tips02";

		// Token: 0x0401E021 RID: 122913
		public const int MANAGE_CONFIG_MAX_COUNT = 10;

		// Token: 0x0200BA32 RID: 47666
		[NullableContext(0)]
		public enum EItemMainTypeId
		{
			// Token: 0x04038466 RID: 230502
			Virtual,
			// Token: 0x04038467 RID: 230503
			Common,
			// Token: 0x04038468 RID: 230504
			Weapon,
			// Token: 0x04038469 RID: 230505
			Phantom,
			// Token: 0x0403846A RID: 230506
			Collection,
			// Token: 0x0403846B RID: 230507
			Material,
			// Token: 0x0403846C RID: 230508
			Mission,
			// Token: 0x0403846D RID: 230509
			Special,
			// Token: 0x0403846E RID: 230510
			Card,
			// Token: 0x0403846F RID: 230511
			DangoPluginItem,
			// Token: 0x04038470 RID: 230512
			PinballWeapon
		}

		// Token: 0x0200BA33 RID: 47667
		[NullableContext(0)]
		public enum EItemType
		{
			// Token: 0x04038472 RID: 230514
			Virtual,
			// Token: 0x04038473 RID: 230515
			Common,
			// Token: 0x04038474 RID: 230516
			Weapon,
			// Token: 0x04038475 RID: 230517
			WeaponMaterial = 4,
			// Token: 0x04038476 RID: 230518
			Task = 7,
			// Token: 0x04038477 RID: 230519
			Phantom = 9,
			// Token: 0x04038478 RID: 230520
			Gift = 11,
			// Token: 0x04038479 RID: 230521
			SpecialItem = 13,
			// Token: 0x0403847A RID: 230522
			Card,
			// Token: 0x0403847B RID: 230523
			RogueCurrency,
			// Token: 0x0403847C RID: 230524
			WeaponSkin = 18,
			// Token: 0x0403847D RID: 230525
			RoleSkin,
			// Token: 0x0403847E RID: 230526
			RecallActivityScore,
			// Token: 0x0403847F RID: 230527
			PlayerHead,
			// Token: 0x04038480 RID: 230528
			PlayerTitle,
			// Token: 0x04038481 RID: 230529
			FlySkin = 24,
			// Token: 0x04038482 RID: 230530
			HonamiStoryItem = 28,
			// Token: 0x04038483 RID: 230531
			HonamiStoryWeapon,
			// Token: 0x04038484 RID: 230532
			MotorSticker,
			// Token: 0x04038485 RID: 230533
			MotorDecoration,
			// Token: 0x04038486 RID: 230534
			MotorFrame,
			// Token: 0x04038487 RID: 230535
			MotorSkin,
			// Token: 0x04038488 RID: 230536
			Ornament = 35,
			// Token: 0x04038489 RID: 230537
			PinballWeapon,
			// Token: 0x0403848A RID: 230538
			PinballRole,
			// Token: 0x0403848B RID: 230539
			DangoBrawlRole = 43,
			// Token: 0x0403848C RID: 230540
			CookMenu = 60000,
			// Token: 0x0403848D RID: 230541
			CookFood,
			// Token: 0x0403848E RID: 230542
			ForgingFormula,
			// Token: 0x0403848F RID: 230543
			ComposeFormula,
			// Token: 0x04038490 RID: 230544
			Phonograph,
			// Token: 0x04038491 RID: 230545
			ShipTowerBuff,
			// Token: 0x04038492 RID: 230546
			AbyssItem,
			// Token: 0x04038493 RID: 230547
			BirthdayItem,
			// Token: 0x04038494 RID: 230548
			PayShopCoupon,
			// Token: 0x04038495 RID: 230549
			PhantomArenaCard,
			// Token: 0x04038496 RID: 230550
			PhantomArenaBadge,
			// Token: 0x04038497 RID: 230551
			CalabashSkin = 60015,
			// Token: 0x04038498 RID: 230552
			InfrastructureItem,
			// Token: 0x04038499 RID: 230553
			PhoneChatDialog,
			// Token: 0x0403849A RID: 230554
			PhoneChatBackGround,
			// Token: 0x0403849B RID: 230555
			Furniture,
			// Token: 0x0403849C RID: 230556
			PhoneChatTheme,
			// Token: 0x0403849D RID: 230557
			PhoneChatCharm
		}

		// Token: 0x0200BA34 RID: 47668
		[NullableContext(0)]
		public enum EItemInfoDisplayType
		{
			// Token: 0x0403849F RID: 230559
			StackCount,
			// Token: 0x040384A0 RID: 230560
			Level
		}

		// Token: 0x0200BA35 RID: 47669
		[NullableContext(0)]
		public enum EItemDataFunctionType
		{
			// Token: 0x040384A2 RID: 230562
			Lock,
			// Token: 0x040384A3 RID: 230563
			Deprecate
		}

		// Token: 0x0200BA36 RID: 47670
		[NullableContext(0)]
		public enum EItemDataType
		{
			// Token: 0x040384A5 RID: 230565
			CommonItem,
			// Token: 0x040384A6 RID: 230566
			RoleItem,
			// Token: 0x040384A7 RID: 230567
			WeaponItem,
			// Token: 0x040384A8 RID: 230568
			PhantomItem,
			// Token: 0x040384A9 RID: 230569
			PhantomCustomize,
			// Token: 0x040384AA RID: 230570
			VirtualItem,
			// Token: 0x040384AB RID: 230571
			CardItem,
			// Token: 0x040384AC RID: 230572
			PreviewItem,
			// Token: 0x040384AD RID: 230573
			RogueCurrency,
			// Token: 0x040384AE RID: 230574
			RogueResCurrency,
			// Token: 0x040384AF RID: 230575
			WeaponSkinItem,
			// Token: 0x040384B0 RID: 230576
			RoleSkinItem,
			// Token: 0x040384B1 RID: 230577
			PlayerHeadItem,
			// Token: 0x040384B2 RID: 230578
			DangoAbyssItem,
			// Token: 0x040384B3 RID: 230579
			FlySkinItem,
			// Token: 0x040384B4 RID: 230580
			PhantomArenaCard,
			// Token: 0x040384B5 RID: 230581
			PhantomArenaBadge,
			// Token: 0x040384B6 RID: 230582
			HonamiStoryItem,
			// Token: 0x040384B7 RID: 230583
			CalabashSkinItem,
			// Token: 0x040384B8 RID: 230584
			HonamiStoryWeapon,
			// Token: 0x040384B9 RID: 230585
			InfrastructureItem,
			// Token: 0x040384BA RID: 230586
			MotorStickerItem,
			// Token: 0x040384BB RID: 230587
			PhoneChatDialog,
			// Token: 0x040384BC RID: 230588
			PhoneChatBackGround,
			// Token: 0x040384BD RID: 230589
			PhoneChatTheme,
			// Token: 0x040384BE RID: 230590
			PhoneChatCharm,
			// Token: 0x040384BF RID: 230591
			FurnitureItem,
			// Token: 0x040384C0 RID: 230592
			MotorFrameItem,
			// Token: 0x040384C1 RID: 230593
			MotorDecorationItem,
			// Token: 0x040384C2 RID: 230594
			MotorSkinItem,
			// Token: 0x040384C3 RID: 230595
			OrnamentItem,
			// Token: 0x040384C4 RID: 230596
			PinballRoleItem,
			// Token: 0x040384C5 RID: 230597
			PinballWeaponItem,
			// Token: 0x040384C6 RID: 230598
			RoverRogueCurrency,
			// Token: 0x040384C7 RID: 230599
			DangoBrawlRoleItem
		}

		// Token: 0x0200BA37 RID: 47671
		public interface IItemViewDataInfo
		{
			// Token: 0x1700A1C1 RID: 41409
			// (get) Token: 0x0604F795 RID: 325525
			// (set) Token: 0x0604F796 RID: 325526
			int ConfigId { get; set; }

			// Token: 0x1700A1C2 RID: 41410
			// (get) Token: 0x0604F797 RID: 325527
			// (set) Token: 0x0604F798 RID: 325528
			int Count { get; set; }

			// Token: 0x1700A1C3 RID: 41411
			// (get) Token: 0x0604F799 RID: 325529
			// (set) Token: 0x0604F79A RID: 325530
			int StackId { get; set; }

			// Token: 0x1700A1C4 RID: 41412
			// (get) Token: 0x0604F79B RID: 325531
			// (set) Token: 0x0604F79C RID: 325532
			int QualityId { get; set; }

			// Token: 0x1700A1C5 RID: 41413
			// (get) Token: 0x0604F79D RID: 325533
			// (set) Token: 0x0604F79E RID: 325534
			bool IsLock { get; set; }

			// Token: 0x1700A1C6 RID: 41414
			// (get) Token: 0x0604F79F RID: 325535
			// (set) Token: 0x0604F7A0 RID: 325536
			bool IsDeprecate { get; set; }

			// Token: 0x1700A1C7 RID: 41415
			// (get) Token: 0x0604F7A1 RID: 325537
			// (set) Token: 0x0604F7A2 RID: 325538
			bool IsNewItem { get; set; }

			// Token: 0x1700A1C8 RID: 41416
			// (get) Token: 0x0604F7A3 RID: 325539
			// (set) Token: 0x0604F7A4 RID: 325540
			InventoryDefine.EItemDataType ItemDataType { get; set; }

			// Token: 0x1700A1C9 RID: 41417
			// (get) Token: 0x0604F7A5 RID: 325541
			// (set) Token: 0x0604F7A6 RID: 325542
			ItemDataBase ItemDataBase { get; set; }

			// Token: 0x1700A1CA RID: 41418
			// (get) Token: 0x0604F7A7 RID: 325543
			// (set) Token: 0x0604F7A8 RID: 325544
			bool HasRedDot { get; set; }

			// Token: 0x1700A1CB RID: 41419
			// (get) Token: 0x0604F7A9 RID: 325545
			// (set) Token: 0x0604F7AA RID: 325546
			ItemViewDefine.EItemOperationMode ItemOperationMode { get; set; }

			// Token: 0x1700A1CC RID: 41420
			// (get) Token: 0x0604F7AB RID: 325547
			// (set) Token: 0x0604F7AC RID: 325548
			bool IsSelectOn { get; set; }

			// Token: 0x1700A1CD RID: 41421
			// (get) Token: 0x0604F7AD RID: 325549
			// (set) Token: 0x0604F7AE RID: 325550
			int SelectOnNum { get; set; }
		}

		// Token: 0x0200BA38 RID: 47672
		[Nullable(0)]
		public class ItemViewDataInfo : InventoryDefine.IItemViewDataInfo
		{
			// Token: 0x0604F7AF RID: 325551 RVA: 0x01546188 File Offset: 0x01544388
			public ItemViewDataInfo(int configId, int count, int stackId, int qualityId, bool isLock, bool isDeprecate, bool isNewItem, InventoryDefine.EItemDataType itemDataType, ItemDataBase itemDataBase, bool hasRedDot, ItemViewDefine.EItemOperationMode itemOperationMode, bool isSelectOn, int selectOnNum)
			{
			}

			// Token: 0x1700A1CE RID: 41422
			// (get) Token: 0x0604F7B0 RID: 325552 RVA: 0x01546200 File Offset: 0x01544400
			// (set) Token: 0x0604F7B1 RID: 325553 RVA: 0x01546208 File Offset: 0x01544408
			public int ConfigId { get; set; } = configId;

			// Token: 0x1700A1CF RID: 41423
			// (get) Token: 0x0604F7B2 RID: 325554 RVA: 0x01546211 File Offset: 0x01544411
			// (set) Token: 0x0604F7B3 RID: 325555 RVA: 0x01546219 File Offset: 0x01544419
			public int Count { get; set; } = count;

			// Token: 0x1700A1D0 RID: 41424
			// (get) Token: 0x0604F7B4 RID: 325556 RVA: 0x01546222 File Offset: 0x01544422
			// (set) Token: 0x0604F7B5 RID: 325557 RVA: 0x0154622A File Offset: 0x0154442A
			public int StackId { get; set; } = stackId;

			// Token: 0x1700A1D1 RID: 41425
			// (get) Token: 0x0604F7B6 RID: 325558 RVA: 0x01546233 File Offset: 0x01544433
			// (set) Token: 0x0604F7B7 RID: 325559 RVA: 0x0154623B File Offset: 0x0154443B
			public int QualityId { get; set; } = qualityId;

			// Token: 0x1700A1D2 RID: 41426
			// (get) Token: 0x0604F7B8 RID: 325560 RVA: 0x01546244 File Offset: 0x01544444
			// (set) Token: 0x0604F7B9 RID: 325561 RVA: 0x0154624C File Offset: 0x0154444C
			public bool IsLock { get; set; } = isLock;

			// Token: 0x1700A1D3 RID: 41427
			// (get) Token: 0x0604F7BA RID: 325562 RVA: 0x01546255 File Offset: 0x01544455
			// (set) Token: 0x0604F7BB RID: 325563 RVA: 0x0154625D File Offset: 0x0154445D
			public bool IsDeprecate { get; set; } = isDeprecate;

			// Token: 0x1700A1D4 RID: 41428
			// (get) Token: 0x0604F7BC RID: 325564 RVA: 0x01546266 File Offset: 0x01544466
			// (set) Token: 0x0604F7BD RID: 325565 RVA: 0x0154626E File Offset: 0x0154446E
			public bool IsNewItem { get; set; } = isNewItem;

			// Token: 0x1700A1D5 RID: 41429
			// (get) Token: 0x0604F7BE RID: 325566 RVA: 0x01546277 File Offset: 0x01544477
			// (set) Token: 0x0604F7BF RID: 325567 RVA: 0x0154627F File Offset: 0x0154447F
			public InventoryDefine.EItemDataType ItemDataType { get; set; } = itemDataType;

			// Token: 0x1700A1D6 RID: 41430
			// (get) Token: 0x0604F7C0 RID: 325568 RVA: 0x01546288 File Offset: 0x01544488
			// (set) Token: 0x0604F7C1 RID: 325569 RVA: 0x01546290 File Offset: 0x01544490
			public ItemDataBase ItemDataBase { get; set; } = itemDataBase;

			// Token: 0x1700A1D7 RID: 41431
			// (get) Token: 0x0604F7C2 RID: 325570 RVA: 0x01546299 File Offset: 0x01544499
			// (set) Token: 0x0604F7C3 RID: 325571 RVA: 0x015462A1 File Offset: 0x015444A1
			public bool HasRedDot { get; set; } = hasRedDot;

			// Token: 0x1700A1D8 RID: 41432
			// (get) Token: 0x0604F7C4 RID: 325572 RVA: 0x015462AA File Offset: 0x015444AA
			// (set) Token: 0x0604F7C5 RID: 325573 RVA: 0x015462B2 File Offset: 0x015444B2
			public ItemViewDefine.EItemOperationMode ItemOperationMode { get; set; } = itemOperationMode;

			// Token: 0x1700A1D9 RID: 41433
			// (get) Token: 0x0604F7C6 RID: 325574 RVA: 0x015462BB File Offset: 0x015444BB
			// (set) Token: 0x0604F7C7 RID: 325575 RVA: 0x015462C3 File Offset: 0x015444C3
			public bool IsSelectOn { get; set; } = isSelectOn;

			// Token: 0x1700A1DA RID: 41434
			// (get) Token: 0x0604F7C8 RID: 325576 RVA: 0x015462CC File Offset: 0x015444CC
			// (set) Token: 0x0604F7C9 RID: 325577 RVA: 0x015462D4 File Offset: 0x015444D4
			public int SelectOnNum { get; set; } = selectOnNum;
		}

		// Token: 0x0200BA39 RID: 47673
		public interface IPublicItemConfig
		{
			// Token: 0x1700A1DB RID: 41435
			// (get) Token: 0x0604F7CA RID: 325578
			// (set) Token: 0x0604F7CB RID: 325579
			int TypeDescription { get; set; }

			// Token: 0x1700A1DC RID: 41436
			// (get) Token: 0x0604F7CC RID: 325580
			// (set) Token: 0x0604F7CD RID: 325581
			int AttributesDescription { get; set; }

			// Token: 0x1700A1DD RID: 41437
			// (get) Token: 0x0604F7CE RID: 325582
			// (set) Token: 0x0604F7CF RID: 325583
			int BgDescription { get; set; }

			// Token: 0x1700A1DE RID: 41438
			// (get) Token: 0x0604F7D0 RID: 325584
			// (set) Token: 0x0604F7D1 RID: 325585
			string Icon { get; set; }

			// Token: 0x1700A1DF RID: 41439
			// (get) Token: 0x0604F7D2 RID: 325586
			// (set) Token: 0x0604F7D3 RID: 325587
			int QualityId { get; set; }

			// Token: 0x1700A1E0 RID: 41440
			// (get) Token: 0x0604F7D4 RID: 325588
			// (set) Token: 0x0604F7D5 RID: 325589
			int MaxCapcity { get; set; }

			// Token: 0x1700A1E1 RID: 41441
			// (get) Token: 0x0604F7D6 RID: 325590
			// (set) Token: 0x0604F7D7 RID: 325591
			int[] ItemAccess { get; set; }

			// Token: 0x1700A1E2 RID: 41442
			// (get) Token: 0x0604F7D8 RID: 325592
			// (set) Token: 0x0604F7D9 RID: 325593
			string Mesh { get; set; }
		}

		// Token: 0x0200BA3A RID: 47674
		public interface IGetItemData
		{
			// Token: 0x1700A1E3 RID: 41443
			// (get) Token: 0x0604F7DA RID: 325594
			// (set) Token: 0x0604F7DB RID: 325595
			int ItemId { get; set; }

			// Token: 0x1700A1E4 RID: 41444
			// (get) Token: 0x0604F7DC RID: 325596
			// (set) Token: 0x0604F7DD RID: 325597
			int IncId { get; set; }
		}

		// Token: 0x0200BA3B RID: 47675
		[NullableContext(0)]
		public class GetItemData : InventoryDefine.IGetItemData
		{
			// Token: 0x0604F7DE RID: 325598 RVA: 0x015462DD File Offset: 0x015444DD
			public GetItemData(int itemId, int incId)
			{
			}

			// Token: 0x1700A1E5 RID: 41445
			// (get) Token: 0x0604F7DF RID: 325599 RVA: 0x015462F3 File Offset: 0x015444F3
			// (set) Token: 0x0604F7E0 RID: 325600 RVA: 0x015462FB File Offset: 0x015444FB
			public int ItemId { get; set; } = itemId;

			// Token: 0x1700A1E6 RID: 41446
			// (get) Token: 0x0604F7E1 RID: 325601 RVA: 0x01546304 File Offset: 0x01544504
			// (set) Token: 0x0604F7E2 RID: 325602 RVA: 0x0154630C File Offset: 0x0154450C
			public int IncId { get; set; } = incId;
		}

		// Token: 0x0200BA3C RID: 47676
		[NullableContext(0)]
		public enum EUseType
		{
			// Token: 0x040384D8 RID: 230616
			OpenGiftPack = 2,
			// Token: 0x040384D9 RID: 230617
			AddTeamExpAuto,
			// Token: 0x040384DA RID: 230618
			OpenGiftPackAuto,
			// Token: 0x040384DB RID: 230619
			AddRoleAuto,
			// Token: 0x040384DC RID: 230620
			CostItem,
			// Token: 0x040384DD RID: 230621
			AddVisionSkillAuto = 8,
			// Token: 0x040384DE RID: 230622
			AddEnergy,
			// Token: 0x040384DF RID: 230623
			AddPropRewardAuto,
			// Token: 0x040384E0 RID: 230624
			AddRoleFavorAuto,
			// Token: 0x040384E1 RID: 230625
			ForInfoDisplay
		}

		// Token: 0x0200BA3D RID: 47677
		[NullableContext(0)]
		public enum EShowType
		{
			// Token: 0x040384E3 RID: 230627
			Exp = 1,
			// Token: 0x040384E4 RID: 230628
			NormalCoin,
			// Token: 0x040384E5 RID: 230629
			SeniorCoin,
			// Token: 0x040384E6 RID: 230630
			SuperCoin,
			// Token: 0x040384E7 RID: 230631
			Power,
			// Token: 0x040384E8 RID: 230632
			CultivateMaterial,
			// Token: 0x040384E9 RID: 230633
			RoleBreachMaterial,
			// Token: 0x040384EA RID: 230634
			SkillUpgradeMaterial,
			// Token: 0x040384EB RID: 230635
			Material,
			// Token: 0x040384EC RID: 230636
			Consumable,
			// Token: 0x040384ED RID: 230637
			RoleExpMaterial,
			// Token: 0x040384EE RID: 230638
			WeaponExpMaterial,
			// Token: 0x040384EF RID: 230639
			WeaponBreachMaterial,
			// Token: 0x040384F0 RID: 230640
			ResonanceAmplificationMaterial,
			// Token: 0x040384F1 RID: 230641
			ExchangeCoin,
			// Token: 0x040384F2 RID: 230642
			PropBag,
			// Token: 0x040384F3 RID: 230643
			TuningProve,
			// Token: 0x040384F4 RID: 230644
			TuningExchangeCoin,
			// Token: 0x040384F5 RID: 230645
			MonthlyTicket,
			// Token: 0x040384F6 RID: 230646
			Supply,
			// Token: 0x040384F7 RID: 230647
			TaskItem,
			// Token: 0x040384F8 RID: 230648
			PhantomExpMaterial,
			// Token: 0x040384F9 RID: 230649
			CookFinishedProduct,
			// Token: 0x040384FA RID: 230650
			CookMenu,
			// Token: 0x040384FB RID: 230651
			MachiningProduct,
			// Token: 0x040384FC RID: 230652
			CookMaterial,
			// Token: 0x040384FD RID: 230653
			Favorability,
			// Token: 0x040384FE RID: 230654
			PowerPrestige,
			// Token: 0x040384FF RID: 230655
			Fragment,
			// Token: 0x04038500 RID: 230656
			RoleCallback,
			// Token: 0x04038501 RID: 230657
			CookSell,
			// Token: 0x04038502 RID: 230658
			ChangeStar,
			// Token: 0x04038503 RID: 230659
			LevelItem,
			// Token: 0x04038504 RID: 230660
			ForgingMenu,
			// Token: 0x04038505 RID: 230661
			ComposeMenu,
			// Token: 0x04038506 RID: 230662
			ComposeProduct,
			// Token: 0x04038507 RID: 230663
			ComposeStructure,
			// Token: 0x04038508 RID: 230664
			ComposeStructureProduct,
			// Token: 0x04038509 RID: 230665
			RandomPhantomItem = 41,
			// Token: 0x0403850A RID: 230666
			Modifier = 54,
			// Token: 0x0403850B RID: 230667
			ModifierSub = 58,
			// Token: 0x0403850C RID: 230668
			ResonantSelectItem = 62
		}

		// Token: 0x0200BA3E RID: 47678
		[NullableContext(0)]
		public enum ERedDotDisableRule
		{
			// Token: 0x0403850E RID: 230670
			None,
			// Token: 0x0403850F RID: 230671
			AfterSelect,
			// Token: 0x04038510 RID: 230672
			AfterUse,
			// Token: 0x04038511 RID: 230673
			ServerFirstSelect
		}

		// Token: 0x0200BA3F RID: 47679
		[NullableContext(0)]
		public enum EQuality
		{
			// Token: 0x04038513 RID: 230675
			White = 1,
			// Token: 0x04038514 RID: 230676
			Green,
			// Token: 0x04038515 RID: 230677
			Blue,
			// Token: 0x04038516 RID: 230678
			Purple,
			// Token: 0x04038517 RID: 230679
			Orange
		}

		// Token: 0x0200BA40 RID: 47680
		[NullableContext(0)]
		public enum EItemDataFunctionValue
		{
			// Token: 0x04038519 RID: 230681
			Default,
			// Token: 0x0403851A RID: 230682
			Lock,
			// Token: 0x0403851B RID: 230683
			Deprecate
		}

		// Token: 0x0200BA41 RID: 47681
		public interface IManageConfigTypeItemData
		{
			// Token: 0x1700A1E7 RID: 41447
			// (get) Token: 0x0604F7E3 RID: 325603
			// (set) Token: 0x0604F7E4 RID: 325604
			PhantomSettingType Type { get; set; }

			// Token: 0x1700A1E8 RID: 41448
			// (get) Token: 0x0604F7E5 RID: 325605
			// (set) Token: 0x0604F7E6 RID: 325606
			string Name { get; set; }
		}

		// Token: 0x0200BA42 RID: 47682
		[Nullable(0)]
		public class ManageConfigTypeItemData : InventoryDefine.IManageConfigTypeItemData
		{
			// Token: 0x1700A1E9 RID: 41449
			// (get) Token: 0x0604F7E7 RID: 325607 RVA: 0x01546315 File Offset: 0x01544515
			// (set) Token: 0x0604F7E8 RID: 325608 RVA: 0x0154631D File Offset: 0x0154451D
			public PhantomSettingType Type { get; set; } = PhantomSettingType.AutoDisuse;

			// Token: 0x1700A1EA RID: 41450
			// (get) Token: 0x0604F7E9 RID: 325609 RVA: 0x01546326 File Offset: 0x01544526
			// (set) Token: 0x0604F7EA RID: 325610 RVA: 0x0154632E File Offset: 0x0154452E
			public string Name { get; set; } = "";
		}

		// Token: 0x0200BA43 RID: 47683
		[NullableContext(0)]
		public enum ESettingGridType
		{
			// Token: 0x0403851F RID: 230687
			Small = 1,
			// Token: 0x04038520 RID: 230688
			Big
		}

		// Token: 0x0200BA44 RID: 47684
		public interface IManageConfigTitleItemData
		{
			// Token: 0x1700A1EB RID: 41451
			// (get) Token: 0x0604F7EC RID: 325612
			// (set) Token: 0x0604F7ED RID: 325613
			int FilterId { get; set; }

			// Token: 0x1700A1EC RID: 41452
			// (get) Token: 0x0604F7EE RID: 325614
			// (set) Token: 0x0604F7EF RID: 325615
			int FilterRuleId { get; set; }
		}

		// Token: 0x0200BA45 RID: 47685
		[NullableContext(0)]
		public class ManageConfigTitleItemData : InventoryDefine.IManageConfigTitleItemData
		{
			// Token: 0x1700A1ED RID: 41453
			// (get) Token: 0x0604F7F0 RID: 325616 RVA: 0x01546351 File Offset: 0x01544551
			// (set) Token: 0x0604F7F1 RID: 325617 RVA: 0x01546359 File Offset: 0x01544559
			public int FilterId { get; set; }

			// Token: 0x1700A1EE RID: 41454
			// (get) Token: 0x0604F7F2 RID: 325618 RVA: 0x01546362 File Offset: 0x01544562
			// (set) Token: 0x0604F7F3 RID: 325619 RVA: 0x0154636A File Offset: 0x0154456A
			public int FilterRuleId { get; set; }
		}

		// Token: 0x0200BA46 RID: 47686
		public interface IManageConfigSettingGridData
		{
			// Token: 0x1700A1EF RID: 41455
			// (get) Token: 0x0604F7F5 RID: 325621
			// (set) Token: 0x0604F7F6 RID: 325622
			bool IsFirst { get; set; }

			// Token: 0x1700A1F0 RID: 41456
			// (get) Token: 0x0604F7F7 RID: 325623
			// (set) Token: 0x0604F7F8 RID: 325624
			bool IsEmpty { get; set; }

			// Token: 0x1700A1F1 RID: 41457
			// (get) Token: 0x0604F7F9 RID: 325625
			// (set) Token: 0x0604F7FA RID: 325626
			bool IsAdd { get; set; }

			// Token: 0x1700A1F2 RID: 41458
			// (get) Token: 0x0604F7FB RID: 325627
			// (set) Token: 0x0604F7FC RID: 325628
			bool IsSelect { get; set; }

			// Token: 0x1700A1F3 RID: 41459
			// (get) Token: 0x0604F7FD RID: 325629
			// (set) Token: 0x0604F7FE RID: 325630
			bool IsEditing { get; set; }

			// Token: 0x1700A1F4 RID: 41460
			// (get) Token: 0x0604F7FF RID: 325631
			// (set) Token: 0x0604F800 RID: 325632
			int RuleId { get; set; }

			// Token: 0x1700A1F5 RID: 41461
			// (get) Token: 0x0604F801 RID: 325633
			// (set) Token: 0x0604F802 RID: 325634
			int Value { get; set; }
		}

		// Token: 0x0200BA47 RID: 47687
		[NullableContext(0)]
		public class ManageConfigSettingGridData : InventoryDefine.IManageConfigSettingGridData
		{
			// Token: 0x1700A1F6 RID: 41462
			// (get) Token: 0x0604F803 RID: 325635 RVA: 0x0154637B File Offset: 0x0154457B
			// (set) Token: 0x0604F804 RID: 325636 RVA: 0x01546383 File Offset: 0x01544583
			public bool IsFirst { get; set; }

			// Token: 0x1700A1F7 RID: 41463
			// (get) Token: 0x0604F805 RID: 325637 RVA: 0x0154638C File Offset: 0x0154458C
			// (set) Token: 0x0604F806 RID: 325638 RVA: 0x01546394 File Offset: 0x01544594
			public bool IsEmpty { get; set; }

			// Token: 0x1700A1F8 RID: 41464
			// (get) Token: 0x0604F807 RID: 325639 RVA: 0x0154639D File Offset: 0x0154459D
			// (set) Token: 0x0604F808 RID: 325640 RVA: 0x015463A5 File Offset: 0x015445A5
			public bool IsAdd { get; set; }

			// Token: 0x1700A1F9 RID: 41465
			// (get) Token: 0x0604F809 RID: 325641 RVA: 0x015463AE File Offset: 0x015445AE
			// (set) Token: 0x0604F80A RID: 325642 RVA: 0x015463B6 File Offset: 0x015445B6
			public bool IsSelect { get; set; }

			// Token: 0x1700A1FA RID: 41466
			// (get) Token: 0x0604F80B RID: 325643 RVA: 0x015463BF File Offset: 0x015445BF
			// (set) Token: 0x0604F80C RID: 325644 RVA: 0x015463C7 File Offset: 0x015445C7
			public bool IsEditing { get; set; }

			// Token: 0x1700A1FB RID: 41467
			// (get) Token: 0x0604F80D RID: 325645 RVA: 0x015463D0 File Offset: 0x015445D0
			// (set) Token: 0x0604F80E RID: 325646 RVA: 0x015463D8 File Offset: 0x015445D8
			public int RuleId { get; set; }

			// Token: 0x1700A1FC RID: 41468
			// (get) Token: 0x0604F80F RID: 325647 RVA: 0x015463E1 File Offset: 0x015445E1
			// (set) Token: 0x0604F810 RID: 325648 RVA: 0x015463E9 File Offset: 0x015445E9
			public int Value { get; set; }
		}

		// Token: 0x0200BA48 RID: 47688
		public interface ISelectViewData
		{
			// Token: 0x1700A1FD RID: 41469
			// (get) Token: 0x0604F812 RID: 325650
			// (set) Token: 0x0604F813 RID: 325651
			string GridType { get; set; }

			// Token: 0x1700A1FE RID: 41470
			// (get) Token: 0x0604F814 RID: 325652
			// (set) Token: 0x0604F815 RID: 325653
			int FilterId { get; set; }

			// Token: 0x1700A1FF RID: 41471
			// (get) Token: 0x0604F816 RID: 325654
			// (set) Token: 0x0604F817 RID: 325655
			int[] RuleIdList { get; set; }

			// Token: 0x1700A200 RID: 41472
			// (get) Token: 0x0604F818 RID: 325656
			// (set) Token: 0x0604F819 RID: 325657
			Dictionary<int, int[]> ValueMap { get; set; }

			// Token: 0x1700A201 RID: 41473
			// (get) Token: 0x0604F81A RID: 325658
			// (set) Token: 0x0604F81B RID: 325659
			Action<Dictionary<int, int[]>> CallbackConfirm { get; set; }
		}

		// Token: 0x0200BA49 RID: 47689
		[Nullable(0)]
		public class SelectViewData : InventoryDefine.ISelectViewData
		{
			// Token: 0x1700A202 RID: 41474
			// (get) Token: 0x0604F81C RID: 325660 RVA: 0x015463FA File Offset: 0x015445FA
			// (set) Token: 0x0604F81D RID: 325661 RVA: 0x01546402 File Offset: 0x01544602
			public string GridType { get; set; } = "";

			// Token: 0x1700A203 RID: 41475
			// (get) Token: 0x0604F81E RID: 325662 RVA: 0x0154640B File Offset: 0x0154460B
			// (set) Token: 0x0604F81F RID: 325663 RVA: 0x01546413 File Offset: 0x01544613
			public int FilterId { get; set; }

			// Token: 0x1700A204 RID: 41476
			// (get) Token: 0x0604F820 RID: 325664 RVA: 0x0154641C File Offset: 0x0154461C
			// (set) Token: 0x0604F821 RID: 325665 RVA: 0x01546424 File Offset: 0x01544624
			public int[] RuleIdList { get; set; } = Array.Empty<int>();

			// Token: 0x1700A205 RID: 41477
			// (get) Token: 0x0604F822 RID: 325666 RVA: 0x0154642D File Offset: 0x0154462D
			// (set) Token: 0x0604F823 RID: 325667 RVA: 0x01546435 File Offset: 0x01544635
			public Dictionary<int, int[]> ValueMap { get; set; } = new Dictionary<int, int[]>();

			// Token: 0x1700A206 RID: 41478
			// (get) Token: 0x0604F824 RID: 325668 RVA: 0x0154643E File Offset: 0x0154463E
			// (set) Token: 0x0604F825 RID: 325669 RVA: 0x01546446 File Offset: 0x01544646
			public Action<Dictionary<int, int[]>> CallbackConfirm { get; set; }
		}

		// Token: 0x0200BA4A RID: 47690
		public interface ISelectGroupData
		{
			// Token: 0x1700A207 RID: 41479
			// (get) Token: 0x0604F827 RID: 325671
			// (set) Token: 0x0604F828 RID: 325672
			int FilterId { get; set; }

			// Token: 0x1700A208 RID: 41480
			// (get) Token: 0x0604F829 RID: 325673
			// (set) Token: 0x0604F82A RID: 325674
			int FilterRuleId { get; set; }

			// Token: 0x1700A209 RID: 41481
			// (get) Token: 0x0604F82B RID: 325675
			// (set) Token: 0x0604F82C RID: 325676
			bool HasSelectAll { get; set; }

			// Token: 0x1700A20A RID: 41482
			// (get) Token: 0x0604F82D RID: 325677
			// (set) Token: 0x0604F82E RID: 325678
			bool NeedChangeColor { get; set; }

			// Token: 0x1700A20B RID: 41483
			// (get) Token: 0x0604F82F RID: 325679
			// (set) Token: 0x0604F830 RID: 325680
			int[] ValueList { get; set; }
		}

		// Token: 0x0200BA4B RID: 47691
		[Nullable(0)]
		public class SelectGroupData : InventoryDefine.ISelectGroupData
		{
			// Token: 0x1700A20C RID: 41484
			// (get) Token: 0x0604F831 RID: 325681 RVA: 0x01546478 File Offset: 0x01544678
			// (set) Token: 0x0604F832 RID: 325682 RVA: 0x01546480 File Offset: 0x01544680
			public int FilterId { get; set; }

			// Token: 0x1700A20D RID: 41485
			// (get) Token: 0x0604F833 RID: 325683 RVA: 0x01546489 File Offset: 0x01544689
			// (set) Token: 0x0604F834 RID: 325684 RVA: 0x01546491 File Offset: 0x01544691
			public int FilterRuleId { get; set; }

			// Token: 0x1700A20E RID: 41486
			// (get) Token: 0x0604F835 RID: 325685 RVA: 0x0154649A File Offset: 0x0154469A
			// (set) Token: 0x0604F836 RID: 325686 RVA: 0x015464A2 File Offset: 0x015446A2
			public bool HasSelectAll { get; set; }

			// Token: 0x1700A20F RID: 41487
			// (get) Token: 0x0604F837 RID: 325687 RVA: 0x015464AB File Offset: 0x015446AB
			// (set) Token: 0x0604F838 RID: 325688 RVA: 0x015464B3 File Offset: 0x015446B3
			public bool NeedChangeColor { get; set; }

			// Token: 0x1700A210 RID: 41488
			// (get) Token: 0x0604F839 RID: 325689 RVA: 0x015464BC File Offset: 0x015446BC
			// (set) Token: 0x0604F83A RID: 325690 RVA: 0x015464C4 File Offset: 0x015446C4
			public int[] ValueList { get; set; } = Array.Empty<int>();
		}

		// Token: 0x0200BA4C RID: 47692
		[NullableContext(2)]
		public interface ISelectItemData
		{
			// Token: 0x1700A211 RID: 41489
			// (get) Token: 0x0604F83C RID: 325692
			// (set) Token: 0x0604F83D RID: 325693
			bool IsShowIcon { get; set; }

			// Token: 0x1700A212 RID: 41490
			// (get) Token: 0x0604F83E RID: 325694
			// (set) Token: 0x0604F83F RID: 325695
			bool NeedChangeColor { get; set; }

			// Token: 0x1700A213 RID: 41491
			// (get) Token: 0x0604F840 RID: 325696
			// (set) Token: 0x0604F841 RID: 325697
			int FilterId { get; set; }

			// Token: 0x1700A214 RID: 41492
			// (get) Token: 0x0604F842 RID: 325698
			// (set) Token: 0x0604F843 RID: 325699
			int FilterRuleId { get; set; }

			// Token: 0x1700A215 RID: 41493
			// (get) Token: 0x0604F844 RID: 325700
			// (set) Token: 0x0604F845 RID: 325701
			int Value { get; set; }

			// Token: 0x1700A216 RID: 41494
			// (get) Token: 0x0604F846 RID: 325702
			// (set) Token: 0x0604F847 RID: 325703
			string IconPath { get; set; }

			// Token: 0x1700A217 RID: 41495
			// (get) Token: 0x0604F848 RID: 325704
			// (set) Token: 0x0604F849 RID: 325705
			string Name { get; set; }
		}

		// Token: 0x0200BA4D RID: 47693
		[NullableContext(2)]
		[Nullable(0)]
		public class SelectItemData : InventoryDefine.ISelectItemData
		{
			// Token: 0x1700A218 RID: 41496
			// (get) Token: 0x0604F84A RID: 325706 RVA: 0x015464E0 File Offset: 0x015446E0
			// (set) Token: 0x0604F84B RID: 325707 RVA: 0x015464E8 File Offset: 0x015446E8
			public bool IsShowIcon { get; set; }

			// Token: 0x1700A219 RID: 41497
			// (get) Token: 0x0604F84C RID: 325708 RVA: 0x015464F1 File Offset: 0x015446F1
			// (set) Token: 0x0604F84D RID: 325709 RVA: 0x015464F9 File Offset: 0x015446F9
			public bool NeedChangeColor { get; set; }

			// Token: 0x1700A21A RID: 41498
			// (get) Token: 0x0604F84E RID: 325710 RVA: 0x01546502 File Offset: 0x01544702
			// (set) Token: 0x0604F84F RID: 325711 RVA: 0x0154650A File Offset: 0x0154470A
			public int FilterId { get; set; }

			// Token: 0x1700A21B RID: 41499
			// (get) Token: 0x0604F850 RID: 325712 RVA: 0x01546513 File Offset: 0x01544713
			// (set) Token: 0x0604F851 RID: 325713 RVA: 0x0154651B File Offset: 0x0154471B
			public int FilterRuleId { get; set; }

			// Token: 0x1700A21C RID: 41500
			// (get) Token: 0x0604F852 RID: 325714 RVA: 0x01546524 File Offset: 0x01544724
			// (set) Token: 0x0604F853 RID: 325715 RVA: 0x0154652C File Offset: 0x0154472C
			public int Value { get; set; }

			// Token: 0x1700A21D RID: 41501
			// (get) Token: 0x0604F854 RID: 325716 RVA: 0x01546535 File Offset: 0x01544735
			// (set) Token: 0x0604F855 RID: 325717 RVA: 0x0154653D File Offset: 0x0154473D
			public string IconPath { get; set; }

			// Token: 0x1700A21E RID: 41502
			// (get) Token: 0x0604F856 RID: 325718 RVA: 0x01546546 File Offset: 0x01544746
			// (set) Token: 0x0604F857 RID: 325719 RVA: 0x0154654E File Offset: 0x0154474E
			public string Name { get; set; }
		}
	}
}
