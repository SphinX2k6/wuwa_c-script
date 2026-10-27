using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;

// Token: 0x0200235F RID: 9055
[NullableContext(1)]
[Nullable(0)]
public class PayShopDefine : IStaticVariableResetter
{
	// Token: 0x060120B4 RID: 73908 RVA: 0x0046D444 File Offset: 0x0046B644
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

	// Token: 0x17001790 RID: 6032
	// (get) Token: 0x060120B5 RID: 73909 RVA: 0x0046D60A File Offset: 0x0046B80A
	public static IReadOnlyDictionary<PayShopDefine.ERecommendTabType, EUiTabViewName> RecommendTabView
	{
		get
		{
			return PayShopDefine._recommendTabView;
		}
	}

	// Token: 0x17001791 RID: 6033
	// (get) Token: 0x060120B6 RID: 73910 RVA: 0x0046D611 File Offset: 0x0046B811
	public static IReadOnlyDictionary<PayShopDefine.ESkinTabType, EUiTabViewName> SkinTabView
	{
		get
		{
			return PayShopDefine._skinTabView;
		}
	}

	// Token: 0x17001792 RID: 6034
	// (get) Token: 0x060120B7 RID: 73911 RVA: 0x0046D618 File Offset: 0x0046B818
	public static IReadOnlyList<PayShopDefine.EPayShopTagType> payShopTagSortList
	{
		get
		{
			return PayShopDefine._payShopTagSortList;
		}
	}

	// Token: 0x17001793 RID: 6035
	// (get) Token: 0x060120B8 RID: 73912 RVA: 0x0046D61F File Offset: 0x0046B81F
	public static IReadOnlyDictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>> payShopTagTypeToExtraConstructor
	{
		get
		{
			return PayShopDefine._payShopTagTypeToExtraConstructor;
		}
	}

	// Token: 0x17001794 RID: 6036
	// (get) Token: 0x060120B9 RID: 73913 RVA: 0x0046D626 File Offset: 0x0046B826
	public static IReadOnlyList<int> GiftBagShopSpecialTabList
	{
		get
		{
			return PayShopDefine._giftBagShopSpecialTabList;
		}
	}

	// Token: 0x060120BA RID: 73914 RVA: 0x0046D630 File Offset: 0x0046B830
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

	// Token: 0x060120BB RID: 73915 RVA: 0x0046D70C File Offset: 0x0046B90C
	public static void ResetStaticDefaultValue()
	{
		PayShopDefine._payShopTagSortList = null;
		PayShopDefine._giftBagShopSpecialTabList = null;
		PayShopDefine._skinTabView = null;
		PayShopDefine._recommendTabView = null;
		PayShopDefine._payShopTagTypeToExtraConstructor = null;
	}

	// Token: 0x04008883 RID: 34947
	public const int DISCOUNT_PERCENT = 100;

	// Token: 0x04008884 RID: 34948
	public const int MS_PER_SECOND = 1000;

	// Token: 0x04008885 RID: 34949
	public const int MONTH_CARD_SHOP_ID = 42;

	// Token: 0x04008886 RID: 34950
	public const int BATTLE_PASS_PRIMARY_ID = 43;

	// Token: 0x04008887 RID: 34951
	public const int BATTLE_PASS_HIGH_ID = 44;

	// Token: 0x04008888 RID: 34952
	public const int BATTLE_PASS_PRIMARY_TO_HIGH_ID = 45;

	// Token: 0x04008889 RID: 34953
	public const int MONTH_CARD_CONFIG_ID = 1;

	// Token: 0x0400888A RID: 34954
	public const int MONTH_CARD_HELP_ID = 9;

	// Token: 0x0400888B RID: 34955
	public const int LORD_GYM_TAB_INDEX = 2;

	// Token: 0x0400888C RID: 34956
	public const int NEW_LORD_GYM_TAB_INDEX = 3;

	// Token: 0x0400888D RID: 34957
	public const int NEW_LORD_GYM_FIRST_TAB_INDEX = 2;

	// Token: 0x0400888E RID: 34958
	public const int LORD_GYM_THIRD_TAB_INDEX = 4;

	// Token: 0x0400888F RID: 34959
	public const int LORD_GYM_THIRD5_TAB_INDEX = 5;

	// Token: 0x04008890 RID: 34960
	public const int LORD_GYM_CURRENCY_ID = 34;

	// Token: 0x04008891 RID: 34961
	public const int LORD_GYM_FIRST_CURRENCY_ID = 11;

	// Token: 0x04008892 RID: 34962
	public const int LORD_GYM_THIRD_CURRENCY_ID = 63;

	// Token: 0x04008893 RID: 34963
	public const int LORD_GYM_THIRD5_CURRENCY_ID = 82;

	// Token: 0x04008894 RID: 34964
	public const int CARNIVAL_TABID = 5;

	// Token: 0x04008895 RID: 34965
	public const int LEVELUP_BACKPACK_TABID = 2;

	// Token: 0x04008896 RID: 34966
	public const int GOLD_QUALITY = 5;

	// Token: 0x04008897 RID: 34967
	public static readonly IReadOnlySet<InventoryDefine.EItemDataType> PayShopNeedCheckBtnItemTypeSet = new HashSet<InventoryDefine.EItemDataType>
	{
		InventoryDefine.EItemDataType.OrnamentItem,
		InventoryDefine.EItemDataType.MotorDecorationItem
	};

	// Token: 0x04008898 RID: 34968
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> PayShopNeedOrnamentRoleIconShopSet = new HashSet<PayShopDefine.EPayShopTabType>
	{
		PayShopDefine.EPayShopTabType.SkinShop
	};

	// Token: 0x04008899 RID: 34969
	public static readonly IReadOnlyDictionary<PayShopDefine.EPayShopUpdateType, string> payShopUpdateTypeTextId;

	// Token: 0x0400889A RID: 34970
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> PayShopCumulativeTabTypeSet;

	// Token: 0x0400889B RID: 34971
	public static readonly IReadOnlySet<PayShopDefine.EPayShopTabType> payGiftRoutedShopSet;

	// Token: 0x0400889C RID: 34972
	public static readonly IReadOnlyList<PayShopDefine.EShopTabViewType> payShopViewTabType;

	// Token: 0x0400889D RID: 34973
	public static readonly IReadOnlyList<PayShopDefine.EShopTabViewType> iosLimitModePayShopViewType;

	// Token: 0x0400889E RID: 34974
	[Nullable(2)]
	private static IReadOnlyDictionary<PayShopDefine.ERecommendTabType, EUiTabViewName> _recommendTabView;

	// Token: 0x0400889F RID: 34975
	[Nullable(2)]
	private static IReadOnlyDictionary<PayShopDefine.ESkinTabType, EUiTabViewName> _skinTabView;

	// Token: 0x040088A0 RID: 34976
	[Nullable(2)]
	private static IReadOnlyList<PayShopDefine.EPayShopTagType> _payShopTagSortList;

	// Token: 0x040088A1 RID: 34977
	public static readonly IReadOnlyDictionary<PayShopDefine.EPayShopTagType, string> payShopTagTypeToResourceId;

	// Token: 0x040088A2 RID: 34978
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static IReadOnlyDictionary<PayShopDefine.EPayShopTagType, Func<PayShopExtraTagItem>> _payShopTagTypeToExtraConstructor;

	// Token: 0x040088A3 RID: 34979
	[Nullable(2)]
	private static IReadOnlyList<int> _giftBagShopSpecialTabList;

	// Token: 0x040088A4 RID: 34980
	public const int NEW_PLAYER_SHOP_WEEK_CARD_TAB_ID = 1;

	// Token: 0x020088E2 RID: 35042
	[NullableContext(0)]
	public enum EPayShopUpdateType
	{
		// Token: 0x0402C7B5 RID: 182197
		None,
		// Token: 0x0402C7B6 RID: 182198
		Daily,
		// Token: 0x0402C7B7 RID: 182199
		Weekly,
		// Token: 0x0402C7B8 RID: 182200
		Monthly,
		// Token: 0x0402C7B9 RID: 182201
		Forever
	}

	// Token: 0x020088E3 RID: 35043
	[NullableContext(0)]
	public enum EPayShopItemType
	{
		// Token: 0x0402C7BB RID: 182203
		Normal,
		// Token: 0x0402C7BC RID: 182204
		Direct
	}

	// Token: 0x020088E4 RID: 35044
	[NullableContext(0)]
	public enum EPayShopTabType
	{
		// Token: 0x0402C7BE RID: 182206
		None = -1,
		// Token: 0x0402C7BF RID: 182207
		Default,
		// Token: 0x0402C7C0 RID: 182208
		Recommend,
		// Token: 0x0402C7C1 RID: 182209
		GiftBag = 3,
		// Token: 0x0402C7C2 RID: 182210
		ExchangeEntry,
		// Token: 0x0402C7C3 RID: 182211
		SkinShop = 6,
		// Token: 0x0402C7C4 RID: 182212
		Recharge = 100,
		// Token: 0x0402C7C5 RID: 182213
		Roguelike = 201,
		// Token: 0x0402C7C6 RID: 182214
		ActivityShop = 5,
		// Token: 0x0402C7C7 RID: 182215
		MoonChasing = 205,
		// Token: 0x0402C7C8 RID: 182216
		FishingShopOne = 208,
		// Token: 0x0402C7C9 RID: 182217
		FishingLimitTimeReward,
		// Token: 0x0402C7CA RID: 182218
		FishingShopTwo,
		// Token: 0x0402C7CB RID: 182219
		FishingShopThree,
		// Token: 0x0402C7CC RID: 182220
		FishingShopFour,
		// Token: 0x0402C7CD RID: 182221
		BabelTowerShop,
		// Token: 0x0402C7CE RID: 182222
		CumulativeShop = 215,
		// Token: 0x0402C7CF RID: 182223
		InfrFireShop = 219,
		// Token: 0x0402C7D0 RID: 182224
		FurnitureShop,
		// Token: 0x0402C7D1 RID: 182225
		CumulativeShop3Dot3,
		// Token: 0x0402C7D2 RID: 182226
		SheriffShop = 225,
		// Token: 0x0402C7D3 RID: 182227
		NewPlayerShop = 7
	}

	// Token: 0x020088E5 RID: 35045
	[NullableContext(0)]
	public enum EShopTabViewType
	{
		// Token: 0x0402C7D5 RID: 182229
		Recommend = 1,
		// Token: 0x0402C7D6 RID: 182230
		GiftBag = 3,
		// Token: 0x0402C7D7 RID: 182231
		ExchangeEntry,
		// Token: 0x0402C7D8 RID: 182232
		Recharge,
		// Token: 0x0402C7D9 RID: 182233
		ActivityShop,
		// Token: 0x0402C7DA RID: 182234
		Roguelike,
		// Token: 0x0402C7DB RID: 182235
		MoonChasing,
		// Token: 0x0402C7DC RID: 182236
		SkinShop,
		// Token: 0x0402C7DD RID: 182237
		NewPlayerShop
	}

	// Token: 0x020088E6 RID: 35046
	[NullableContext(0)]
	public enum ERecommendTabType
	{
		// Token: 0x0402C7DF RID: 182239
		MonthCard = 2,
		// Token: 0x0402C7E0 RID: 182240
		RoleSkinRecommendView,
		// Token: 0x0402C7E1 RID: 182241
		WeekCard,
		// Token: 0x0402C7E2 RID: 182242
		MotorSkin
	}

	// Token: 0x020088E7 RID: 35047
	[NullableContext(0)]
	public enum ESkinTabType
	{
		// Token: 0x0402C7E4 RID: 182244
		RoleSkinTabView = 1,
		// Token: 0x0402C7E5 RID: 182245
		FlySkinTabView,
		// Token: 0x0402C7E6 RID: 182246
		MotorSkinTabView,
		// Token: 0x0402C7E7 RID: 182247
		RoleOrnamentTabView
	}

	// Token: 0x020088E8 RID: 35048
	[NullableContext(0)]
	public enum EPayShopTagType
	{
		// Token: 0x0402C7E9 RID: 182249
		Preferential = 1,
		// Token: 0x0402C7EA RID: 182250
		WellWorth,
		// Token: 0x0402C7EB RID: 182251
		Recommend,
		// Token: 0x0402C7EC RID: 182252
		Free,
		// Token: 0x0402C7ED RID: 182253
		Regress,
		// Token: 0x0402C7EE RID: 182254
		Carnival,
		// Token: 0x0402C7EF RID: 182255
		RechargeDouble,
		// Token: 0x0402C7F0 RID: 182256
		RechargeGiven,
		// Token: 0x0402C7F1 RID: 182257
		SoldOut,
		// Token: 0x0402C7F2 RID: 182258
		Lock,
		// Token: 0x0402C7F3 RID: 182259
		Discount,
		// Token: 0x0402C7F4 RID: 182260
		TotalTopUp
	}

	// Token: 0x020088E9 RID: 35049
	[NullableContext(0)]
	public enum EGiftPackCheckGoodsMethod
	{
		// Token: 0x0402C7F6 RID: 182262
		Default,
		// Token: 0x0402C7F7 RID: 182263
		NormalGift
	}
}
