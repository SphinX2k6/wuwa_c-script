using System;
using System.Runtime.CompilerServices;

// Token: 0x02002346 RID: 9030
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopItemProxy : IGameplayShopItemProxy, IGameplayShopItemBaseProxy
{
	// Token: 0x1700174E RID: 5966
	// (get) Token: 0x06011F14 RID: 73492 RVA: 0x00467B9A File Offset: 0x00465D9A
	// (set) Token: 0x06011F15 RID: 73493 RVA: 0x00467BA2 File Offset: 0x00465DA2
	public int CurrencyId { get; set; }

	// Token: 0x1700174F RID: 5967
	// (get) Token: 0x06011F16 RID: 73494 RVA: 0x00467BAB File Offset: 0x00465DAB
	// (set) Token: 0x06011F17 RID: 73495 RVA: 0x00467BB3 File Offset: 0x00465DB3
	public int ItemId { get; set; }

	// Token: 0x17001750 RID: 5968
	// (get) Token: 0x06011F18 RID: 73496 RVA: 0x00467BBC File Offset: 0x00465DBC
	// (set) Token: 0x06011F19 RID: 73497 RVA: 0x00467BC4 File Offset: 0x00465DC4
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x17001751 RID: 5969
	// (get) Token: 0x06011F1A RID: 73498 RVA: 0x00467BCD File Offset: 0x00465DCD
	// (set) Token: 0x06011F1B RID: 73499 RVA: 0x00467BD5 File Offset: 0x00465DD5
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x17001752 RID: 5970
	// (get) Token: 0x06011F1C RID: 73500 RVA: 0x00467BDE File Offset: 0x00465DDE
	// (set) Token: 0x06011F1D RID: 73501 RVA: 0x00467BE6 File Offset: 0x00465DE6
	public bool ItemTextureVisible { get; set; }

	// Token: 0x17001753 RID: 5971
	// (get) Token: 0x06011F1E RID: 73502 RVA: 0x00467BEF File Offset: 0x00465DEF
	// (set) Token: 0x06011F1F RID: 73503 RVA: 0x00467BF7 File Offset: 0x00465DF7
	public string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x17001754 RID: 5972
	// (get) Token: 0x06011F20 RID: 73504 RVA: 0x00467C00 File Offset: 0x00465E00
	// (set) Token: 0x06011F21 RID: 73505 RVA: 0x00467C08 File Offset: 0x00465E08
	public bool BigItemIconVisible { get; set; }

	// Token: 0x17001755 RID: 5973
	// (get) Token: 0x06011F22 RID: 73506 RVA: 0x00467C11 File Offset: 0x00465E11
	// (set) Token: 0x06011F23 RID: 73507 RVA: 0x00467C19 File Offset: 0x00465E19
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001756 RID: 5974
	// (get) Token: 0x06011F24 RID: 73508 RVA: 0x00467C22 File Offset: 0x00465E22
	// (set) Token: 0x06011F25 RID: 73509 RVA: 0x00467C2A File Offset: 0x00465E2A
	public bool TipsButtonVisible { get; set; }

	// Token: 0x17001757 RID: 5975
	// (get) Token: 0x06011F26 RID: 73510 RVA: 0x00467C33 File Offset: 0x00465E33
	// (set) Token: 0x06011F27 RID: 73511 RVA: 0x00467C3B File Offset: 0x00465E3B
	public bool BottomBgVisible { get; set; }

	// Token: 0x17001758 RID: 5976
	// (get) Token: 0x06011F28 RID: 73512 RVA: 0x00467C44 File Offset: 0x00465E44
	// (set) Token: 0x06011F29 RID: 73513 RVA: 0x00467C4C File Offset: 0x00465E4C
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001759 RID: 5977
	// (get) Token: 0x06011F2A RID: 73514 RVA: 0x00467C55 File Offset: 0x00465E55
	// (set) Token: 0x06011F2B RID: 73515 RVA: 0x00467C5D File Offset: 0x00465E5D
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x1700175A RID: 5978
	// (get) Token: 0x06011F2C RID: 73516 RVA: 0x00467C66 File Offset: 0x00465E66
	// (set) Token: 0x06011F2D RID: 73517 RVA: 0x00467C6E File Offset: 0x00465E6E
	public bool PriceItemVisible { get; set; }

	// Token: 0x1700175B RID: 5979
	// (get) Token: 0x06011F2E RID: 73518 RVA: 0x00467C77 File Offset: 0x00465E77
	// (set) Token: 0x06011F2F RID: 73519 RVA: 0x00467C7F File Offset: 0x00465E7F
	public bool CurrencyIconVisible { get; set; }

	// Token: 0x1700175C RID: 5980
	// (get) Token: 0x06011F30 RID: 73520 RVA: 0x00467C88 File Offset: 0x00465E88
	// (set) Token: 0x06011F31 RID: 73521 RVA: 0x00467C90 File Offset: 0x00465E90
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700175D RID: 5981
	// (get) Token: 0x06011F32 RID: 73522 RVA: 0x00467C99 File Offset: 0x00465E99
	// (set) Token: 0x06011F33 RID: 73523 RVA: 0x00467CA1 File Offset: 0x00465EA1
	public string NowPriceTextColor { get; set; } = "";

	// Token: 0x1700175E RID: 5982
	// (get) Token: 0x06011F34 RID: 73524 RVA: 0x00467CAA File Offset: 0x00465EAA
	// (set) Token: 0x06011F35 RID: 73525 RVA: 0x00467CB2 File Offset: 0x00465EB2
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700175F RID: 5983
	// (get) Token: 0x06011F36 RID: 73526 RVA: 0x00467CBB File Offset: 0x00465EBB
	// (set) Token: 0x06011F37 RID: 73527 RVA: 0x00467CC3 File Offset: 0x00465EC3
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x17001760 RID: 5984
	// (get) Token: 0x06011F38 RID: 73528 RVA: 0x00467CCC File Offset: 0x00465ECC
	// (set) Token: 0x06011F39 RID: 73529 RVA: 0x00467CD4 File Offset: 0x00465ED4
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001761 RID: 5985
	// (get) Token: 0x06011F3A RID: 73530 RVA: 0x00467CDD File Offset: 0x00465EDD
	// (set) Token: 0x06011F3B RID: 73531 RVA: 0x00467CE5 File Offset: 0x00465EE5
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x17001762 RID: 5986
	// (get) Token: 0x06011F3C RID: 73532 RVA: 0x00467CEE File Offset: 0x00465EEE
	// (set) Token: 0x06011F3D RID: 73533 RVA: 0x00467CF6 File Offset: 0x00465EF6
	public bool RedDotVisible { get; set; }

	// Token: 0x17001763 RID: 5987
	// (get) Token: 0x06011F3E RID: 73534 RVA: 0x00467CFF File Offset: 0x00465EFF
	// (set) Token: 0x06011F3F RID: 73535 RVA: 0x00467D07 File Offset: 0x00465F07
	public bool ItemBgItemVisible { get; set; }

	// Token: 0x17001764 RID: 5988
	// (get) Token: 0x06011F40 RID: 73536 RVA: 0x00467D10 File Offset: 0x00465F10
	// (set) Token: 0x06011F41 RID: 73537 RVA: 0x00467D18 File Offset: 0x00465F18
	public bool RaycastTarget { get; set; }

	// Token: 0x17001765 RID: 5989
	// (get) Token: 0x06011F42 RID: 73538 RVA: 0x00467D21 File Offset: 0x00465F21
	// (set) Token: 0x06011F43 RID: 73539 RVA: 0x00467D29 File Offset: 0x00465F29
	public GameplayShopTextData DiscountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001766 RID: 5990
	// (get) Token: 0x06011F44 RID: 73540 RVA: 0x00467D32 File Offset: 0x00465F32
	// (set) Token: 0x06011F45 RID: 73541 RVA: 0x00467D3A File Offset: 0x00465F3A
	public bool DiscountItemVisible { get; set; }

	// Token: 0x17001767 RID: 5991
	// (get) Token: 0x06011F46 RID: 73542 RVA: 0x00467D43 File Offset: 0x00465F43
	// (set) Token: 0x06011F47 RID: 73543 RVA: 0x00467D4B File Offset: 0x00465F4B
	public GameplayShopTextData LabelTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001768 RID: 5992
	// (get) Token: 0x06011F48 RID: 73544 RVA: 0x00467D54 File Offset: 0x00465F54
	// (set) Token: 0x06011F49 RID: 73545 RVA: 0x00467D5C File Offset: 0x00465F5C
	public bool LabelVisible { get; set; }

	// Token: 0x17001769 RID: 5993
	// (get) Token: 0x06011F4A RID: 73546 RVA: 0x00467D65 File Offset: 0x00465F65
	// (set) Token: 0x06011F4B RID: 73547 RVA: 0x00467D6D File Offset: 0x00465F6D
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700176A RID: 5994
	// (get) Token: 0x06011F4C RID: 73548 RVA: 0x00467D76 File Offset: 0x00465F76
	// (set) Token: 0x06011F4D RID: 73549 RVA: 0x00467D7E File Offset: 0x00465F7E
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x1700176B RID: 5995
	// (get) Token: 0x06011F4E RID: 73550 RVA: 0x00467D87 File Offset: 0x00465F87
	// (set) Token: 0x06011F4F RID: 73551 RVA: 0x00467D8F File Offset: 0x00465F8F
	public GameplayShopTextData ReSellTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700176C RID: 5996
	// (get) Token: 0x06011F50 RID: 73552 RVA: 0x00467D98 File Offset: 0x00465F98
	// (set) Token: 0x06011F51 RID: 73553 RVA: 0x00467DA0 File Offset: 0x00465FA0
	public bool ReSellItemVisible { get; set; }

	// Token: 0x1700176D RID: 5997
	// (get) Token: 0x06011F52 RID: 73554 RVA: 0x00467DA9 File Offset: 0x00465FA9
	// (set) Token: 0x06011F53 RID: 73555 RVA: 0x00467DB1 File Offset: 0x00465FB1
	public GameplayShopTextData SoldOutTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700176E RID: 5998
	// (get) Token: 0x06011F54 RID: 73556 RVA: 0x00467DBA File Offset: 0x00465FBA
	// (set) Token: 0x06011F55 RID: 73557 RVA: 0x00467DC2 File Offset: 0x00465FC2
	public bool SoldOutItemVisible { get; set; }

	// Token: 0x1700176F RID: 5999
	// (get) Token: 0x06011F56 RID: 73558 RVA: 0x00467DCB File Offset: 0x00465FCB
	// (set) Token: 0x06011F57 RID: 73559 RVA: 0x00467DD3 File Offset: 0x00465FD3
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001770 RID: 6000
	// (get) Token: 0x06011F58 RID: 73560 RVA: 0x00467DDC File Offset: 0x00465FDC
	// (set) Token: 0x06011F59 RID: 73561 RVA: 0x00467DE4 File Offset: 0x00465FE4
	public bool LockItemVisible { get; set; }

	// Token: 0x17001771 RID: 6001
	// (get) Token: 0x06011F5A RID: 73562 RVA: 0x00467DED File Offset: 0x00465FED
	// (set) Token: 0x06011F5B RID: 73563 RVA: 0x00467DF5 File Offset: 0x00465FF5
	public bool TagNewItemVisible { get; set; }

	// Token: 0x06011F5C RID: 73564 RVA: 0x00467DFE File Offset: 0x00465FFE
	public virtual void OnTipsButtonClick()
	{
	}

	// Token: 0x06011F5D RID: 73565 RVA: 0x00467E00 File Offset: 0x00466000
	public virtual void OnBuyButtonClick()
	{
	}
}
