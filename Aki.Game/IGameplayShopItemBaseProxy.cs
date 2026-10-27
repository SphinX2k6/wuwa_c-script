using System;
using System.Runtime.CompilerServices;

// Token: 0x02002342 RID: 9026
[NullableContext(1)]
public interface IGameplayShopItemBaseProxy
{
	// Token: 0x170016FF RID: 5887
	// (get) Token: 0x06011E6C RID: 73324
	// (set) Token: 0x06011E6D RID: 73325
	int CurrencyId { get; set; }

	// Token: 0x17001700 RID: 5888
	// (get) Token: 0x06011E6E RID: 73326
	// (set) Token: 0x06011E6F RID: 73327
	int ItemId { get; set; }

	// Token: 0x17001701 RID: 5889
	// (get) Token: 0x06011E70 RID: 73328
	// (set) Token: 0x06011E71 RID: 73329
	string QualitySpritePath { get; set; }

	// Token: 0x17001702 RID: 5890
	// (get) Token: 0x06011E72 RID: 73330
	// (set) Token: 0x06011E73 RID: 73331
	string ItemTexturePath { get; set; }

	// Token: 0x17001703 RID: 5891
	// (get) Token: 0x06011E74 RID: 73332
	// (set) Token: 0x06011E75 RID: 73333
	bool ItemTextureVisible { get; set; }

	// Token: 0x17001704 RID: 5892
	// (get) Token: 0x06011E76 RID: 73334
	// (set) Token: 0x06011E77 RID: 73335
	string BigItemIconTexturePath { get; set; }

	// Token: 0x17001705 RID: 5893
	// (get) Token: 0x06011E78 RID: 73336
	// (set) Token: 0x06011E79 RID: 73337
	bool BigItemIconVisible { get; set; }

	// Token: 0x17001706 RID: 5894
	// (get) Token: 0x06011E7A RID: 73338
	// (set) Token: 0x06011E7B RID: 73339
	GameplayShopTextData ItemNameTextData { get; set; }

	// Token: 0x17001707 RID: 5895
	// (get) Token: 0x06011E7C RID: 73340
	// (set) Token: 0x06011E7D RID: 73341
	bool TipsButtonVisible { get; set; }

	// Token: 0x17001708 RID: 5896
	// (get) Token: 0x06011E7E RID: 73342
	// (set) Token: 0x06011E7F RID: 73343
	bool BottomBgVisible { get; set; }

	// Token: 0x17001709 RID: 5897
	// (get) Token: 0x06011E80 RID: 73344
	// (set) Token: 0x06011E81 RID: 73345
	GameplayShopTextData BuyLimitCountTextData { get; set; }

	// Token: 0x1700170A RID: 5898
	// (get) Token: 0x06011E82 RID: 73346
	// (set) Token: 0x06011E83 RID: 73347
	bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x1700170B RID: 5899
	// (get) Token: 0x06011E84 RID: 73348
	// (set) Token: 0x06011E85 RID: 73349
	bool PriceItemVisible { get; set; }

	// Token: 0x1700170C RID: 5900
	// (get) Token: 0x06011E86 RID: 73350
	// (set) Token: 0x06011E87 RID: 73351
	bool CurrencyIconVisible { get; set; }

	// Token: 0x1700170D RID: 5901
	// (get) Token: 0x06011E88 RID: 73352
	// (set) Token: 0x06011E89 RID: 73353
	GameplayShopTextData NowPriceTextData { get; set; }

	// Token: 0x1700170E RID: 5902
	// (get) Token: 0x06011E8A RID: 73354
	// (set) Token: 0x06011E8B RID: 73355
	string NowPriceTextColor { get; set; }

	// Token: 0x1700170F RID: 5903
	// (get) Token: 0x06011E8C RID: 73356
	// (set) Token: 0x06011E8D RID: 73357
	GameplayShopTextData OriginalPriceTextData { get; set; }

	// Token: 0x17001710 RID: 5904
	// (get) Token: 0x06011E8E RID: 73358
	// (set) Token: 0x06011E8F RID: 73359
	bool OriginalPriceVisible { get; set; }

	// Token: 0x17001711 RID: 5905
	// (get) Token: 0x06011E90 RID: 73360
	// (set) Token: 0x06011E91 RID: 73361
	GameplayShopTextData PriceTipsTextData { get; set; }

	// Token: 0x17001712 RID: 5906
	// (get) Token: 0x06011E92 RID: 73362
	// (set) Token: 0x06011E93 RID: 73363
	bool PriceTipsTextVisible { get; set; }

	// Token: 0x17001713 RID: 5907
	// (get) Token: 0x06011E94 RID: 73364
	// (set) Token: 0x06011E95 RID: 73365
	bool RedDotVisible { get; set; }

	// Token: 0x17001714 RID: 5908
	// (get) Token: 0x06011E96 RID: 73366
	// (set) Token: 0x06011E97 RID: 73367
	bool ItemBgItemVisible { get; set; }

	// Token: 0x17001715 RID: 5909
	// (get) Token: 0x06011E98 RID: 73368
	// (set) Token: 0x06011E99 RID: 73369
	bool RaycastTarget { get; set; }

	// Token: 0x06011E9A RID: 73370
	void OnTipsButtonClick();
}
