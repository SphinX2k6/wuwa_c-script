using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200182C RID: 6188
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopExchangePopViewProxy : IGameplayShopExchangePopViewProxy
{
	// Token: 0x170017AC RID: 6060
	// (get) Token: 0x0600F40F RID: 62479 RVA: 0x00474F84 File Offset: 0x00473184
	// (set) Token: 0x0600F410 RID: 62480 RVA: 0x00474F8C File Offset: 0x0047318C
	[Nullable(2)]
	public object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170017AD RID: 6061
	// (get) Token: 0x0600F411 RID: 62481 RVA: 0x00474F95 File Offset: 0x00473195
	// (set) Token: 0x0600F412 RID: 62482 RVA: 0x00474F9D File Offset: 0x0047319D
	public int CurrencyId { get; set; }

	// Token: 0x170017AE RID: 6062
	// (get) Token: 0x0600F413 RID: 62483 RVA: 0x00474FA6 File Offset: 0x004731A6
	// (set) Token: 0x0600F414 RID: 62484 RVA: 0x00474FAE File Offset: 0x004731AE
	public List<int> CurrencyIdList { get; set; } = new List<int>();

	// Token: 0x170017AF RID: 6063
	// (get) Token: 0x0600F415 RID: 62485 RVA: 0x00474FB7 File Offset: 0x004731B7
	// (set) Token: 0x0600F416 RID: 62486 RVA: 0x00474FBF File Offset: 0x004731BF
	public int Price { get; set; }

	// Token: 0x170017B0 RID: 6064
	// (get) Token: 0x0600F417 RID: 62487 RVA: 0x00474FC8 File Offset: 0x004731C8
	// (set) Token: 0x0600F418 RID: 62488 RVA: 0x00474FD0 File Offset: 0x004731D0
	public GameplayShopTextData DescribeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017B1 RID: 6065
	// (get) Token: 0x0600F419 RID: 62489 RVA: 0x00474FD9 File Offset: 0x004731D9
	// (set) Token: 0x0600F41A RID: 62490 RVA: 0x00474FE1 File Offset: 0x004731E1
	public bool TipTitleItemVisible { get; set; }

	// Token: 0x170017B2 RID: 6066
	// (get) Token: 0x0600F41B RID: 62491 RVA: 0x00474FEA File Offset: 0x004731EA
	// (set) Token: 0x0600F41C RID: 62492 RVA: 0x00474FF2 File Offset: 0x004731F2
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x170017B3 RID: 6067
	// (get) Token: 0x0600F41D RID: 62493 RVA: 0x00474FFB File Offset: 0x004731FB
	// (set) Token: 0x0600F41E RID: 62494 RVA: 0x00475003 File Offset: 0x00473203
	public bool LeftTimeTextVisible { get; set; }

	// Token: 0x170017B4 RID: 6068
	// (get) Token: 0x0600F41F RID: 62495 RVA: 0x0047500C File Offset: 0x0047320C
	// (set) Token: 0x0600F420 RID: 62496 RVA: 0x00475014 File Offset: 0x00473214
	public GameplayShopTextData LeftTimeDescTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017B5 RID: 6069
	// (get) Token: 0x0600F421 RID: 62497 RVA: 0x0047501D File Offset: 0x0047321D
	// (set) Token: 0x0600F422 RID: 62498 RVA: 0x00475025 File Offset: 0x00473225
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017B6 RID: 6070
	// (get) Token: 0x0600F423 RID: 62499 RVA: 0x0047502E File Offset: 0x0047322E
	// (set) Token: 0x0600F424 RID: 62500 RVA: 0x00475036 File Offset: 0x00473236
	public bool LimitTextItemVisible { get; set; }

	// Token: 0x170017B7 RID: 6071
	// (get) Token: 0x0600F425 RID: 62501 RVA: 0x0047503F File Offset: 0x0047323F
	// (set) Token: 0x0600F426 RID: 62502 RVA: 0x00475047 File Offset: 0x00473247
	public GameplayShopTextData LimitTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017B8 RID: 6072
	// (get) Token: 0x0600F427 RID: 62503 RVA: 0x00475050 File Offset: 0x00473250
	// (set) Token: 0x0600F428 RID: 62504 RVA: 0x00475058 File Offset: 0x00473258
	public bool LockItemVisible { get; set; }

	// Token: 0x170017B9 RID: 6073
	// (get) Token: 0x0600F429 RID: 62505 RVA: 0x00475061 File Offset: 0x00473261
	// (set) Token: 0x0600F42A RID: 62506 RVA: 0x00475069 File Offset: 0x00473269
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017BA RID: 6074
	// (get) Token: 0x0600F42B RID: 62507 RVA: 0x00475072 File Offset: 0x00473272
	// (set) Token: 0x0600F42C RID: 62508 RVA: 0x0047507A File Offset: 0x0047327A
	public int ReSellTime { get; set; }

	// Token: 0x170017BB RID: 6075
	// (get) Token: 0x0600F42D RID: 62509 RVA: 0x00475083 File Offset: 0x00473283
	// (set) Token: 0x0600F42E RID: 62510 RVA: 0x0047508B File Offset: 0x0047328B
	public int BuyCount { get; set; }

	// Token: 0x170017BC RID: 6076
	// (get) Token: 0x0600F42F RID: 62511 RVA: 0x00475094 File Offset: 0x00473294
	// (set) Token: 0x0600F430 RID: 62512 RVA: 0x0047509C File Offset: 0x0047329C
	public int MaxBuyCount { get; set; }

	// Token: 0x170017BD RID: 6077
	// (get) Token: 0x0600F431 RID: 62513 RVA: 0x004750A5 File Offset: 0x004732A5
	// (set) Token: 0x0600F432 RID: 62514 RVA: 0x004750AD File Offset: 0x004732AD
	public string ExchangeTableTextId { get; set; } = "";

	// Token: 0x170017BE RID: 6078
	// (get) Token: 0x0600F433 RID: 62515 RVA: 0x004750B6 File Offset: 0x004732B6
	// (set) Token: 0x0600F434 RID: 62516 RVA: 0x004750BE File Offset: 0x004732BE
	[Nullable(2)]
	public string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170017BF RID: 6079
	// (get) Token: 0x0600F435 RID: 62517 RVA: 0x004750C7 File Offset: 0x004732C7
	// (set) Token: 0x0600F436 RID: 62518 RVA: 0x004750CF File Offset: 0x004732CF
	public string ShopItemResource { get; set; } = "";

	// Token: 0x0600F437 RID: 62519 RVA: 0x004750D8 File Offset: 0x004732D8
	public virtual void OnConfirmButtonClick(int viewId)
	{
	}

	// Token: 0x0600F438 RID: 62520 RVA: 0x004750DA File Offset: 0x004732DA
	public virtual bool CheckConfirmButtonCanInteract()
	{
		return false;
	}

	// Token: 0x0600F439 RID: 62521 RVA: 0x004750DD File Offset: 0x004732DD
	public virtual UiPanelBase ShopItemCreate()
	{
		return null;
	}

	// Token: 0x0600F43A RID: 62522 RVA: 0x004750E0 File Offset: 0x004732E0
	public virtual void ShopItemRefresh()
	{
	}

	// Token: 0x0600F43B RID: 62523 RVA: 0x004750E2 File Offset: 0x004732E2
	public virtual bool CheckMoneyEnough()
	{
		return false;
	}

	// Token: 0x0600F43C RID: 62524 RVA: 0x004750E5 File Offset: 0x004732E5
	public virtual void OnResellTimeRefresh()
	{
	}
}
