using System;
using System.Runtime.CompilerServices;

// Token: 0x02001827 RID: 6183
[NullableContext(1)]
public interface IGameplayShopItemBaseProxy
{
	// Token: 0x17001739 RID: 5945
	// (get) Token: 0x0600F31C RID: 62236
	// (set) Token: 0x0600F31D RID: 62237
	int CurrencyId { get; set; }

	// Token: 0x1700173A RID: 5946
	// (get) Token: 0x0600F31E RID: 62238
	// (set) Token: 0x0600F31F RID: 62239
	int ItemId { get; set; }

	// Token: 0x1700173B RID: 5947
	// (get) Token: 0x0600F320 RID: 62240
	// (set) Token: 0x0600F321 RID: 62241
	string QualitySpritePath { get; set; }

	// Token: 0x1700173C RID: 5948
	// (get) Token: 0x0600F322 RID: 62242
	// (set) Token: 0x0600F323 RID: 62243
	string ItemTexturePath { get; set; }

	// Token: 0x1700173D RID: 5949
	// (get) Token: 0x0600F324 RID: 62244
	// (set) Token: 0x0600F325 RID: 62245
	bool ItemTextureVisible { get; set; }

	// Token: 0x1700173E RID: 5950
	// (get) Token: 0x0600F326 RID: 62246
	// (set) Token: 0x0600F327 RID: 62247
	string BigItemIconTexturePath { get; set; }

	// Token: 0x1700173F RID: 5951
	// (get) Token: 0x0600F328 RID: 62248
	// (set) Token: 0x0600F329 RID: 62249
	bool BigItemIconVisible { get; set; }

	// Token: 0x17001740 RID: 5952
	// (get) Token: 0x0600F32A RID: 62250
	// (set) Token: 0x0600F32B RID: 62251
	GameplayShopTextData ItemNameTextData { get; set; }

	// Token: 0x17001741 RID: 5953
	// (get) Token: 0x0600F32C RID: 62252
	// (set) Token: 0x0600F32D RID: 62253
	bool TipsButtonVisible { get; set; }

	// Token: 0x17001742 RID: 5954
	// (get) Token: 0x0600F32E RID: 62254
	// (set) Token: 0x0600F32F RID: 62255
	bool BottomBgVisible { get; set; }

	// Token: 0x17001743 RID: 5955
	// (get) Token: 0x0600F330 RID: 62256
	// (set) Token: 0x0600F331 RID: 62257
	GameplayShopTextData BuyLimitCountTextData { get; set; }

	// Token: 0x17001744 RID: 5956
	// (get) Token: 0x0600F332 RID: 62258
	// (set) Token: 0x0600F333 RID: 62259
	bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x17001745 RID: 5957
	// (get) Token: 0x0600F334 RID: 62260
	// (set) Token: 0x0600F335 RID: 62261
	bool PriceItemVisible { get; set; }

	// Token: 0x17001746 RID: 5958
	// (get) Token: 0x0600F336 RID: 62262
	// (set) Token: 0x0600F337 RID: 62263
	bool CurrencyIconVisible { get; set; }

	// Token: 0x17001747 RID: 5959
	// (get) Token: 0x0600F338 RID: 62264
	// (set) Token: 0x0600F339 RID: 62265
	GameplayShopTextData NowPriceTextData { get; set; }

	// Token: 0x17001748 RID: 5960
	// (get) Token: 0x0600F33A RID: 62266
	// (set) Token: 0x0600F33B RID: 62267
	string NowPriceTextColor { get; set; }

	// Token: 0x17001749 RID: 5961
	// (get) Token: 0x0600F33C RID: 62268
	// (set) Token: 0x0600F33D RID: 62269
	GameplayShopTextData OriginalPriceTextData { get; set; }

	// Token: 0x1700174A RID: 5962
	// (get) Token: 0x0600F33E RID: 62270
	// (set) Token: 0x0600F33F RID: 62271
	bool OriginalPriceVisible { get; set; }

	// Token: 0x1700174B RID: 5963
	// (get) Token: 0x0600F340 RID: 62272
	// (set) Token: 0x0600F341 RID: 62273
	GameplayShopTextData PriceTipsTextData { get; set; }

	// Token: 0x1700174C RID: 5964
	// (get) Token: 0x0600F342 RID: 62274
	// (set) Token: 0x0600F343 RID: 62275
	bool PriceTipsTextVisible { get; set; }

	// Token: 0x1700174D RID: 5965
	// (get) Token: 0x0600F344 RID: 62276
	// (set) Token: 0x0600F345 RID: 62277
	bool RedDotVisible { get; set; }

	// Token: 0x1700174E RID: 5966
	// (get) Token: 0x0600F346 RID: 62278
	// (set) Token: 0x0600F347 RID: 62279
	bool ItemBgItemVisible { get; set; }

	// Token: 0x1700174F RID: 5967
	// (get) Token: 0x0600F348 RID: 62280
	// (set) Token: 0x0600F349 RID: 62281
	bool RaycastTarget { get; set; }

	// Token: 0x0600F34A RID: 62282
	void OnTipsButtonClick();
}
