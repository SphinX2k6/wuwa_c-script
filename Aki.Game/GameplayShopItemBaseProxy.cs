using System;
using System.Runtime.CompilerServices;

// Token: 0x0200182A RID: 6186
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopItemBaseProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x17001771 RID: 6001
	// (get) Token: 0x0600F394 RID: 62356 RVA: 0x00474A63 File Offset: 0x00472C63
	// (set) Token: 0x0600F395 RID: 62357 RVA: 0x00474A6B File Offset: 0x00472C6B
	public int CurrencyId { get; set; }

	// Token: 0x17001772 RID: 6002
	// (get) Token: 0x0600F396 RID: 62358 RVA: 0x00474A74 File Offset: 0x00472C74
	// (set) Token: 0x0600F397 RID: 62359 RVA: 0x00474A7C File Offset: 0x00472C7C
	public int ItemId { get; set; }

	// Token: 0x17001773 RID: 6003
	// (get) Token: 0x0600F398 RID: 62360 RVA: 0x00474A85 File Offset: 0x00472C85
	// (set) Token: 0x0600F399 RID: 62361 RVA: 0x00474A8D File Offset: 0x00472C8D
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x17001774 RID: 6004
	// (get) Token: 0x0600F39A RID: 62362 RVA: 0x00474A96 File Offset: 0x00472C96
	// (set) Token: 0x0600F39B RID: 62363 RVA: 0x00474A9E File Offset: 0x00472C9E
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x17001775 RID: 6005
	// (get) Token: 0x0600F39C RID: 62364 RVA: 0x00474AA7 File Offset: 0x00472CA7
	// (set) Token: 0x0600F39D RID: 62365 RVA: 0x00474AAF File Offset: 0x00472CAF
	public bool ItemTextureVisible { get; set; }

	// Token: 0x17001776 RID: 6006
	// (get) Token: 0x0600F39E RID: 62366 RVA: 0x00474AB8 File Offset: 0x00472CB8
	// (set) Token: 0x0600F39F RID: 62367 RVA: 0x00474AC0 File Offset: 0x00472CC0
	public string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x17001777 RID: 6007
	// (get) Token: 0x0600F3A0 RID: 62368 RVA: 0x00474AC9 File Offset: 0x00472CC9
	// (set) Token: 0x0600F3A1 RID: 62369 RVA: 0x00474AD1 File Offset: 0x00472CD1
	public bool BigItemIconVisible { get; set; }

	// Token: 0x17001778 RID: 6008
	// (get) Token: 0x0600F3A2 RID: 62370 RVA: 0x00474ADA File Offset: 0x00472CDA
	// (set) Token: 0x0600F3A3 RID: 62371 RVA: 0x00474AE2 File Offset: 0x00472CE2
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001779 RID: 6009
	// (get) Token: 0x0600F3A4 RID: 62372 RVA: 0x00474AEB File Offset: 0x00472CEB
	// (set) Token: 0x0600F3A5 RID: 62373 RVA: 0x00474AF3 File Offset: 0x00472CF3
	public bool TipsButtonVisible { get; set; }

	// Token: 0x1700177A RID: 6010
	// (get) Token: 0x0600F3A6 RID: 62374 RVA: 0x00474AFC File Offset: 0x00472CFC
	// (set) Token: 0x0600F3A7 RID: 62375 RVA: 0x00474B04 File Offset: 0x00472D04
	public bool BottomBgVisible { get; set; }

	// Token: 0x1700177B RID: 6011
	// (get) Token: 0x0600F3A8 RID: 62376 RVA: 0x00474B0D File Offset: 0x00472D0D
	// (set) Token: 0x0600F3A9 RID: 62377 RVA: 0x00474B15 File Offset: 0x00472D15
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700177C RID: 6012
	// (get) Token: 0x0600F3AA RID: 62378 RVA: 0x00474B1E File Offset: 0x00472D1E
	// (set) Token: 0x0600F3AB RID: 62379 RVA: 0x00474B26 File Offset: 0x00472D26
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x1700177D RID: 6013
	// (get) Token: 0x0600F3AC RID: 62380 RVA: 0x00474B2F File Offset: 0x00472D2F
	// (set) Token: 0x0600F3AD RID: 62381 RVA: 0x00474B37 File Offset: 0x00472D37
	public bool PriceItemVisible { get; set; }

	// Token: 0x1700177E RID: 6014
	// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x00474B40 File Offset: 0x00472D40
	// (set) Token: 0x0600F3AF RID: 62383 RVA: 0x00474B48 File Offset: 0x00472D48
	public bool CurrencyIconVisible { get; set; }

	// Token: 0x1700177F RID: 6015
	// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x00474B51 File Offset: 0x00472D51
	// (set) Token: 0x0600F3B1 RID: 62385 RVA: 0x00474B59 File Offset: 0x00472D59
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001780 RID: 6016
	// (get) Token: 0x0600F3B2 RID: 62386 RVA: 0x00474B62 File Offset: 0x00472D62
	// (set) Token: 0x0600F3B3 RID: 62387 RVA: 0x00474B6A File Offset: 0x00472D6A
	public string NowPriceTextColor { get; set; } = "";

	// Token: 0x17001781 RID: 6017
	// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x00474B73 File Offset: 0x00472D73
	// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x00474B7B File Offset: 0x00472D7B
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001782 RID: 6018
	// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x00474B84 File Offset: 0x00472D84
	// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x00474B8C File Offset: 0x00472D8C
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x17001783 RID: 6019
	// (get) Token: 0x0600F3B8 RID: 62392 RVA: 0x00474B95 File Offset: 0x00472D95
	// (set) Token: 0x0600F3B9 RID: 62393 RVA: 0x00474B9D File Offset: 0x00472D9D
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001784 RID: 6020
	// (get) Token: 0x0600F3BA RID: 62394 RVA: 0x00474BA6 File Offset: 0x00472DA6
	// (set) Token: 0x0600F3BB RID: 62395 RVA: 0x00474BAE File Offset: 0x00472DAE
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x17001785 RID: 6021
	// (get) Token: 0x0600F3BC RID: 62396 RVA: 0x00474BB7 File Offset: 0x00472DB7
	// (set) Token: 0x0600F3BD RID: 62397 RVA: 0x00474BBF File Offset: 0x00472DBF
	public bool RedDotVisible { get; set; }

	// Token: 0x17001786 RID: 6022
	// (get) Token: 0x0600F3BE RID: 62398 RVA: 0x00474BC8 File Offset: 0x00472DC8
	// (set) Token: 0x0600F3BF RID: 62399 RVA: 0x00474BD0 File Offset: 0x00472DD0
	public bool ItemBgItemVisible { get; set; }

	// Token: 0x17001787 RID: 6023
	// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x00474BD9 File Offset: 0x00472DD9
	// (set) Token: 0x0600F3C1 RID: 62401 RVA: 0x00474BE1 File Offset: 0x00472DE1
	public bool RaycastTarget { get; set; }

	// Token: 0x0600F3C2 RID: 62402 RVA: 0x00474BEA File Offset: 0x00472DEA
	public virtual void OnTipsButtonClick()
	{
	}
}
