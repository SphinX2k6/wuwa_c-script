using System;
using System.Runtime.CompilerServices;

// Token: 0x02002343 RID: 9027
[NullableContext(1)]
public interface IGameplayShopItemProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x17001716 RID: 5910
	// (get) Token: 0x06011E9B RID: 73371
	// (set) Token: 0x06011E9C RID: 73372
	GameplayShopTextData DiscountTextData { get; set; }

	// Token: 0x17001717 RID: 5911
	// (get) Token: 0x06011E9D RID: 73373
	// (set) Token: 0x06011E9E RID: 73374
	bool DiscountItemVisible { get; set; }

	// Token: 0x17001718 RID: 5912
	// (get) Token: 0x06011E9F RID: 73375
	// (set) Token: 0x06011EA0 RID: 73376
	GameplayShopTextData LabelTextData { get; set; }

	// Token: 0x17001719 RID: 5913
	// (get) Token: 0x06011EA1 RID: 73377
	// (set) Token: 0x06011EA2 RID: 73378
	bool LabelVisible { get; set; }

	// Token: 0x1700171A RID: 5914
	// (get) Token: 0x06011EA3 RID: 73379
	// (set) Token: 0x06011EA4 RID: 73380
	GameplayShopTextData LeftTimeTextData { get; set; }

	// Token: 0x1700171B RID: 5915
	// (get) Token: 0x06011EA5 RID: 73381
	// (set) Token: 0x06011EA6 RID: 73382
	bool LeftTimeItemVisible { get; set; }

	// Token: 0x1700171C RID: 5916
	// (get) Token: 0x06011EA7 RID: 73383
	// (set) Token: 0x06011EA8 RID: 73384
	GameplayShopTextData ReSellTextData { get; set; }

	// Token: 0x1700171D RID: 5917
	// (get) Token: 0x06011EA9 RID: 73385
	// (set) Token: 0x06011EAA RID: 73386
	bool ReSellItemVisible { get; set; }

	// Token: 0x1700171E RID: 5918
	// (get) Token: 0x06011EAB RID: 73387
	// (set) Token: 0x06011EAC RID: 73388
	GameplayShopTextData SoldOutTextData { get; set; }

	// Token: 0x1700171F RID: 5919
	// (get) Token: 0x06011EAD RID: 73389
	// (set) Token: 0x06011EAE RID: 73390
	bool SoldOutItemVisible { get; set; }

	// Token: 0x17001720 RID: 5920
	// (get) Token: 0x06011EAF RID: 73391
	// (set) Token: 0x06011EB0 RID: 73392
	GameplayShopTextData LockTextData { get; set; }

	// Token: 0x17001721 RID: 5921
	// (get) Token: 0x06011EB1 RID: 73393
	// (set) Token: 0x06011EB2 RID: 73394
	bool LockItemVisible { get; set; }

	// Token: 0x17001722 RID: 5922
	// (get) Token: 0x06011EB3 RID: 73395
	// (set) Token: 0x06011EB4 RID: 73396
	bool TagNewItemVisible { get; set; }

	// Token: 0x06011EB5 RID: 73397
	void OnBuyButtonClick();
}
