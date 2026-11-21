using System;
using System.Runtime.CompilerServices;

// Token: 0x02001828 RID: 6184
[NullableContext(1)]
public interface IGameplayShopItemProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x17001750 RID: 5968
	// (get) Token: 0x0600F34B RID: 62283
	// (set) Token: 0x0600F34C RID: 62284
	GameplayShopTextData DiscountTextData { get; set; }

	// Token: 0x17001751 RID: 5969
	// (get) Token: 0x0600F34D RID: 62285
	// (set) Token: 0x0600F34E RID: 62286
	bool DiscountItemVisible { get; set; }

	// Token: 0x17001752 RID: 5970
	// (get) Token: 0x0600F34F RID: 62287
	// (set) Token: 0x0600F350 RID: 62288
	GameplayShopTextData LabelTextData { get; set; }

	// Token: 0x17001753 RID: 5971
	// (get) Token: 0x0600F351 RID: 62289
	// (set) Token: 0x0600F352 RID: 62290
	bool LabelVisible { get; set; }

	// Token: 0x17001754 RID: 5972
	// (get) Token: 0x0600F353 RID: 62291
	// (set) Token: 0x0600F354 RID: 62292
	GameplayShopTextData LeftTimeTextData { get; set; }

	// Token: 0x17001755 RID: 5973
	// (get) Token: 0x0600F355 RID: 62293
	// (set) Token: 0x0600F356 RID: 62294
	bool LeftTimeItemVisible { get; set; }

	// Token: 0x17001756 RID: 5974
	// (get) Token: 0x0600F357 RID: 62295
	// (set) Token: 0x0600F358 RID: 62296
	GameplayShopTextData ReSellTextData { get; set; }

	// Token: 0x17001757 RID: 5975
	// (get) Token: 0x0600F359 RID: 62297
	// (set) Token: 0x0600F35A RID: 62298
	bool ReSellItemVisible { get; set; }

	// Token: 0x17001758 RID: 5976
	// (get) Token: 0x0600F35B RID: 62299
	// (set) Token: 0x0600F35C RID: 62300
	GameplayShopTextData SoldOutTextData { get; set; }

	// Token: 0x17001759 RID: 5977
	// (get) Token: 0x0600F35D RID: 62301
	// (set) Token: 0x0600F35E RID: 62302
	bool SoldOutItemVisible { get; set; }

	// Token: 0x1700175A RID: 5978
	// (get) Token: 0x0600F35F RID: 62303
	// (set) Token: 0x0600F360 RID: 62304
	GameplayShopTextData LockTextData { get; set; }

	// Token: 0x1700175B RID: 5979
	// (get) Token: 0x0600F361 RID: 62305
	// (set) Token: 0x0600F362 RID: 62306
	bool LockItemVisible { get; set; }

	// Token: 0x1700175C RID: 5980
	// (get) Token: 0x0600F363 RID: 62307
	// (set) Token: 0x0600F364 RID: 62308
	bool TagNewItemVisible { get; set; }

	// Token: 0x0600F365 RID: 62309
	void OnBuyButtonClick();
}
