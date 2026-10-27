using System;
using System.Runtime.CompilerServices;

// Token: 0x02002345 RID: 9029
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopItemBaseProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x17001737 RID: 5943
	// (get) Token: 0x06011EE4 RID: 73444 RVA: 0x0046799B File Offset: 0x00465B9B
	// (set) Token: 0x06011EE5 RID: 73445 RVA: 0x004679A3 File Offset: 0x00465BA3
	public int CurrencyId { get; set; }

	// Token: 0x17001738 RID: 5944
	// (get) Token: 0x06011EE6 RID: 73446 RVA: 0x004679AC File Offset: 0x00465BAC
	// (set) Token: 0x06011EE7 RID: 73447 RVA: 0x004679B4 File Offset: 0x00465BB4
	public int ItemId { get; set; }

	// Token: 0x17001739 RID: 5945
	// (get) Token: 0x06011EE8 RID: 73448 RVA: 0x004679BD File Offset: 0x00465BBD
	// (set) Token: 0x06011EE9 RID: 73449 RVA: 0x004679C5 File Offset: 0x00465BC5
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x1700173A RID: 5946
	// (get) Token: 0x06011EEA RID: 73450 RVA: 0x004679CE File Offset: 0x00465BCE
	// (set) Token: 0x06011EEB RID: 73451 RVA: 0x004679D6 File Offset: 0x00465BD6
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x1700173B RID: 5947
	// (get) Token: 0x06011EEC RID: 73452 RVA: 0x004679DF File Offset: 0x00465BDF
	// (set) Token: 0x06011EED RID: 73453 RVA: 0x004679E7 File Offset: 0x00465BE7
	public bool ItemTextureVisible { get; set; }

	// Token: 0x1700173C RID: 5948
	// (get) Token: 0x06011EEE RID: 73454 RVA: 0x004679F0 File Offset: 0x00465BF0
	// (set) Token: 0x06011EEF RID: 73455 RVA: 0x004679F8 File Offset: 0x00465BF8
	public string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x1700173D RID: 5949
	// (get) Token: 0x06011EF0 RID: 73456 RVA: 0x00467A01 File Offset: 0x00465C01
	// (set) Token: 0x06011EF1 RID: 73457 RVA: 0x00467A09 File Offset: 0x00465C09
	public bool BigItemIconVisible { get; set; }

	// Token: 0x1700173E RID: 5950
	// (get) Token: 0x06011EF2 RID: 73458 RVA: 0x00467A12 File Offset: 0x00465C12
	// (set) Token: 0x06011EF3 RID: 73459 RVA: 0x00467A1A File Offset: 0x00465C1A
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700173F RID: 5951
	// (get) Token: 0x06011EF4 RID: 73460 RVA: 0x00467A23 File Offset: 0x00465C23
	// (set) Token: 0x06011EF5 RID: 73461 RVA: 0x00467A2B File Offset: 0x00465C2B
	public bool TipsButtonVisible { get; set; }

	// Token: 0x17001740 RID: 5952
	// (get) Token: 0x06011EF6 RID: 73462 RVA: 0x00467A34 File Offset: 0x00465C34
	// (set) Token: 0x06011EF7 RID: 73463 RVA: 0x00467A3C File Offset: 0x00465C3C
	public bool BottomBgVisible { get; set; }

	// Token: 0x17001741 RID: 5953
	// (get) Token: 0x06011EF8 RID: 73464 RVA: 0x00467A45 File Offset: 0x00465C45
	// (set) Token: 0x06011EF9 RID: 73465 RVA: 0x00467A4D File Offset: 0x00465C4D
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001742 RID: 5954
	// (get) Token: 0x06011EFA RID: 73466 RVA: 0x00467A56 File Offset: 0x00465C56
	// (set) Token: 0x06011EFB RID: 73467 RVA: 0x00467A5E File Offset: 0x00465C5E
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x17001743 RID: 5955
	// (get) Token: 0x06011EFC RID: 73468 RVA: 0x00467A67 File Offset: 0x00465C67
	// (set) Token: 0x06011EFD RID: 73469 RVA: 0x00467A6F File Offset: 0x00465C6F
	public bool PriceItemVisible { get; set; }

	// Token: 0x17001744 RID: 5956
	// (get) Token: 0x06011EFE RID: 73470 RVA: 0x00467A78 File Offset: 0x00465C78
	// (set) Token: 0x06011EFF RID: 73471 RVA: 0x00467A80 File Offset: 0x00465C80
	public bool CurrencyIconVisible { get; set; }

	// Token: 0x17001745 RID: 5957
	// (get) Token: 0x06011F00 RID: 73472 RVA: 0x00467A89 File Offset: 0x00465C89
	// (set) Token: 0x06011F01 RID: 73473 RVA: 0x00467A91 File Offset: 0x00465C91
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001746 RID: 5958
	// (get) Token: 0x06011F02 RID: 73474 RVA: 0x00467A9A File Offset: 0x00465C9A
	// (set) Token: 0x06011F03 RID: 73475 RVA: 0x00467AA2 File Offset: 0x00465CA2
	public string NowPriceTextColor { get; set; } = "";

	// Token: 0x17001747 RID: 5959
	// (get) Token: 0x06011F04 RID: 73476 RVA: 0x00467AAB File Offset: 0x00465CAB
	// (set) Token: 0x06011F05 RID: 73477 RVA: 0x00467AB3 File Offset: 0x00465CB3
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001748 RID: 5960
	// (get) Token: 0x06011F06 RID: 73478 RVA: 0x00467ABC File Offset: 0x00465CBC
	// (set) Token: 0x06011F07 RID: 73479 RVA: 0x00467AC4 File Offset: 0x00465CC4
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x17001749 RID: 5961
	// (get) Token: 0x06011F08 RID: 73480 RVA: 0x00467ACD File Offset: 0x00465CCD
	// (set) Token: 0x06011F09 RID: 73481 RVA: 0x00467AD5 File Offset: 0x00465CD5
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700174A RID: 5962
	// (get) Token: 0x06011F0A RID: 73482 RVA: 0x00467ADE File Offset: 0x00465CDE
	// (set) Token: 0x06011F0B RID: 73483 RVA: 0x00467AE6 File Offset: 0x00465CE6
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x1700174B RID: 5963
	// (get) Token: 0x06011F0C RID: 73484 RVA: 0x00467AEF File Offset: 0x00465CEF
	// (set) Token: 0x06011F0D RID: 73485 RVA: 0x00467AF7 File Offset: 0x00465CF7
	public bool RedDotVisible { get; set; }

	// Token: 0x1700174C RID: 5964
	// (get) Token: 0x06011F0E RID: 73486 RVA: 0x00467B00 File Offset: 0x00465D00
	// (set) Token: 0x06011F0F RID: 73487 RVA: 0x00467B08 File Offset: 0x00465D08
	public bool ItemBgItemVisible { get; set; }

	// Token: 0x1700174D RID: 5965
	// (get) Token: 0x06011F10 RID: 73488 RVA: 0x00467B11 File Offset: 0x00465D11
	// (set) Token: 0x06011F11 RID: 73489 RVA: 0x00467B19 File Offset: 0x00465D19
	public bool RaycastTarget { get; set; }

	// Token: 0x06011F12 RID: 73490 RVA: 0x00467B22 File Offset: 0x00465D22
	public virtual void OnTipsButtonClick()
	{
	}
}
