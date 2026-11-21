using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;

// Token: 0x02001844 RID: 6212
[NullableContext(1)]
[Nullable(0)]
public class PayShopDefine : IStaticVariableResetter
{
	// Token: 0x0600F564 RID: 62820 RVA: 0x0047A504 File Offset: 0x00478704
	static PayShopDefine()
	{
		Dictionary<PayShopDefine.EPayShopUpdateType, string> dictionary = new Dictionary<PayShopDefine.EPayShopUpdateType, string>();
		dictionary[PayShopDefine.EPayShopUpdateType.None] = "RemainNo";
		dictionary[PayShopDefine.EPayShopUpdateType.Daily] = "RemainNoInDay";
		dictionary[PayShopDefine.EPayShopUpdateType.Weekly] = "RemainNoInWeek";
		dictionary[PayShopDefine.EPayShopUpdateType.Monthly] = "RemainNoInMonth";
		dictionary[PayShopDefine.EPayShopUpdateType.Forever] = "RemainNo";
		PayShopDefine.payShopUpdateTypeTextId = dictionary;
		PayShopDefine.PayShopCumulativeTabTypeSet = new HashSet<PayShopDefine.EPayShopTabType>
		{
			PayShopDefine.EPayShopTabType.CumulativeShop,
			PayShopDefine.EPayShopTabType.CumulativeShop3Dot3
		};
		PayShopDefine.payGiftRoutedShopSet = new HashSet<PayShopDefine.EPayShopTabType>
		{
			PayShopDefine.EPayShopTabType.GiftBag,
			PayShopDefine.EPayShopTabType.NewPlayerShop
		};
		PayShopDefine.payShopViewTabType = new List<PayShopDefine.EShopTabViewType>
		{
			PayShopDefine.EShopTabViewType.Recommend,
			PayShopDefine.EShopTabViewType.GiftBag,
			PayShopDefine.EShopTabViewType.ExchangeEntry,
			PayShopDefine.EShopTabViewType.Recharge,
			PayShopDefine.EShopTabViewType.SkinShop,
			PayShopDefine.EShopTabViewType.ActivityShop,
			PayShopDefine.EShopTabViewType.NewPlayerShop
		};
		PayShopDefine.iosLimitModePayShopViewType = new List<PayShopDefine.EShopTabViewType>
		{
			PayShopDefine.EShopTabViewType.Recharge
		};
		Dictionary<PayShopDefine.EPayShopTagType, string> dictionary2 = new Dictionary<PayShopDefine.EPayShopTagType, string>();
		dictionary2[PayShopDefine.EPayShopTagType.Preferential] = "ShopLabelRes_1";
		dictionary2[PayShopDefine.EPayShopTagType.WellWorth] = "ShopLabelRes_1";
		dictionary2[PayShopDefine.EPayShopTagType.Recommend] = "ShopLabelRes_1";
		dictionary2[PayShopDefine.EPayShopTagType.Free] = "ShopLabelRes_1";
		dictionary2[PayShopDefine.EPayShopTagType.Regress] = "ShopLabelRes_5";
		dictionary2[PayShopDefine.EPayShopTagType.Carnival] = "ShopLabelRes_6";
		dictionary2[PayShopDefine.EPayShopTagType.RechargeDouble] = "RechargeItemDefaultTag";
		dictionary2[PayShopDefine.EPayShopTagType.RechargeGiven] = "RechargeItemSpecialTag";
		dictionary2[PayShopDefine.EPayShopTagType.SoldOut] = "ShopItemSoldOutPanel";
		dictionary2[PayShopDefine.EPayShopTagType.Lock] = "ShopItemLockPanel";
		dictionary2[PayShopDefine.EPayShopTagType.Discount] = "ShopItemDiscountLabel";
		dictionary2[PayShopDefine.EPayShopTagType.TotalTopUp] = "UiItem_CumulativeRechargeScoreTag";
		PayShopDefine.payShopTagTypeToResourceId = dictionary2;
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopDefine.CreateStaticDefaultValue), new Action(PayShopDefine.ResetStaticDefaultValue));
	}

	// Token: 0x170017CA RID: 6090
	// (get) Token: 0x0600F565 RID: 62821 RVA: 0x0047A6CA File Offset: 0x004788CA
	public static IReadOnlyDictionary<PayShopDefine.ERecommendTabType, EUiTabViewName> RecommendTabView
	{
		get
		{
			return PayShopDefine._recommendTabView;
		}
	}

	// Token: 0x170017CB RID: 6091
	// (get) Token: 0x0600F566 RID: 62822 RVA: 0x0047A6D1 File Offset: 0x004788D1
	public static IReadOnlyDictionary<PayShopDefine.ESkinTabType, EUiTabViewName> SkinTabView
	{
		get
		{
			return PayShopDefine._skinTabView;
		}
	}

	// Token: 0x170017CC RID: 6092
	// (get) Token: 0x0600F567 RID: 62823 RVA: 0x0047A6D8 File Offset: 0x004788D8
	public static IReadOnlyList<PayShopDefine.EPayShopTagType> payShopTagSortList
	{
		get
		{
			return PayShopDefine._payShopTagSortList;
		}
	}

	// Token: 0x170017CD RID: 6093
	// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0047A6DF File Offset: 0x004788DF
	public static IReadOnlyDictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>> payShopTagTypeToExtraConstructor
	{
		get
		{
			return PayShopDefine._payShopTagTypeToExtraConstructor;
		}
	}

	// Token: 0x170017CE RID: 6094
	// (get) Token: 0x0600F569 RID: 62825 RVA: 0x0047A6E6 File Offset: 0x004788E6
	public static IReadOnlyList<int> GiftBagShopSpecialTabList
	{
		get
		{
			return PayShopDefine._giftBagShopSpecialTabList;
		}
	}

	// Token: 0x0600F56A RID: 62826 RVA: 0x0047A6F0 File Offset: 0x004788F0
	public static void CreateStaticDefaultValue()
	{
		PayShopDefine._payShopTagSortList = new List<PayShopDefine.EPayShopTagType>
		{
			PayShopDefine.EPayShopTagType.TotalTopUp
		};
		PayShopDefine._giftBagShopSpecialTabList = new List<int>
		{
			5,
			2
		};
		Dictionary<PayShopDefine.ESkinTabType, EUiTabViewName> dictionary = new Dictionary<PayShopDefine.ESkinTabType, EUiTabViewName>();
		dictionary[PayShopDefine.ESkinTabType.RoleSkinTabView] = EUiTabViewName.RoleShopSkinTabView;
		dictionary[PayShopDefine.ESkinTabType.FlySkinTabView] = EUiTabViewName.ShopFlySkinTabView;
		dictionary[PayShopDefine.ESkinTabType.MotorSkinTabView] = EUiTabViewName.MotorSkinTabView;
		dictionary[PayShopDefine.ESkinTabType.RoleOrnamentTabView] = EUiTabViewName.RoleShopOrnamentTabView;
		PayShopDefine._skinTabView = dictionary;
		Dictionary<PayShopDefine.ERecommendTabType, EUiTabViewName> dictionary2 = new Dictionary<PayShopDefine.ERecommendTabType, EUiTabViewName>();
		dictionary2[PayShopDefine.ERecommendTabType.MonthCard] = EUiTabViewName.MonthCardView;
		dictionary2[PayShopDefine.ERecommendTabType.RoleSkinRecommendView] = EUiTabViewName.RoleSkinRecommendView;
		dictionary2[PayShopDefine.ERecommendTabType.WeekCard] = EUiTabViewName.WeekCardView;
		dictionary2[PayShopDefine.ERecommendTabType.MotorSkin] = EUiTabViewName.MotorSkinRecommendView;
		PayShopDefine._recommendTabView = dictionary2;
		Dictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>> dictionary3 = new Dictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>>();
		dictionary3[PayShopDefine.EPayShopTagType.TotalTopUp] = (() => new TotalTopUpPayShopTagItem());
		PayShopDefine._payShopTagTypeToExtraConstructor = dictionary3;
	}

	// Token: 0x0600F56B RID: 62827 RVA: 0x0047A7CC File Offset: 0x004789CC
	public static void ResetStaticDefaultValue()
	{
		PayShopDefine._payShopTagSortList = null;
		PayShopDefine._giftBagShopSpecialTabList = null;
		PayShopDefine._skinTabView = null;
		PayShopDefine._recommendTabView = null;
		PayShopDefine._payShopTagTypeToExtraConstructor = null;
	}

	// Token: 0x040089C8 RID: 35272
	public const int DISCOUNT_PERCENT = 100;

	// Token: 0x040089C9 RID: 35273
	public const int MS_PER_SECOND = 1000;

	// Token: 0x040089CA RID: 35274
	public const int MONTH_CARD_SHOP_ID = 42;

	// Token: 0x040089CB RID: 35275
	public const int BATTLE_PASS_PRIMARY_ID = 43;

	// Token: 0x040089CC RID: 35276
	public const int BATTLE_PASS_HIGH_ID = 44;

	// Token: 0x040089CD RID: 35277
	public const int BATTLE_PASS_PRIMARY_TO_HIGH_ID = 45;

	// Token: 0x040089CE RID: 35278
	public const int MONTH_CARD_CONFIG_ID = 1;

	// Token: 0x040089CF RID: 35279
	public const int MONTH_CARD_HELP_ID = 9;

	// Token: 0x040089D0 RID: 35280
	public const int LORD_GYM_TAB_INDEX = 2;

	// Token: 0x040089D1 RID: 35281
	public const int NEW_LORD_GYM_TAB_INDEX = 3;

	// Token: 0x040089D2 RID: 35282
	public const int NEW_LORD_GYM_FIRST_TAB_INDEX = 2;

	// Token: 0x040089D3 RID: 35283
	public const int LORD_GYM_THIRD_TAB_INDEX = 4;

	// Token: 0x040089D4 RID: 35284
	public const int LORD_GYM_THIRD5_TAB_INDEX = 5;

	// Token: 0x040089D5 RID: 35285
	public const int LORD_GYM_CURRENCY_ID = 34;

	// Token: 0x040089D6 RID: 35286
	public const int LORD_GYM_FIRST_CURRENCY_ID = 11;

	// Token: 0x040089D7 RID: 35287
	public const int LORD_GYM_THIRD_CURRENCY_ID = 63;

	// Token: 0x040089D8 RID: 35288
	public const int LORD_GYM_THIRD5_CURRENCY_ID = 82;

	// Token: 0x040089D9 RID: 35289
	public const int CARNIVAL_TABID = 5;

	// Token: 0x040089DA RID: 35290
	public const int LEVELUP_BACKPACK_TABID = 2;

	// Token: 0x040089DB RID: 35291
	public const int GOLD_QUALITY = 5;

	// Token: 0x040089DC RID: 35292
	public static readonly IReadOnlySet<InventoryDefine.EItemDataType> PayShopNeedCheckBtnItemTypeSet = new HashSet<InventoryDefine.EItemDataType>
	{
		InventoryDefine.EItemDataType.OrnamentItem,
		InventoryDefine.EItemDataType.MotorDecorationItem
	};

	// Token: 0x040089DD RID: 35293
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> PayShopNeedOrnamentRoleIconShopSet = new HashSet<PayShopDefine.EPayShopTabType>
	{
		PayShopDefine.EPayShopTabType.SkinShop
	};

	// Token: 0x040089DE RID: 35294
	public static readonly IReadOnlyDictionary<PayShopDefine.EPayShopUpdateType, string> payShopUpdateTypeTextId;

	// Token: 0x040089DF RID: 35295
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> PayShopCumulativeTabTypeSet;

	// Token: 0x040089E0 RID: 35296
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> payGiftRoutedShopSet;

	// Token: 0x040089E1 RID: 35297
	public static readonly IReadOnlyList<PayShopDefine.EShopTabViewType> payShopViewTabType;

	// Token: 0x040089E2 RID: 35298
	public static readonly IReadOnlyList<PayShopDefine.EShopTabViewType> iosLimitModePayShopViewType;

	// Token: 0x040089E3 RID: 35299
	[Nullable(2)]
	private static IReadOnlyDictionary<PayShopDefine.ERecommendTabType, EUiTabViewName> _recommendTabView;

	// Token: 0x040089E4 RID: 35300
	[Nullable(2)]
	private static IReadOnlyDictionary<PayShopDefine.ESkinTabType, EUiTabViewName> _skinTabView;

	// Token: 0x040089E5 RID: 35301
	[Nullable(2)]
	private static IReadOnlyList<PayShopDefine.EPayShopTagType> _payShopTagSortList;

	// Token: 0x040089E6 RID: 35302
	public static readonly IReadOnlyDictionary<PayShopDefine.EPayShopTagType, string> payShopTagTypeToResourceId;

	// Token: 0x040089E7 RID: 35303
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static IReadOnlyDictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>> _payShopTagTypeToExtraConstructor;

	// Token: 0x040089E8 RID: 35304
	[Nullable(2)]
	private static IReadOnlyList<int> _giftBagShopSpecialTabList;

	// Token: 0x040089E9 RID: 35305
	public const int NEW_PLAYER_SHOP_WEEK_CARD_TAB_ID = 1;

	// Token: 0x02007A6B RID: 31339
	[NullableContext(0)]
	public enum EPayShopUpdateType
	{
		// Token: 0x04027AC9 RID: 162505
		None,
		// Token: 0x04027ACA RID: 162506
		Daily,
		// Token: 0x04027ACB RID: 162507
		Weekly,
		// Token: 0x04027ACC RID: 162508
		Monthly,
		// Token: 0x04027ACD RID: 162509
		Forever
	}

	// Token: 0x02007A6C RID: 31340
	[NullableContext(0)]
	public enum EPayShopItemType
	{
		// Token: 0x04027ACF RID: 162511
		Normal,
		// Token: 0x04027AD0 RID: 162512
		Direct
	}

	// Token: 0x02007A6D RID: 31341
	[NullableContext(0)]
	public enum EPayShopCantBuyReason
	{
		// Token: 0x04027AD2 RID: 162514
		None,
		// Token: 0x04027AD3 RID: 162515
		NotInSellTime,
		// Token: 0x04027AD4 RID: 162516
		Other
	}

	// Token: 0x02007A6E RID: 31342
	[NullableContext(0)]
	public enum EPayShopTabType
	{
		// Token: 0x04027AD6 RID: 162518
		None = -1,
		// Token: 0x04027AD7 RID: 162519
		Default,
		// Token: 0x04027AD8 RID: 162520
		Recommend,
		// Token: 0x04027AD9 RID: 162521
		GiftBag = 3,
		// Token: 0x04027ADA RID: 162522
		ExchangeEntry,
		// Token: 0x04027ADB RID: 162523
		SkinShop = 6,
		// Token: 0x04027ADC RID: 162524
		Recharge = 100,
		// Token: 0x04027ADD RID: 162525
		Roguelike = 201,
		// Token: 0x04027ADE RID: 162526
		ActivityShop = 5,
		// Token: 0x04027ADF RID: 162527
		MoonChasing = 205,
		// Token: 0x04027AE0 RID: 162528
		FishingShopOne = 208,
		// Token: 0x04027AE1 RID: 162529
		FishingLimitTimeReward,
		// Token: 0x04027AE2 RID: 162530
		FishingShopTwo,
		// Token: 0x04027AE3 RID: 162531
		FishingShopThree,
		// Token: 0x04027AE4 RID: 162532
		FishingShopFour,
		// Token: 0x04027AE5 RID: 162533
		BabelTowerShop,
		// Token: 0x04027AE6 RID: 162534
		CumulativeShop = 215,
		// Token: 0x04027AE7 RID: 162535
		InfrFireShop = 219,
		// Token: 0x04027AE8 RID: 162536
		FurnitureShop,
		// Token: 0x04027AE9 RID: 162537
		CumulativeShop3Dot3,
		// Token: 0x04027AEA RID: 162538
		SheriffShop = 225,
		// Token: 0x04027AEB RID: 162539
		NewPlayerShop = 7
	}

	// Token: 0x02007A6F RID: 31343
	[NullableContext(0)]
	public enum EShopTabViewType
	{
		// Token: 0x04027AED RID: 162541
		Recommend = 1,
		// Token: 0x04027AEE RID: 162542
		GiftBag = 3,
		// Token: 0x04027AEF RID: 162543
		ExchangeEntry,
		// Token: 0x04027AF0 RID: 162544
		Recharge,
		// Token: 0x04027AF1 RID: 162545
		ActivityShop,
		// Token: 0x04027AF2 RID: 162546
		Roguelike,
		// Token: 0x04027AF3 RID: 162547
		MoonChasing,
		// Token: 0x04027AF4 RID: 162548
		SkinShop,
		// Token: 0x04027AF5 RID: 162549
		NewPlayerShop
	}

	// Token: 0x02007A70 RID: 31344
	[NullableContext(0)]
	public enum ERecommendTabType
	{
		// Token: 0x04027AF7 RID: 162551
		MonthCard = 2,
		// Token: 0x04027AF8 RID: 162552
		RoleSkinRecommendView,
		// Token: 0x04027AF9 RID: 162553
		WeekCard,
		// Token: 0x04027AFA RID: 162554
		MotorSkin
	}

	// Token: 0x02007A71 RID: 31345
	[NullableContext(0)]
	public enum ESkinTabType
	{
		// Token: 0x04027AFC RID: 162556
		RoleSkinTabView = 1,
		// Token: 0x04027AFD RID: 162557
		FlySkinTabView,
		// Token: 0x04027AFE RID: 162558
		MotorSkinTabView,
		// Token: 0x04027AFF RID: 162559
		RoleOrnamentTabView
	}

	// Token: 0x02007A72 RID: 31346
	[NullableContext(0)]
	public enum EPayShopTagType
	{
		// Token: 0x04027B01 RID: 162561
		Preferential = 1,
		// Token: 0x04027B02 RID: 162562
		WellWorth,
		// Token: 0x04027B03 RID: 162563
		Recommend,
		// Token: 0x04027B04 RID: 162564
		Free,
		// Token: 0x04027B05 RID: 162565
		Regress,
		// Token: 0x04027B06 RID: 162566
		Carnival,
		// Token: 0x04027B07 RID: 162567
		RechargeDouble,
		// Token: 0x04027B08 RID: 162568
		RechargeGiven,
		// Token: 0x04027B09 RID: 162569
		SoldOut,
		// Token: 0x04027B0A RID: 162570
		Lock,
		// Token: 0x04027B0B RID: 162571
		Discount,
		// Token: 0x04027B0C RID: 162572
		TotalTopUp
	}

	// Token: 0x02007A73 RID: 31347
	[NullableContext(0)]
	public enum EGiftPackCheckGoodsMethod
	{
		// Token: 0x04027B0E RID: 162574
		Default,
		// Token: 0x04027B0F RID: 162575
		NormalGift
	}
}
