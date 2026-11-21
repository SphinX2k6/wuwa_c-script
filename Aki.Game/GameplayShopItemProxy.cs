using System;
using System.Runtime.CompilerServices;

// Token: 0x0200182B RID: 6187
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopItemProxy : IGameplayShopItemProxy, IGameplayShopItemBaseProxy
{
	// Token: 0x17001788 RID: 6024
	// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x00474C62 File Offset: 0x00472E62
	// (set) Token: 0x0600F3C5 RID: 62405 RVA: 0x00474C6A File Offset: 0x00472E6A
	public int CurrencyId { get; set; }

	// Token: 0x17001789 RID: 6025
	// (get) Token: 0x0600F3C6 RID: 62406 RVA: 0x00474C73 File Offset: 0x00472E73
	// (set) Token: 0x0600F3C7 RID: 62407 RVA: 0x00474C7B File Offset: 0x00472E7B
	public int ItemId { get; set; }

	// Token: 0x1700178A RID: 6026
	// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x00474C84 File Offset: 0x00472E84
	// (set) Token: 0x0600F3C9 RID: 62409 RVA: 0x00474C8C File Offset: 0x00472E8C
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x1700178B RID: 6027
	// (get) Token: 0x0600F3CA RID: 62410 RVA: 0x00474C95 File Offset: 0x00472E95
	// (set) Token: 0x0600F3CB RID: 62411 RVA: 0x00474C9D File Offset: 0x00472E9D
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x1700178C RID: 6028
	// (get) Token: 0x0600F3CC RID: 62412 RVA: 0x00474CA6 File Offset: 0x00472EA6
	// (set) Token: 0x0600F3CD RID: 62413 RVA: 0x00474CAE File Offset: 0x00472EAE
	public bool ItemTextureVisible { get; set; }

	// Token: 0x1700178D RID: 6029
	// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x00474CB7 File Offset: 0x00472EB7
	// (set) Token: 0x0600F3CF RID: 62415 RVA: 0x00474CBF File Offset: 0x00472EBF
	public string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x1700178E RID: 6030
	// (get) Token: 0x0600F3D0 RID: 62416 RVA: 0x00474CC8 File Offset: 0x00472EC8
	// (set) Token: 0x0600F3D1 RID: 62417 RVA: 0x00474CD0 File Offset: 0x00472ED0
	public bool BigItemIconVisible { get; set; }

	// Token: 0x1700178F RID: 6031
	// (get) Token: 0x0600F3D2 RID: 62418 RVA: 0x00474CD9 File Offset: 0x00472ED9
	// (set) Token: 0x0600F3D3 RID: 62419 RVA: 0x00474CE1 File Offset: 0x00472EE1
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001790 RID: 6032
	// (get) Token: 0x0600F3D4 RID: 62420 RVA: 0x00474CEA File Offset: 0x00472EEA
	// (set) Token: 0x0600F3D5 RID: 62421 RVA: 0x00474CF2 File Offset: 0x00472EF2
	public bool TipsButtonVisible { get; set; }

	// Token: 0x17001791 RID: 6033
	// (get) Token: 0x0600F3D6 RID: 62422 RVA: 0x00474CFB File Offset: 0x00472EFB
	// (set) Token: 0x0600F3D7 RID: 62423 RVA: 0x00474D03 File Offset: 0x00472F03
	public bool BottomBgVisible { get; set; }

	// Token: 0x17001792 RID: 6034
	// (get) Token: 0x0600F3D8 RID: 62424 RVA: 0x00474D0C File Offset: 0x00472F0C
	// (set) Token: 0x0600F3D9 RID: 62425 RVA: 0x00474D14 File Offset: 0x00472F14
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001793 RID: 6035
	// (get) Token: 0x0600F3DA RID: 62426 RVA: 0x00474D1D File Offset: 0x00472F1D
	// (set) Token: 0x0600F3DB RID: 62427 RVA: 0x00474D25 File Offset: 0x00472F25
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x17001794 RID: 6036
	// (get) Token: 0x0600F3DC RID: 62428 RVA: 0x00474D2E File Offset: 0x00472F2E
	// (set) Token: 0x0600F3DD RID: 62429 RVA: 0x00474D36 File Offset: 0x00472F36
	public bool PriceItemVisible { get; set; }

	// Token: 0x17001795 RID: 6037
	// (get) Token: 0x0600F3DE RID: 62430 RVA: 0x00474D3F File Offset: 0x00472F3F
	// (set) Token: 0x0600F3DF RID: 62431 RVA: 0x00474D47 File Offset: 0x00472F47
	public bool CurrencyIconVisible { get; set; }

	// Token: 0x17001796 RID: 6038
	// (get) Token: 0x0600F3E0 RID: 62432 RVA: 0x00474D50 File Offset: 0x00472F50
	// (set) Token: 0x0600F3E1 RID: 62433 RVA: 0x00474D58 File Offset: 0x00472F58
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001797 RID: 6039
	// (get) Token: 0x0600F3E2 RID: 62434 RVA: 0x00474D61 File Offset: 0x00472F61
	// (set) Token: 0x0600F3E3 RID: 62435 RVA: 0x00474D69 File Offset: 0x00472F69
	public string NowPriceTextColor { get; set; } = "";

	// Token: 0x17001798 RID: 6040
	// (get) Token: 0x0600F3E4 RID: 62436 RVA: 0x00474D72 File Offset: 0x00472F72
	// (set) Token: 0x0600F3E5 RID: 62437 RVA: 0x00474D7A File Offset: 0x00472F7A
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001799 RID: 6041
	// (get) Token: 0x0600F3E6 RID: 62438 RVA: 0x00474D83 File Offset: 0x00472F83
	// (set) Token: 0x0600F3E7 RID: 62439 RVA: 0x00474D8B File Offset: 0x00472F8B
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x1700179A RID: 6042
	// (get) Token: 0x0600F3E8 RID: 62440 RVA: 0x00474D94 File Offset: 0x00472F94
	// (set) Token: 0x0600F3E9 RID: 62441 RVA: 0x00474D9C File Offset: 0x00472F9C
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700179B RID: 6043
	// (get) Token: 0x0600F3EA RID: 62442 RVA: 0x00474DA5 File Offset: 0x00472FA5
	// (set) Token: 0x0600F3EB RID: 62443 RVA: 0x00474DAD File Offset: 0x00472FAD
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x1700179C RID: 6044
	// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x00474DB6 File Offset: 0x00472FB6
	// (set) Token: 0x0600F3ED RID: 62445 RVA: 0x00474DBE File Offset: 0x00472FBE
	public bool RedDotVisible { get; set; }

	// Token: 0x1700179D RID: 6045
	// (get) Token: 0x0600F3EE RID: 62446 RVA: 0x00474DC7 File Offset: 0x00472FC7
	// (set) Token: 0x0600F3EF RID: 62447 RVA: 0x00474DCF File Offset: 0x00472FCF
	public bool ItemBgItemVisible { get; set; }

	// Token: 0x1700179E RID: 6046
	// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x00474DD8 File Offset: 0x00472FD8
	// (set) Token: 0x0600F3F1 RID: 62449 RVA: 0x00474DE0 File Offset: 0x00472FE0
	public bool RaycastTarget { get; set; }

	// Token: 0x1700179F RID: 6047
	// (get) Token: 0x0600F3F2 RID: 62450 RVA: 0x00474DE9 File Offset: 0x00472FE9
	// (set) Token: 0x0600F3F3 RID: 62451 RVA: 0x00474DF1 File Offset: 0x00472FF1
	public GameplayShopTextData DiscountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017A0 RID: 6048
	// (get) Token: 0x0600F3F4 RID: 62452 RVA: 0x00474DFA File Offset: 0x00472FFA
	// (set) Token: 0x0600F3F5 RID: 62453 RVA: 0x00474E02 File Offset: 0x00473002
	public bool DiscountItemVisible { get; set; }

	// Token: 0x170017A1 RID: 6049
	// (get) Token: 0x0600F3F6 RID: 62454 RVA: 0x00474E0B File Offset: 0x0047300B
	// (set) Token: 0x0600F3F7 RID: 62455 RVA: 0x00474E13 File Offset: 0x00473013
	public GameplayShopTextData LabelTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017A2 RID: 6050
	// (get) Token: 0x0600F3F8 RID: 62456 RVA: 0x00474E1C File Offset: 0x0047301C
	// (set) Token: 0x0600F3F9 RID: 62457 RVA: 0x00474E24 File Offset: 0x00473024
	public bool LabelVisible { get; set; }

	// Token: 0x170017A3 RID: 6051
	// (get) Token: 0x0600F3FA RID: 62458 RVA: 0x00474E2D File Offset: 0x0047302D
	// (set) Token: 0x0600F3FB RID: 62459 RVA: 0x00474E35 File Offset: 0x00473035
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017A4 RID: 6052
	// (get) Token: 0x0600F3FC RID: 62460 RVA: 0x00474E3E File Offset: 0x0047303E
	// (set) Token: 0x0600F3FD RID: 62461 RVA: 0x00474E46 File Offset: 0x00473046
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x170017A5 RID: 6053
	// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x00474E4F File Offset: 0x0047304F
	// (set) Token: 0x0600F3FF RID: 62463 RVA: 0x00474E57 File Offset: 0x00473057
	public GameplayShopTextData ReSellTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017A6 RID: 6054
	// (get) Token: 0x0600F400 RID: 62464 RVA: 0x00474E60 File Offset: 0x00473060
	// (set) Token: 0x0600F401 RID: 62465 RVA: 0x00474E68 File Offset: 0x00473068
	public bool ReSellItemVisible { get; set; }

	// Token: 0x170017A7 RID: 6055
	// (get) Token: 0x0600F402 RID: 62466 RVA: 0x00474E71 File Offset: 0x00473071
	// (set) Token: 0x0600F403 RID: 62467 RVA: 0x00474E79 File Offset: 0x00473079
	public GameplayShopTextData SoldOutTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017A8 RID: 6056
	// (get) Token: 0x0600F404 RID: 62468 RVA: 0x00474E82 File Offset: 0x00473082
	// (set) Token: 0x0600F405 RID: 62469 RVA: 0x00474E8A File Offset: 0x0047308A
	public bool SoldOutItemVisible { get; set; }

	// Token: 0x170017A9 RID: 6057
	// (get) Token: 0x0600F406 RID: 62470 RVA: 0x00474E93 File Offset: 0x00473093
	// (set) Token: 0x0600F407 RID: 62471 RVA: 0x00474E9B File Offset: 0x0047309B
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170017AA RID: 6058
	// (get) Token: 0x0600F408 RID: 62472 RVA: 0x00474EA4 File Offset: 0x004730A4
	// (set) Token: 0x0600F409 RID: 62473 RVA: 0x00474EAC File Offset: 0x004730AC
	public bool LockItemVisible { get; set; }

	// Token: 0x170017AB RID: 6059
	// (get) Token: 0x0600F40A RID: 62474 RVA: 0x00474EB5 File Offset: 0x004730B5
	// (set) Token: 0x0600F40B RID: 62475 RVA: 0x00474EBD File Offset: 0x004730BD
	public bool TagNewItemVisible { get; set; }

	// Token: 0x0600F40C RID: 62476 RVA: 0x00474EC6 File Offset: 0x004730C6
	public virtual void OnTipsButtonClick()
	{
	}

	// Token: 0x0600F40D RID: 62477 RVA: 0x00474EC8 File Offset: 0x004730C8
	public virtual void OnBuyButtonClick()
	{
	}
}
