using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001829 RID: 6185
[NullableContext(1)]
public interface IGameplayShopExchangePopViewProxy
{
	// Token: 0x1700175D RID: 5981
	// (get) Token: 0x0600F366 RID: 62310
	// (set) Token: 0x0600F367 RID: 62311
	[Nullable(2)]
	object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700175E RID: 5982
	// (get) Token: 0x0600F368 RID: 62312
	// (set) Token: 0x0600F369 RID: 62313
	int CurrencyId { get; set; }

	// Token: 0x1700175F RID: 5983
	// (get) Token: 0x0600F36A RID: 62314
	// (set) Token: 0x0600F36B RID: 62315
	List<int> CurrencyIdList { get; set; }

	// Token: 0x17001760 RID: 5984
	// (get) Token: 0x0600F36C RID: 62316
	// (set) Token: 0x0600F36D RID: 62317
	int Price { get; set; }

	// Token: 0x17001761 RID: 5985
	// (get) Token: 0x0600F36E RID: 62318
	// (set) Token: 0x0600F36F RID: 62319
	GameplayShopTextData DescribeTextData { get; set; }

	// Token: 0x17001762 RID: 5986
	// (get) Token: 0x0600F370 RID: 62320
	// (set) Token: 0x0600F371 RID: 62321
	bool TipTitleItemVisible { get; set; }

	// Token: 0x17001763 RID: 5987
	// (get) Token: 0x0600F372 RID: 62322
	// (set) Token: 0x0600F373 RID: 62323
	bool LeftTimeItemVisible { get; set; }

	// Token: 0x17001764 RID: 5988
	// (get) Token: 0x0600F374 RID: 62324
	// (set) Token: 0x0600F375 RID: 62325
	bool LeftTimeTextVisible { get; set; }

	// Token: 0x17001765 RID: 5989
	// (get) Token: 0x0600F376 RID: 62326
	// (set) Token: 0x0600F377 RID: 62327
	GameplayShopTextData LeftTimeDescTextData { get; set; }

	// Token: 0x17001766 RID: 5990
	// (get) Token: 0x0600F378 RID: 62328
	// (set) Token: 0x0600F379 RID: 62329
	GameplayShopTextData LeftTimeTextData { get; set; }

	// Token: 0x17001767 RID: 5991
	// (get) Token: 0x0600F37A RID: 62330
	// (set) Token: 0x0600F37B RID: 62331
	bool LimitTextItemVisible { get; set; }

	// Token: 0x17001768 RID: 5992
	// (get) Token: 0x0600F37C RID: 62332
	// (set) Token: 0x0600F37D RID: 62333
	GameplayShopTextData LimitTextData { get; set; }

	// Token: 0x17001769 RID: 5993
	// (get) Token: 0x0600F37E RID: 62334
	// (set) Token: 0x0600F37F RID: 62335
	bool LockItemVisible { get; set; }

	// Token: 0x1700176A RID: 5994
	// (get) Token: 0x0600F380 RID: 62336
	// (set) Token: 0x0600F381 RID: 62337
	GameplayShopTextData LockTextData { get; set; }

	// Token: 0x1700176B RID: 5995
	// (get) Token: 0x0600F382 RID: 62338
	// (set) Token: 0x0600F383 RID: 62339
	int ReSellTime { get; set; }

	// Token: 0x1700176C RID: 5996
	// (get) Token: 0x0600F384 RID: 62340
	// (set) Token: 0x0600F385 RID: 62341
	int BuyCount { get; set; }

	// Token: 0x1700176D RID: 5997
	// (get) Token: 0x0600F386 RID: 62342
	// (set) Token: 0x0600F387 RID: 62343
	int MaxBuyCount { get; set; }

	// Token: 0x1700176E RID: 5998
	// (get) Token: 0x0600F388 RID: 62344
	// (set) Token: 0x0600F389 RID: 62345
	string ExchangeTableTextId { get; set; }

	// Token: 0x1700176F RID: 5999
	// (get) Token: 0x0600F38A RID: 62346
	// (set) Token: 0x0600F38B RID: 62347
	[Nullable(2)]
	string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001770 RID: 6000
	// (get) Token: 0x0600F38C RID: 62348
	// (set) Token: 0x0600F38D RID: 62349
	string ShopItemResource { get; set; }

	// Token: 0x0600F38E RID: 62350
	void OnConfirmButtonClick(int viewId);

	// Token: 0x0600F38F RID: 62351
	bool CheckConfirmButtonCanInteract();

	// Token: 0x0600F390 RID: 62352
	UiPanelBase ShopItemCreate();

	// Token: 0x0600F391 RID: 62353
	void ShopItemRefresh();

	// Token: 0x0600F392 RID: 62354
	bool CheckMoneyEnough();

	// Token: 0x0600F393 RID: 62355
	void OnResellTimeRefresh();
}
