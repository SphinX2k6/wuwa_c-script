using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002344 RID: 9028
[NullableContext(1)]
public interface IGameplayShopExchangePopViewProxy
{
	// Token: 0x17001723 RID: 5923
	// (get) Token: 0x06011EB6 RID: 73398
	// (set) Token: 0x06011EB7 RID: 73399
	[Nullable(2)]
	object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001724 RID: 5924
	// (get) Token: 0x06011EB8 RID: 73400
	// (set) Token: 0x06011EB9 RID: 73401
	int CurrencyId { get; set; }

	// Token: 0x17001725 RID: 5925
	// (get) Token: 0x06011EBA RID: 73402
	// (set) Token: 0x06011EBB RID: 73403
	List<int> CurrencyIdList { get; set; }

	// Token: 0x17001726 RID: 5926
	// (get) Token: 0x06011EBC RID: 73404
	// (set) Token: 0x06011EBD RID: 73405
	int Price { get; set; }

	// Token: 0x17001727 RID: 5927
	// (get) Token: 0x06011EBE RID: 73406
	// (set) Token: 0x06011EBF RID: 73407
	GameplayShopTextData DescribeTextData { get; set; }

	// Token: 0x17001728 RID: 5928
	// (get) Token: 0x06011EC0 RID: 73408
	// (set) Token: 0x06011EC1 RID: 73409
	bool TipTitleItemVisible { get; set; }

	// Token: 0x17001729 RID: 5929
	// (get) Token: 0x06011EC2 RID: 73410
	// (set) Token: 0x06011EC3 RID: 73411
	bool LeftTimeItemVisible { get; set; }

	// Token: 0x1700172A RID: 5930
	// (get) Token: 0x06011EC4 RID: 73412
	// (set) Token: 0x06011EC5 RID: 73413
	bool LeftTimeTextVisible { get; set; }

	// Token: 0x1700172B RID: 5931
	// (get) Token: 0x06011EC6 RID: 73414
	// (set) Token: 0x06011EC7 RID: 73415
	GameplayShopTextData LeftTimeDescTextData { get; set; }

	// Token: 0x1700172C RID: 5932
	// (get) Token: 0x06011EC8 RID: 73416
	// (set) Token: 0x06011EC9 RID: 73417
	GameplayShopTextData LeftTimeTextData { get; set; }

	// Token: 0x1700172D RID: 5933
	// (get) Token: 0x06011ECA RID: 73418
	// (set) Token: 0x06011ECB RID: 73419
	bool LimitTextItemVisible { get; set; }

	// Token: 0x1700172E RID: 5934
	// (get) Token: 0x06011ECC RID: 73420
	// (set) Token: 0x06011ECD RID: 73421
	GameplayShopTextData LimitTextData { get; set; }

	// Token: 0x1700172F RID: 5935
	// (get) Token: 0x06011ECE RID: 73422
	// (set) Token: 0x06011ECF RID: 73423
	bool LockItemVisible { get; set; }

	// Token: 0x17001730 RID: 5936
	// (get) Token: 0x06011ED0 RID: 73424
	// (set) Token: 0x06011ED1 RID: 73425
	GameplayShopTextData LockTextData { get; set; }

	// Token: 0x17001731 RID: 5937
	// (get) Token: 0x06011ED2 RID: 73426
	// (set) Token: 0x06011ED3 RID: 73427
	int ReSellTime { get; set; }

	// Token: 0x17001732 RID: 5938
	// (get) Token: 0x06011ED4 RID: 73428
	// (set) Token: 0x06011ED5 RID: 73429
	int BuyCount { get; set; }

	// Token: 0x17001733 RID: 5939
	// (get) Token: 0x06011ED6 RID: 73430
	// (set) Token: 0x06011ED7 RID: 73431
	int MaxBuyCount { get; set; }

	// Token: 0x17001734 RID: 5940
	// (get) Token: 0x06011ED8 RID: 73432
	// (set) Token: 0x06011ED9 RID: 73433
	string ExchangeTableTextId { get; set; }

	// Token: 0x17001735 RID: 5941
	// (get) Token: 0x06011EDA RID: 73434
	// (set) Token: 0x06011EDB RID: 73435
	[Nullable(2)]
	string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001736 RID: 5942
	// (get) Token: 0x06011EDC RID: 73436
	// (set) Token: 0x06011EDD RID: 73437
	string ShopItemResource { get; set; }

	// Token: 0x06011EDE RID: 73438
	void OnConfirmButtonClick(int viewId);

	// Token: 0x06011EDF RID: 73439
	bool CheckConfirmButtonCanInteract();

	// Token: 0x06011EE0 RID: 73440
	UiPanelBase ShopItemCreate();

	// Token: 0x06011EE1 RID: 73441
	void ShopItemRefresh();

	// Token: 0x06011EE2 RID: 73442
	bool CheckMoneyEnough();

	// Token: 0x06011EE3 RID: 73443
	void OnResellTimeRefresh();
}
