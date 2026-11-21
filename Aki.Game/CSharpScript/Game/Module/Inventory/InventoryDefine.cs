using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using FilterDefine;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02004809 RID: 18441
	[NullableContext(1)]
	[Nullable(0)]
	public class InventoryDefine
	{
		// Token: 0x04018A87 RID: 100999
		public const int CONFIG_ID = 1;

		// Token: 0x04018A88 RID: 101000
		public const int LEVEL = 2;

		// Token: 0x04018A89 RID: 101001
		public const int QUALITY_ID = 3;

		// Token: 0x04018A8A RID: 101002
		public const int COUNT = 4;

		// Token: 0x04018A8B RID: 101003
		public const int SORT_INDEX = 5;

		// Token: 0x04018A8C RID: 101004
		public const int UNIQUE_ID = 6;

		// Token: 0x04018A8D RID: 101005
		public const int COMMON_COIN = 2;

		// Token: 0x04018A8E RID: 101006
		public const int ADVANCED_COIN = 3;

		// Token: 0x04018A8F RID: 101007
		public const int WAVEPLATE_COIN = 5;

		// Token: 0x04018A90 RID: 101008
		public const int WAVEPLATE_CRYSTAL_COIN = 6;

		// Token: 0x04018A91 RID: 101009
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

		// Token: 0x04018A92 RID: 101010
		[StaticVariableRuleIgnore]
		public static readonly int[] weaponIdRange = new int[]
		{
			20000000,
			29999999
		};

		// Token: 0x04018A93 RID: 101011
		[StaticVariableRuleIgnore]
		public static readonly int[] phantomIdRange = new int[]
		{
			60000000,
			60999999
		};

		// Token: 0x04018A94 RID: 101012
		[StaticVariableRuleIgnore]
		public static readonly int[] phantomSpecificIdRange = new int[]
		{
			69000000,
			69999999
		};

		// Token: 0x04018A95 RID: 101013
		[StaticVariableRuleIgnore]
		public static readonly int[] roleIdRange = new int[]
		{
			1000,
			2999
		};

		// Token: 0x04018A96 RID: 101014
		[StaticVariableRuleIgnore]
		public static readonly int[] virtualIdRange = new int[]
		{
			1,
			999
		};

		// Token: 0x04018A97 RID: 101015
		[StaticVariableRuleIgnore]
		public static readonly int[] cardIdRange = new int[]
		{
			80060000,
			80069999
		};

		// Token: 0x04018A98 RID: 101016
		[StaticVariableRuleIgnore]
		public static readonly int[] previewItemIdRange = new int[]
		{
			30000,
			39999
		};

		// Token: 0x04018A99 RID: 101017
		[StaticVariableRuleIgnore]
		public static readonly int[] rogueCurrencyIdRange = new int[]
		{
			80100000,
			80100099
		};

		// Token: 0x04018A9A RID: 101018
		[StaticVariableRuleIgnore]
		public static readonly int[] rogueResCurrencyIdRange = new int[]
		{
			80100100,
			80109999
		};

		// Token: 0x04018A9B RID: 101019
		[StaticVariableRuleIgnore]
		public static readonly int[] weaponSkinIdRange = new int[]
		{
			80080000,
			80089999
		};

		// Token: 0x04018A9C RID: 101020
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatDialogItemRange = new int[]
		{
			80810000,
			80819999
		};

		// Token: 0x04018A9D RID: 101021
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatBackGroundItemRange = new int[]
		{
			80820000,
			80829999
		};

		// Token: 0x04018A9E RID: 101022
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatThemeItemRange = new int[]
		{
			80891001,
			80891999
		};

		// Token: 0x04018A9F RID: 101023
		[StaticVariableRuleIgnore]
		public static readonly int[] PhoneChatCharmItemRange = new int[]
		{
			80892001,
			80892999
		};

		// Token: 0x04018AA0 RID: 101024
		[StaticVariableRuleIgnore]
		public static readonly int[] roleSkinIdRange = new int[]
		{
			81000000,
			81999999
		};

		// Token: 0x04018AA1 RID: 101025
		[StaticVariableRuleIgnore]
		public static readonly int[] playerHeadRange = new int[]
		{
			82000000,
			82999999
		};

		// Token: 0x04018AA2 RID: 101026
		[StaticVariableRuleIgnore]
		public static readonly int[] playerTitleRange = new int[]
		{
			82000000,
			82999999
		};

		// Token: 0x04018AA3 RID: 101027
		[StaticVariableRuleIgnore]
		public static readonly int[] DangoAbyssItemRange = new int[]
		{
			83000000,
			83999999
		};

		// Token: 0x04018AA4 RID: 101028
		[StaticVariableRuleIgnore]
		public static readonly int[] flySkinIdRange = new int[]
		{
			84000000,
			84999999
		};

		// Token: 0x04018AA5 RID: 101029
		[StaticVariableRuleIgnore]
		public static readonly int[] calabashSkinIdRange = new int[]
		{
			86000000,
			86099999
		};

		// Token: 0x04018AA6 RID: 101030
		[StaticVariableRuleIgnore]
		public static readonly int[] InfrastructureItemRange = new int[]
		{
			86100000,
			86199999
		};

		// Token: 0x04018AA7 RID: 101031
		[StaticVariableRuleIgnore]
		public static readonly int[] PhantomArenaCardItemRange = new int[]
		{
			700000,
			750000
		};

		// Token: 0x04018AA8 RID: 101032
		[StaticVariableRuleIgnore]
		public static readonly int[] PhantomArenaBadgeItemRange = new int[]
		{
			75001,
			80000
		};

		// Token: 0x04018AA9 RID: 101033
		[StaticVariableRuleIgnore]
		public static readonly int[] HonamiStoryItemRange = new int[]
		{
			87000000,
			87999999
		};

		// Token: 0x04018AAA RID: 101034
		[StaticVariableRuleIgnore]
		public static readonly int[] HonamiStoryWeaponRange = new int[]
		{
			88000000,
			88999999
		};

		// Token: 0x04018AAB RID: 101035
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorFrameItemRange = new int[]
		{
			89400000,
			89499999
		};

		// Token: 0x04018AAC RID: 101036
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorStickerItemRange = new int[]
		{
			89100000,
			89199999
		};

		// Token: 0x04018AAD RID: 101037
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorDecorationItemRange = new int[]
		{
			89300000,
			89399999
		};

		// Token: 0x04018AAE RID: 101038
		[StaticVariableRuleIgnore]
		public static readonly int[] MotorSkinItemRange = new int[]
		{
			89200000,
			89299999
		};

		// Token: 0x04018AAF RID: 101039
		[StaticVariableRuleIgnore]
		public static readonly int[] FurnitureItemRange = new int[]
		{
			80830001,
			80839999
		};

		// Token: 0x04018AB0 RID: 101040
		[StaticVariableRuleIgnore]
		public static readonly int[] OrnamentItemRange = new int[]
		{
			80870001,
			80879999
		};

		// Token: 0x04018AB1 RID: 101041
		[StaticVariableRuleIgnore]
		public static readonly int[] PinballRoleItemRange = new int[]
		{
			80850001,
			80859999
		};

		// Token: 0x04018AB2 RID: 101042
		[StaticVariableRuleIgnore]
		public static readonly int[] PinballWeaponItemRange = new int[]
		{
			80860001,
			80869999
		};

		// Token: 0x04018AB3 RID: 101043
		[StaticVariableRuleIgnore]
		public static readonly int[] roverRogueCurrencyIdRange = new int[]
		{
			89000000,
			89000099
		};

		// Token: 0x04018AB4 RID: 101044
		[StaticVariableRuleIgnore]
		public static readonly int[] dangoBrawlRoleIdRange = new int[]
		{
			80700016,
			80700040
		};

		// Token: 0x04018AB5 RID: 101045
		public const int MANAGE_CONFIG_FUNCTION_ID = 10096;

		// Token: 0x04018AB6 RID: 101046
		public const int MANAGE_CONFIG_HELP_ID = 356;

		// Token: 0x04018AB7 RID: 101047
		public const string EMPTY_CONFIG_TEXT_ID = "PhantomProject_EmptyProject";

		// Token: 0x04018AB8 RID: 101048
		public const string EMPTY_RULE_TEXT_ID = "PhantomProject_EmptyChose";

		// Token: 0x04018AB9 RID: 101049
		public const string EMPTY_CHECK_TEXT_ID = "PhantomProject_Tips02";

		// Token: 0x04018ABA RID: 101050
		public const int MANAGE_CONFIG_MAX_COUNT = 10;

		// Token: 0x0200A448 RID: 42056
		[NullableContext(0)]
		public enum EItemMainTypeId
		{
			// Token: 0x04032E53 RID: 208467
			Virtual,
			// Token: 0x04032E54 RID: 208468
			Common,
			// Token: 0x04032E55 RID: 208469
			Weapon,
			// Token: 0x04032E56 RID: 208470
			Phantom,
			// Token: 0x04032E57 RID: 208471
			Collection,
			// Token: 0x04032E58 RID: 208472
			Material,
			// Token: 0x04032E59 RID: 208473
			Mission,
			// Token: 0x04032E5A RID: 208474
			Special,
			// Token: 0x04032E5B RID: 208475
			Card,
			// Token: 0x04032E5C RID: 208476
			DangoPluginItem,
			// Token: 0x04032E5D RID: 208477
			PinballWeapon
		}

		// Token: 0x0200A449 RID: 42057
		[NullableContext(0)]
		public enum EItemType
		{
			// Token: 0x04032E5F RID: 208479
			Virtual,
			// Token: 0x04032E60 RID: 208480
			Common,
			// Token: 0x04032E61 RID: 208481
			Weapon,
			// Token: 0x04032E62 RID: 208482
			WeaponMaterial = 4,
			// Token: 0x04032E63 RID: 208483
			Task = 7,
			// Token: 0x04032E64 RID: 208484
			Phantom = 9,
			// Token: 0x04032E65 RID: 208485
			Gift = 11,
			// Token: 0x04032E66 RID: 208486
			SpecialItem = 13,
			// Token: 0x04032E67 RID: 208487
			Card,
			// Token: 0x04032E68 RID: 208488
			RogueCurrency,
			// Token: 0x04032E69 RID: 208489
			WeaponSkin = 18,
			// Token: 0x04032E6A RID: 208490
			RoleSkin,
			// Token: 0x04032E6B RID: 208491
			RecallActivityScore,
			// Token: 0x04032E6C RID: 208492
			PlayerHead,
			// Token: 0x04032E6D RID: 208493
			PlayerTitle,
			// Token: 0x04032E6E RID: 208494
			FlySkin = 24,
			// Token: 0x04032E6F RID: 208495
			HonamiStoryItem = 28,
			// Token: 0x04032E70 RID: 208496
			HonamiStoryWeapon,
			// Token: 0x04032E71 RID: 208497
			MotorSticker,
			// Token: 0x04032E72 RID: 208498
			MotorDecoration,
			// Token: 0x04032E73 RID: 208499
			MotorFrame,
			// Token: 0x04032E74 RID: 208500
			MotorSkin,
			// Token: 0x04032E75 RID: 208501
			Ornament = 35,
			// Token: 0x04032E76 RID: 208502
			PinballWeapon,
			// Token: 0x04032E77 RID: 208503
			PinballRole,
			// Token: 0x04032E78 RID: 208504
			DangoBrawlRole = 43,
			// Token: 0x04032E79 RID: 208505
			CookMenu = 60000,
			// Token: 0x04032E7A RID: 208506
			CookFood,
			// Token: 0x04032E7B RID: 208507
			ForgingFormula,
			// Token: 0x04032E7C RID: 208508
			ComposeFormula,
			// Token: 0x04032E7D RID: 208509
			Phonograph,
			// Token: 0x04032E7E RID: 208510
			ShipTowerBuff,
			// Token: 0x04032E7F RID: 208511
			AbyssItem,
			// Token: 0x04032E80 RID: 208512
			BirthdayItem,
			// Token: 0x04032E81 RID: 208513
			PayShopCoupon,
			// Token: 0x04032E82 RID: 208514
			PhantomArenaCard,
			// Token: 0x04032E83 RID: 208515
			PhantomArenaBadge,
			// Token: 0x04032E84 RID: 208516
			CalabashSkin = 60015,
			// Token: 0x04032E85 RID: 208517
			InfrastructureItem,
			// Token: 0x04032E86 RID: 208518
			PhoneChatDialog,
			// Token: 0x04032E87 RID: 208519
			PhoneChatBackGround,
			// Token: 0x04032E88 RID: 208520
			Furniture,
			// Token: 0x04032E89 RID: 208521
			PhoneChatTheme,
			// Token: 0x04032E8A RID: 208522
			PhoneChatCharm
		}

		// Token: 0x0200A44A RID: 42058
		[NullableContext(0)]
		public enum EItemInfoDisplayType
		{
			// Token: 0x04032E8C RID: 208524
			StackCount,
			// Token: 0x04032E8D RID: 208525
			Level
		}

		// Token: 0x0200A44B RID: 42059
		[NullableContext(0)]
		public enum EItemDataFunctionType
		{
			// Token: 0x04032E8F RID: 208527
			Lock,
			// Token: 0x04032E90 RID: 208528
			Deprecate
		}

		// Token: 0x0200A44C RID: 42060
		[NullableContext(0)]
		public enum EItemDataType
		{
			// Token: 0x04032E92 RID: 208530
			CommonItem,
			// Token: 0x04032E93 RID: 208531
			RoleItem,
			// Token: 0x04032E94 RID: 208532
			WeaponItem,
			// Token: 0x04032E95 RID: 208533
			PhantomItem,
			// Token: 0x04032E96 RID: 208534
			PhantomCustomize,
			// Token: 0x04032E97 RID: 208535
			VirtualItem,
			// Token: 0x04032E98 RID: 208536
			CardItem,
			// Token: 0x04032E99 RID: 208537
			PreviewItem,
			// Token: 0x04032E9A RID: 208538
			RogueCurrency,
			// Token: 0x04032E9B RID: 208539
			RogueResCurrency,
			// Token: 0x04032E9C RID: 208540
			WeaponSkinItem,
			// Token: 0x04032E9D RID: 208541
			RoleSkinItem,
			// Token: 0x04032E9E RID: 208542
			PlayerHeadItem,
			// Token: 0x04032E9F RID: 208543
			DangoAbyssItem,
			// Token: 0x04032EA0 RID: 208544
			FlySkinItem,
			// Token: 0x04032EA1 RID: 208545
			PhantomArenaCard,
			// Token: 0x04032EA2 RID: 208546
			PhantomArenaBadge,
			// Token: 0x04032EA3 RID: 208547
			HonamiStoryItem,
			// Token: 0x04032EA4 RID: 208548
			CalabashSkinItem,
			// Token: 0x04032EA5 RID: 208549
			HonamiStoryWeapon,
			// Token: 0x04032EA6 RID: 208550
			InfrastructureItem,
			// Token: 0x04032EA7 RID: 208551
			MotorStickerItem,
			// Token: 0x04032EA8 RID: 208552
			PhoneChatDialog,
			// Token: 0x04032EA9 RID: 208553
			PhoneChatBackGround,
			// Token: 0x04032EAA RID: 208554
			PhoneChatTheme,
			// Token: 0x04032EAB RID: 208555
			PhoneChatCharm,
			// Token: 0x04032EAC RID: 208556
			FurnitureItem,
			// Token: 0x04032EAD RID: 208557
			MotorFrameItem,
			// Token: 0x04032EAE RID: 208558
			MotorDecorationItem,
			// Token: 0x04032EAF RID: 208559
			MotorSkinItem,
			// Token: 0x04032EB0 RID: 208560
			OrnamentItem,
			// Token: 0x04032EB1 RID: 208561
			PinballRoleItem,
			// Token: 0x04032EB2 RID: 208562
			PinballWeaponItem,
			// Token: 0x04032EB3 RID: 208563
			RoverRogueCurrency,
			// Token: 0x04032EB4 RID: 208564
			DangoBrawlRoleItem
		}

		// Token: 0x0200A44D RID: 42061
		public interface IItemViewDataInfo
		{
			// Token: 0x1700795E RID: 31070
			// (get) Token: 0x06045D21 RID: 285985
			// (set) Token: 0x06045D22 RID: 285986
			int ConfigId { get; set; }

			// Token: 0x1700795F RID: 31071
			// (get) Token: 0x06045D23 RID: 285987
			// (set) Token: 0x06045D24 RID: 285988
			int Count { get; set; }

			// Token: 0x17007960 RID: 31072
			// (get) Token: 0x06045D25 RID: 285989
			// (set) Token: 0x06045D26 RID: 285990
			int StackId { get; set; }

			// Token: 0x17007961 RID: 31073
			// (get) Token: 0x06045D27 RID: 285991
			// (set) Token: 0x06045D28 RID: 285992
			int QualityId { get; set; }

			// Token: 0x17007962 RID: 31074
			// (get) Token: 0x06045D29 RID: 285993
			// (set) Token: 0x06045D2A RID: 285994
			bool IsLock { get; set; }

			// Token: 0x17007963 RID: 31075
			// (get) Token: 0x06045D2B RID: 285995
			// (set) Token: 0x06045D2C RID: 285996
			bool IsDeprecate { get; set; }

			// Token: 0x17007964 RID: 31076
			// (get) Token: 0x06045D2D RID: 285997
			// (set) Token: 0x06045D2E RID: 285998
			bool IsNewItem { get; set; }

			// Token: 0x17007965 RID: 31077
			// (get) Token: 0x06045D2F RID: 285999
			// (set) Token: 0x06045D30 RID: 286000
			InventoryDefine.EItemDataType ItemDataType { get; set; }

			// Token: 0x17007966 RID: 31078
			// (get) Token: 0x06045D31 RID: 286001
			// (set) Token: 0x06045D32 RID: 286002
			ItemDataBase ItemDataBase { get; set; }

			// Token: 0x17007967 RID: 31079
			// (get) Token: 0x06045D33 RID: 286003
			// (set) Token: 0x06045D34 RID: 286004
			bool HasRedDot { get; set; }

			// Token: 0x17007968 RID: 31080
			// (get) Token: 0x06045D35 RID: 286005
			// (set) Token: 0x06045D36 RID: 286006
			ItemViewDefine.EItemOperationMode ItemOperationMode { get; set; }

			// Token: 0x17007969 RID: 31081
			// (get) Token: 0x06045D37 RID: 286007
			// (set) Token: 0x06045D38 RID: 286008
			bool IsSelectOn { get; set; }

			// Token: 0x1700796A RID: 31082
			// (get) Token: 0x06045D39 RID: 286009
			// (set) Token: 0x06045D3A RID: 286010
			int SelectOnNum { get; set; }
		}

		// Token: 0x0200A44E RID: 42062
		[Nullable(0)]
		public class ItemViewDataInfo : InventoryDefine.IItemViewDataInfo
		{
			// Token: 0x06045D3B RID: 286011 RVA: 0x014FF4F0 File Offset: 0x014FD6F0
			public ItemViewDataInfo(int configId, int count, int stackId, int qualityId, bool isLock, bool isDeprecate, bool isNewItem, InventoryDefine.EItemDataType itemDataType, ItemDataBase itemDataBase, bool hasRedDot, ItemViewDefine.EItemOperationMode itemOperationMode, bool isSelectOn, int selectOnNum)
			{
			}

			// Token: 0x1700796B RID: 31083
			// (get) Token: 0x06045D3C RID: 286012 RVA: 0x014FF568 File Offset: 0x014FD768
			// (set) Token: 0x06045D3D RID: 286013 RVA: 0x014FF570 File Offset: 0x014FD770
			public int ConfigId { get; set; } = configId;

			// Token: 0x1700796C RID: 31084
			// (get) Token: 0x06045D3E RID: 286014 RVA: 0x014FF579 File Offset: 0x014FD779
			// (set) Token: 0x06045D3F RID: 286015 RVA: 0x014FF581 File Offset: 0x014FD781
			public int Count { get; set; } = count;

			// Token: 0x1700796D RID: 31085
			// (get) Token: 0x06045D40 RID: 286016 RVA: 0x014FF58A File Offset: 0x014FD78A
			// (set) Token: 0x06045D41 RID: 286017 RVA: 0x014FF592 File Offset: 0x014FD792
			public int StackId { get; set; } = stackId;

			// Token: 0x1700796E RID: 31086
			// (get) Token: 0x06045D42 RID: 286018 RVA: 0x014FF59B File Offset: 0x014FD79B
			// (set) Token: 0x06045D43 RID: 286019 RVA: 0x014FF5A3 File Offset: 0x014FD7A3
			public int QualityId { get; set; } = qualityId;

			// Token: 0x1700796F RID: 31087
			// (get) Token: 0x06045D44 RID: 286020 RVA: 0x014FF5AC File Offset: 0x014FD7AC
			// (set) Token: 0x06045D45 RID: 286021 RVA: 0x014FF5B4 File Offset: 0x014FD7B4
			public bool IsLock { get; set; } = isLock;

			// Token: 0x17007970 RID: 31088
			// (get) Token: 0x06045D46 RID: 286022 RVA: 0x014FF5BD File Offset: 0x014FD7BD
			// (set) Token: 0x06045D47 RID: 286023 RVA: 0x014FF5C5 File Offset: 0x014FD7C5
			public bool IsDeprecate { get; set; } = isDeprecate;

			// Token: 0x17007971 RID: 31089
			// (get) Token: 0x06045D48 RID: 286024 RVA: 0x014FF5CE File Offset: 0x014FD7CE
			// (set) Token: 0x06045D49 RID: 286025 RVA: 0x014FF5D6 File Offset: 0x014FD7D6
			public bool IsNewItem { get; set; } = isNewItem;

			// Token: 0x17007972 RID: 31090
			// (get) Token: 0x06045D4A RID: 286026 RVA: 0x014FF5DF File Offset: 0x014FD7DF
			// (set) Token: 0x06045D4B RID: 286027 RVA: 0x014FF5E7 File Offset: 0x014FD7E7
			public InventoryDefine.EItemDataType ItemDataType { get; set; } = itemDataType;

			// Token: 0x17007973 RID: 31091
			// (get) Token: 0x06045D4C RID: 286028 RVA: 0x014FF5F0 File Offset: 0x014FD7F0
			// (set) Token: 0x06045D4D RID: 286029 RVA: 0x014FF5F8 File Offset: 0x014FD7F8
			public ItemDataBase ItemDataBase { get; set; } = itemDataBase;

			// Token: 0x17007974 RID: 31092
			// (get) Token: 0x06045D4E RID: 286030 RVA: 0x014FF601 File Offset: 0x014FD801
			// (set) Token: 0x06045D4F RID: 286031 RVA: 0x014FF609 File Offset: 0x014FD809
			public bool HasRedDot { get; set; } = hasRedDot;

			// Token: 0x17007975 RID: 31093
			// (get) Token: 0x06045D50 RID: 286032 RVA: 0x014FF612 File Offset: 0x014FD812
			// (set) Token: 0x06045D51 RID: 286033 RVA: 0x014FF61A File Offset: 0x014FD81A
			public ItemViewDefine.EItemOperationMode ItemOperationMode { get; set; } = itemOperationMode;

			// Token: 0x17007976 RID: 31094
			// (get) Token: 0x06045D52 RID: 286034 RVA: 0x014FF623 File Offset: 0x014FD823
			// (set) Token: 0x06045D53 RID: 286035 RVA: 0x014FF62B File Offset: 0x014FD82B
			public bool IsSelectOn { get; set; } = isSelectOn;

			// Token: 0x17007977 RID: 31095
			// (get) Token: 0x06045D54 RID: 286036 RVA: 0x014FF634 File Offset: 0x014FD834
			// (set) Token: 0x06045D55 RID: 286037 RVA: 0x014FF63C File Offset: 0x014FD83C
			public int SelectOnNum { get; set; } = selectOnNum;
		}

		// Token: 0x0200A44F RID: 42063
		public interface IPublicItemConfig
		{
			// Token: 0x17007978 RID: 31096
			// (get) Token: 0x06045D56 RID: 286038
			// (set) Token: 0x06045D57 RID: 286039
			int TypeDescription { get; set; }

			// Token: 0x17007979 RID: 31097
			// (get) Token: 0x06045D58 RID: 286040
			// (set) Token: 0x06045D59 RID: 286041
			int AttributesDescription { get; set; }

			// Token: 0x1700797A RID: 31098
			// (get) Token: 0x06045D5A RID: 286042
			// (set) Token: 0x06045D5B RID: 286043
			int BgDescription { get; set; }

			// Token: 0x1700797B RID: 31099
			// (get) Token: 0x06045D5C RID: 286044
			// (set) Token: 0x06045D5D RID: 286045
			string Icon { get; set; }

			// Token: 0x1700797C RID: 31100
			// (get) Token: 0x06045D5E RID: 286046
			// (set) Token: 0x06045D5F RID: 286047
			int QualityId { get; set; }

			// Token: 0x1700797D RID: 31101
			// (get) Token: 0x06045D60 RID: 286048
			// (set) Token: 0x06045D61 RID: 286049
			int MaxCapcity { get; set; }

			// Token: 0x1700797E RID: 31102
			// (get) Token: 0x06045D62 RID: 286050
			// (set) Token: 0x06045D63 RID: 286051
			int[] ItemAccess { get; set; }

			// Token: 0x1700797F RID: 31103
			// (get) Token: 0x06045D64 RID: 286052
			// (set) Token: 0x06045D65 RID: 286053
			string Mesh { get; set; }
		}

		// Token: 0x0200A450 RID: 42064
		public interface IGetItemData
		{
			// Token: 0x17007980 RID: 31104
			// (get) Token: 0x06045D66 RID: 286054
			// (set) Token: 0x06045D67 RID: 286055
			int ItemId { get; set; }

			// Token: 0x17007981 RID: 31105
			// (get) Token: 0x06045D68 RID: 286056
			// (set) Token: 0x06045D69 RID: 286057
			int IncId { get; set; }
		}

		// Token: 0x0200A451 RID: 42065
		[NullableContext(0)]
		public class GetItemData : InventoryDefine.IGetItemData
		{
			// Token: 0x06045D6A RID: 286058 RVA: 0x014FF645 File Offset: 0x014FD845
			public GetItemData(int itemId, int incId)
			{
			}

			// Token: 0x17007982 RID: 31106
			// (get) Token: 0x06045D6B RID: 286059 RVA: 0x014FF65B File Offset: 0x014FD85B
			// (set) Token: 0x06045D6C RID: 286060 RVA: 0x014FF663 File Offset: 0x014FD863
			public int ItemId { get; set; } = itemId;

			// Token: 0x17007983 RID: 31107
			// (get) Token: 0x06045D6D RID: 286061 RVA: 0x014FF66C File Offset: 0x014FD86C
			// (set) Token: 0x06045D6E RID: 286062 RVA: 0x014FF674 File Offset: 0x014FD874
			public int IncId { get; set; } = incId;
		}

		// Token: 0x0200A452 RID: 42066
		[NullableContext(0)]
		public enum EUseType
		{
			// Token: 0x04032EC5 RID: 208581
			OpenGiftPack = 2,
			// Token: 0x04032EC6 RID: 208582
			AddTeamExpAuto,
			// Token: 0x04032EC7 RID: 208583
			OpenGiftPackAuto,
			// Token: 0x04032EC8 RID: 208584
			AddRoleAuto,
			// Token: 0x04032EC9 RID: 208585
			CostItem,
			// Token: 0x04032ECA RID: 208586
			AddVisionSkillAuto = 8,
			// Token: 0x04032ECB RID: 208587
			AddEnergy,
			// Token: 0x04032ECC RID: 208588
			AddPropRewardAuto,
			// Token: 0x04032ECD RID: 208589
			AddRoleFavorAuto,
			// Token: 0x04032ECE RID: 208590
			ForInfoDisplay
		}

		// Token: 0x0200A453 RID: 42067
		[NullableContext(0)]
		public enum EShowType
		{
			// Token: 0x04032ED0 RID: 208592
			Exp = 1,
			// Token: 0x04032ED1 RID: 208593
			NormalCoin,
			// Token: 0x04032ED2 RID: 208594
			SeniorCoin,
			// Token: 0x04032ED3 RID: 208595
			SuperCoin,
			// Token: 0x04032ED4 RID: 208596
			Power,
			// Token: 0x04032ED5 RID: 208597
			CultivateMaterial,
			// Token: 0x04032ED6 RID: 208598
			RoleBreachMaterial,
			// Token: 0x04032ED7 RID: 208599
			SkillUpgradeMaterial,
			// Token: 0x04032ED8 RID: 208600
			Material,
			// Token: 0x04032ED9 RID: 208601
			Consumable,
			// Token: 0x04032EDA RID: 208602
			RoleExpMaterial,
			// Token: 0x04032EDB RID: 208603
			WeaponExpMaterial,
			// Token: 0x04032EDC RID: 208604
			WeaponBreachMaterial,
			// Token: 0x04032EDD RID: 208605
			ResonanceAmplificationMaterial,
			// Token: 0x04032EDE RID: 208606
			ExchangeCoin,
			// Token: 0x04032EDF RID: 208607
			PropBag,
			// Token: 0x04032EE0 RID: 208608
			TuningProve,
			// Token: 0x04032EE1 RID: 208609
			TuningExchangeCoin,
			// Token: 0x04032EE2 RID: 208610
			MonthlyTicket,
			// Token: 0x04032EE3 RID: 208611
			Supply,
			// Token: 0x04032EE4 RID: 208612
			TaskItem,
			// Token: 0x04032EE5 RID: 208613
			PhantomExpMaterial,
			// Token: 0x04032EE6 RID: 208614
			CookFinishedProduct,
			// Token: 0x04032EE7 RID: 208615
			CookMenu,
			// Token: 0x04032EE8 RID: 208616
			MachiningProduct,
			// Token: 0x04032EE9 RID: 208617
			CookMaterial,
			// Token: 0x04032EEA RID: 208618
			Favorability,
			// Token: 0x04032EEB RID: 208619
			PowerPrestige,
			// Token: 0x04032EEC RID: 208620
			Fragment,
			// Token: 0x04032EED RID: 208621
			RoleCallback,
			// Token: 0x04032EEE RID: 208622
			CookSell,
			// Token: 0x04032EEF RID: 208623
			ChangeStar,
			// Token: 0x04032EF0 RID: 208624
			LevelItem,
			// Token: 0x04032EF1 RID: 208625
			ForgingMenu,
			// Token: 0x04032EF2 RID: 208626
			ComposeMenu,
			// Token: 0x04032EF3 RID: 208627
			ComposeProduct,
			// Token: 0x04032EF4 RID: 208628
			ComposeStructure,
			// Token: 0x04032EF5 RID: 208629
			ComposeStructureProduct,
			// Token: 0x04032EF6 RID: 208630
			RandomPhantomItem = 41,
			// Token: 0x04032EF7 RID: 208631
			Modifier = 54,
			// Token: 0x04032EF8 RID: 208632
			ModifierSub = 58,
			// Token: 0x04032EF9 RID: 208633
			ResonantSelectItem = 62
		}

		// Token: 0x0200A454 RID: 42068
		[NullableContext(0)]
		public enum ERedDotDisableRule
		{
			// Token: 0x04032EFB RID: 208635
			None,
			// Token: 0x04032EFC RID: 208636
			AfterSelect,
			// Token: 0x04032EFD RID: 208637
			AfterUse,
			// Token: 0x04032EFE RID: 208638
			ServerFirstSelect
		}

		// Token: 0x0200A455 RID: 42069
		[NullableContext(0)]
		public enum EQuality
		{
			// Token: 0x04032F00 RID: 208640
			White = 1,
			// Token: 0x04032F01 RID: 208641
			Green,
			// Token: 0x04032F02 RID: 208642
			Blue,
			// Token: 0x04032F03 RID: 208643
			Purple,
			// Token: 0x04032F04 RID: 208644
			Orange
		}

		// Token: 0x0200A456 RID: 42070
		[NullableContext(0)]
		public enum EItemDataFunctionValue
		{
			// Token: 0x04032F06 RID: 208646
			Default,
			// Token: 0x04032F07 RID: 208647
			Lock,
			// Token: 0x04032F08 RID: 208648
			Deprecate
		}

		// Token: 0x0200A457 RID: 42071
		public interface IManageConfigTypeItemData
		{
			// Token: 0x17007984 RID: 31108
			// (get) Token: 0x06045D6F RID: 286063
			// (set) Token: 0x06045D70 RID: 286064
			PhantomSettingType Type { get; set; }

			// Token: 0x17007985 RID: 31109
			// (get) Token: 0x06045D71 RID: 286065
			// (set) Token: 0x06045D72 RID: 286066
			string Name { get; set; }
		}

		// Token: 0x0200A458 RID: 42072
		[Nullable(0)]
		public class ManageConfigTypeItemData : InventoryDefine.IManageConfigTypeItemData
		{
			// Token: 0x17007986 RID: 31110
			// (get) Token: 0x06045D73 RID: 286067 RVA: 0x014FF67D File Offset: 0x014FD87D
			// (set) Token: 0x06045D74 RID: 286068 RVA: 0x014FF685 File Offset: 0x014FD885
			public PhantomSettingType Type { get; set; } = PhantomSettingType.AutoDisuse;

			// Token: 0x17007987 RID: 31111
			// (get) Token: 0x06045D75 RID: 286069 RVA: 0x014FF68E File Offset: 0x014FD88E
			// (set) Token: 0x06045D76 RID: 286070 RVA: 0x014FF696 File Offset: 0x014FD896
			public string Name { get; set; } = "";
		}

		// Token: 0x0200A459 RID: 42073
		[NullableContext(0)]
		public enum ESettingGridType
		{
			// Token: 0x04032F0C RID: 208652
			Small = 1,
			// Token: 0x04032F0D RID: 208653
			Big
		}

		// Token: 0x0200A45A RID: 42074
		public interface IManageConfigTitleItemData
		{
			// Token: 0x17007988 RID: 31112
			// (get) Token: 0x06045D78 RID: 286072
			// (set) Token: 0x06045D79 RID: 286073
			int FilterId { get; set; }

			// Token: 0x17007989 RID: 31113
			// (get) Token: 0x06045D7A RID: 286074
			// (set) Token: 0x06045D7B RID: 286075
			int FilterRuleId { get; set; }
		}

		// Token: 0x0200A45B RID: 42075
		[NullableContext(0)]
		public class ManageConfigTitleItemData : InventoryDefine.IManageConfigTitleItemData
		{
			// Token: 0x1700798A RID: 31114
			// (get) Token: 0x06045D7C RID: 286076 RVA: 0x014FF6B9 File Offset: 0x014FD8B9
			// (set) Token: 0x06045D7D RID: 286077 RVA: 0x014FF6C1 File Offset: 0x014FD8C1
			public int FilterId { get; set; }

			// Token: 0x1700798B RID: 31115
			// (get) Token: 0x06045D7E RID: 286078 RVA: 0x014FF6CA File Offset: 0x014FD8CA
			// (set) Token: 0x06045D7F RID: 286079 RVA: 0x014FF6D2 File Offset: 0x014FD8D2
			public int FilterRuleId { get; set; }
		}

		// Token: 0x0200A45C RID: 42076
		public interface IManageConfigSettingGridData
		{
			// Token: 0x1700798C RID: 31116
			// (get) Token: 0x06045D81 RID: 286081
			// (set) Token: 0x06045D82 RID: 286082
			bool IsFirst { get; set; }

			// Token: 0x1700798D RID: 31117
			// (get) Token: 0x06045D83 RID: 286083
			// (set) Token: 0x06045D84 RID: 286084
			bool IsEmpty { get; set; }

			// Token: 0x1700798E RID: 31118
			// (get) Token: 0x06045D85 RID: 286085
			// (set) Token: 0x06045D86 RID: 286086
			bool IsAdd { get; set; }

			// Token: 0x1700798F RID: 31119
			// (get) Token: 0x06045D87 RID: 286087
			// (set) Token: 0x06045D88 RID: 286088
			bool IsSelect { get; set; }

			// Token: 0x17007990 RID: 31120
			// (get) Token: 0x06045D89 RID: 286089
			// (set) Token: 0x06045D8A RID: 286090
			bool IsEditing { get; set; }

			// Token: 0x17007991 RID: 31121
			// (get) Token: 0x06045D8B RID: 286091
			// (set) Token: 0x06045D8C RID: 286092
			int RuleId { get; set; }

			// Token: 0x17007992 RID: 31122
			// (get) Token: 0x06045D8D RID: 286093
			// (set) Token: 0x06045D8E RID: 286094
			int Value { get; set; }
		}

		// Token: 0x0200A45D RID: 42077
		[NullableContext(0)]
		public class ManageConfigSettingGridData : InventoryDefine.IManageConfigSettingGridData
		{
			// Token: 0x17007993 RID: 31123
			// (get) Token: 0x06045D8F RID: 286095 RVA: 0x014FF6E3 File Offset: 0x014FD8E3
			// (set) Token: 0x06045D90 RID: 286096 RVA: 0x014FF6EB File Offset: 0x014FD8EB
			public bool IsFirst { get; set; }

			// Token: 0x17007994 RID: 31124
			// (get) Token: 0x06045D91 RID: 286097 RVA: 0x014FF6F4 File Offset: 0x014FD8F4
			// (set) Token: 0x06045D92 RID: 286098 RVA: 0x014FF6FC File Offset: 0x014FD8FC
			public bool IsEmpty { get; set; }

			// Token: 0x17007995 RID: 31125
			// (get) Token: 0x06045D93 RID: 286099 RVA: 0x014FF705 File Offset: 0x014FD905
			// (set) Token: 0x06045D94 RID: 286100 RVA: 0x014FF70D File Offset: 0x014FD90D
			public bool IsAdd { get; set; }

			// Token: 0x17007996 RID: 31126
			// (get) Token: 0x06045D95 RID: 286101 RVA: 0x014FF716 File Offset: 0x014FD916
			// (set) Token: 0x06045D96 RID: 286102 RVA: 0x014FF71E File Offset: 0x014FD91E
			public bool IsSelect { get; set; }

			// Token: 0x17007997 RID: 31127
			// (get) Token: 0x06045D97 RID: 286103 RVA: 0x014FF727 File Offset: 0x014FD927
			// (set) Token: 0x06045D98 RID: 286104 RVA: 0x014FF72F File Offset: 0x014FD92F
			public bool IsEditing { get; set; }

			// Token: 0x17007998 RID: 31128
			// (get) Token: 0x06045D99 RID: 286105 RVA: 0x014FF738 File Offset: 0x014FD938
			// (set) Token: 0x06045D9A RID: 286106 RVA: 0x014FF740 File Offset: 0x014FD940
			public int RuleId { get; set; }

			// Token: 0x17007999 RID: 31129
			// (get) Token: 0x06045D9B RID: 286107 RVA: 0x014FF749 File Offset: 0x014FD949
			// (set) Token: 0x06045D9C RID: 286108 RVA: 0x014FF751 File Offset: 0x014FD951
			public int Value { get; set; }
		}

		// Token: 0x0200A45E RID: 42078
		public interface ISelectViewData
		{
			// Token: 0x1700799A RID: 31130
			// (get) Token: 0x06045D9E RID: 286110
			// (set) Token: 0x06045D9F RID: 286111
			string GridType { get; set; }

			// Token: 0x1700799B RID: 31131
			// (get) Token: 0x06045DA0 RID: 286112
			// (set) Token: 0x06045DA1 RID: 286113
			int FilterId { get; set; }

			// Token: 0x1700799C RID: 31132
			// (get) Token: 0x06045DA2 RID: 286114
			// (set) Token: 0x06045DA3 RID: 286115
			int[] RuleIdList { get; set; }

			// Token: 0x1700799D RID: 31133
			// (get) Token: 0x06045DA4 RID: 286116
			// (set) Token: 0x06045DA5 RID: 286117
			Dictionary<int, int[]> ValueMap { get; set; }

			// Token: 0x1700799E RID: 31134
			// (get) Token: 0x06045DA6 RID: 286118
			// (set) Token: 0x06045DA7 RID: 286119
			Action<Dictionary<int, int[]>> CallbackConfirm { get; set; }
		}

		// Token: 0x0200A45F RID: 42079
		[Nullable(0)]
		public class SelectViewData : InventoryDefine.ISelectViewData
		{
			// Token: 0x1700799F RID: 31135
			// (get) Token: 0x06045DA8 RID: 286120 RVA: 0x014FF762 File Offset: 0x014FD962
			// (set) Token: 0x06045DA9 RID: 286121 RVA: 0x014FF76A File Offset: 0x014FD96A
			public string GridType { get; set; } = "";

			// Token: 0x170079A0 RID: 31136
			// (get) Token: 0x06045DAA RID: 286122 RVA: 0x014FF773 File Offset: 0x014FD973
			// (set) Token: 0x06045DAB RID: 286123 RVA: 0x014FF77B File Offset: 0x014FD97B
			public int FilterId { get; set; }

			// Token: 0x170079A1 RID: 31137
			// (get) Token: 0x06045DAC RID: 286124 RVA: 0x014FF784 File Offset: 0x014FD984
			// (set) Token: 0x06045DAD RID: 286125 RVA: 0x014FF78C File Offset: 0x014FD98C
			public int[] RuleIdList { get; set; } = Array.Empty<int>();

			// Token: 0x170079A2 RID: 31138
			// (get) Token: 0x06045DAE RID: 286126 RVA: 0x014FF795 File Offset: 0x014FD995
			// (set) Token: 0x06045DAF RID: 286127 RVA: 0x014FF79D File Offset: 0x014FD99D
			public Dictionary<int, int[]> ValueMap { get; set; } = new Dictionary<int, int[]>();

			// Token: 0x170079A3 RID: 31139
			// (get) Token: 0x06045DB0 RID: 286128 RVA: 0x014FF7A6 File Offset: 0x014FD9A6
			// (set) Token: 0x06045DB1 RID: 286129 RVA: 0x014FF7AE File Offset: 0x014FD9AE
			public Action<Dictionary<int, int[]>> CallbackConfirm { get; set; }
		}

		// Token: 0x0200A460 RID: 42080
		public interface ISelectGroupData
		{
			// Token: 0x170079A4 RID: 31140
			// (get) Token: 0x06045DB3 RID: 286131
			// (set) Token: 0x06045DB4 RID: 286132
			int FilterId { get; set; }

			// Token: 0x170079A5 RID: 31141
			// (get) Token: 0x06045DB5 RID: 286133
			// (set) Token: 0x06045DB6 RID: 286134
			int FilterRuleId { get; set; }

			// Token: 0x170079A6 RID: 31142
			// (get) Token: 0x06045DB7 RID: 286135
			// (set) Token: 0x06045DB8 RID: 286136
			bool HasSelectAll { get; set; }

			// Token: 0x170079A7 RID: 31143
			// (get) Token: 0x06045DB9 RID: 286137
			// (set) Token: 0x06045DBA RID: 286138
			bool NeedChangeColor { get; set; }

			// Token: 0x170079A8 RID: 31144
			// (get) Token: 0x06045DBB RID: 286139
			// (set) Token: 0x06045DBC RID: 286140
			int[] ValueList { get; set; }
		}

		// Token: 0x0200A461 RID: 42081
		[Nullable(0)]
		public class SelectGroupData : InventoryDefine.ISelectGroupData
		{
			// Token: 0x170079A9 RID: 31145
			// (get) Token: 0x06045DBD RID: 286141 RVA: 0x014FF7E0 File Offset: 0x014FD9E0
			// (set) Token: 0x06045DBE RID: 286142 RVA: 0x014FF7E8 File Offset: 0x014FD9E8
			public int FilterId { get; set; }

			// Token: 0x170079AA RID: 31146
			// (get) Token: 0x06045DBF RID: 286143 RVA: 0x014FF7F1 File Offset: 0x014FD9F1
			// (set) Token: 0x06045DC0 RID: 286144 RVA: 0x014FF7F9 File Offset: 0x014FD9F9
			public int FilterRuleId { get; set; }

			// Token: 0x170079AB RID: 31147
			// (get) Token: 0x06045DC1 RID: 286145 RVA: 0x014FF802 File Offset: 0x014FDA02
			// (set) Token: 0x06045DC2 RID: 286146 RVA: 0x014FF80A File Offset: 0x014FDA0A
			public bool HasSelectAll { get; set; }

			// Token: 0x170079AC RID: 31148
			// (get) Token: 0x06045DC3 RID: 286147 RVA: 0x014FF813 File Offset: 0x014FDA13
			// (set) Token: 0x06045DC4 RID: 286148 RVA: 0x014FF81B File Offset: 0x014FDA1B
			public bool NeedChangeColor { get; set; }

			// Token: 0x170079AD RID: 31149
			// (get) Token: 0x06045DC5 RID: 286149 RVA: 0x014FF824 File Offset: 0x014FDA24
			// (set) Token: 0x06045DC6 RID: 286150 RVA: 0x014FF82C File Offset: 0x014FDA2C
			public int[] ValueList { get; set; } = Array.Empty<int>();
		}

		// Token: 0x0200A462 RID: 42082
		[NullableContext(2)]
		public interface ISelectItemData
		{
			// Token: 0x170079AE RID: 31150
			// (get) Token: 0x06045DC8 RID: 286152
			// (set) Token: 0x06045DC9 RID: 286153
			bool IsShowIcon { get; set; }

			// Token: 0x170079AF RID: 31151
			// (get) Token: 0x06045DCA RID: 286154
			// (set) Token: 0x06045DCB RID: 286155
			bool NeedChangeColor { get; set; }

			// Token: 0x170079B0 RID: 31152
			// (get) Token: 0x06045DCC RID: 286156
			// (set) Token: 0x06045DCD RID: 286157
			int FilterId { get; set; }

			// Token: 0x170079B1 RID: 31153
			// (get) Token: 0x06045DCE RID: 286158
			// (set) Token: 0x06045DCF RID: 286159
			int FilterRuleId { get; set; }

			// Token: 0x170079B2 RID: 31154
			// (get) Token: 0x06045DD0 RID: 286160
			// (set) Token: 0x06045DD1 RID: 286161
			int Value { get; set; }

			// Token: 0x170079B3 RID: 31155
			// (get) Token: 0x06045DD2 RID: 286162
			// (set) Token: 0x06045DD3 RID: 286163
			string IconPath { get; set; }

			// Token: 0x170079B4 RID: 31156
			// (get) Token: 0x06045DD4 RID: 286164
			// (set) Token: 0x06045DD5 RID: 286165
			string Name { get; set; }
		}

		// Token: 0x0200A463 RID: 42083
		[NullableContext(2)]
		[Nullable(0)]
		public class SelectItemData : InventoryDefine.ISelectItemData
		{
			// Token: 0x170079B5 RID: 31157
			// (get) Token: 0x06045DD6 RID: 286166 RVA: 0x014FF848 File Offset: 0x014FDA48
			// (set) Token: 0x06045DD7 RID: 286167 RVA: 0x014FF850 File Offset: 0x014FDA50
			public bool IsShowIcon { get; set; }

			// Token: 0x170079B6 RID: 31158
			// (get) Token: 0x06045DD8 RID: 286168 RVA: 0x014FF859 File Offset: 0x014FDA59
			// (set) Token: 0x06045DD9 RID: 286169 RVA: 0x014FF861 File Offset: 0x014FDA61
			public bool NeedChangeColor { get; set; }

			// Token: 0x170079B7 RID: 31159
			// (get) Token: 0x06045DDA RID: 286170 RVA: 0x014FF86A File Offset: 0x014FDA6A
			// (set) Token: 0x06045DDB RID: 286171 RVA: 0x014FF872 File Offset: 0x014FDA72
			public int FilterId { get; set; }

			// Token: 0x170079B8 RID: 31160
			// (get) Token: 0x06045DDC RID: 286172 RVA: 0x014FF87B File Offset: 0x014FDA7B
			// (set) Token: 0x06045DDD RID: 286173 RVA: 0x014FF883 File Offset: 0x014FDA83
			public int FilterRuleId { get; set; }

			// Token: 0x170079B9 RID: 31161
			// (get) Token: 0x06045DDE RID: 286174 RVA: 0x014FF88C File Offset: 0x014FDA8C
			// (set) Token: 0x06045DDF RID: 286175 RVA: 0x014FF894 File Offset: 0x014FDA94
			public int Value { get; set; }

			// Token: 0x170079BA RID: 31162
			// (get) Token: 0x06045DE0 RID: 286176 RVA: 0x014FF89D File Offset: 0x014FDA9D
			// (set) Token: 0x06045DE1 RID: 286177 RVA: 0x014FF8A5 File Offset: 0x014FDAA5
			public string IconPath { get; set; }

			// Token: 0x170079BB RID: 31163
			// (get) Token: 0x06045DE2 RID: 286178 RVA: 0x014FF8AE File Offset: 0x014FDAAE
			// (set) Token: 0x06045DE3 RID: 286179 RVA: 0x014FF8B6 File Offset: 0x014FDAB6
			public string Name { get; set; }
		}
	}
}
