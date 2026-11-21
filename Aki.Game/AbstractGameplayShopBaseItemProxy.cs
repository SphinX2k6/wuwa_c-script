using System;
using System.Runtime.CompilerServices;

// Token: 0x0200181F RID: 6175
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopBaseItemProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x17001701 RID: 5889
	// (get) Token: 0x0600F256 RID: 62038 RVA: 0x004730B6 File Offset: 0x004712B6
	// (set) Token: 0x0600F257 RID: 62039 RVA: 0x004730BE File Offset: 0x004712BE
	public int CurrencyId { get; set; }

	// Token: 0x17001702 RID: 5890
	// (get) Token: 0x0600F258 RID: 62040 RVA: 0x004730C7 File Offset: 0x004712C7
	// (set) Token: 0x0600F259 RID: 62041 RVA: 0x004730CF File Offset: 0x004712CF
	public int ItemId { get; set; }

	// Token: 0x17001703 RID: 5891
	// (get) Token: 0x0600F25A RID: 62042 RVA: 0x004730D8 File Offset: 0x004712D8
	// (set) Token: 0x0600F25B RID: 62043 RVA: 0x004730E0 File Offset: 0x004712E0
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x17001704 RID: 5892
	// (get) Token: 0x0600F25C RID: 62044 RVA: 0x004730E9 File Offset: 0x004712E9
	// (set) Token: 0x0600F25D RID: 62045 RVA: 0x004730F1 File Offset: 0x004712F1
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x17001705 RID: 5893
	// (get) Token: 0x0600F25E RID: 62046 RVA: 0x004730FA File Offset: 0x004712FA
	// (set) Token: 0x0600F25F RID: 62047 RVA: 0x00473102 File Offset: 0x00471302
	public bool ItemTextureVisible { get; set; } = true;

	// Token: 0x17001706 RID: 5894
	// (get) Token: 0x0600F260 RID: 62048 RVA: 0x0047310B File Offset: 0x0047130B
	// (set) Token: 0x0600F261 RID: 62049 RVA: 0x00473113 File Offset: 0x00471313
	public virtual string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x17001707 RID: 5895
	// (get) Token: 0x0600F262 RID: 62050 RVA: 0x0047311C File Offset: 0x0047131C
	// (set) Token: 0x0600F263 RID: 62051 RVA: 0x00473124 File Offset: 0x00471324
	public virtual bool BigItemIconVisible { get; set; }

	// Token: 0x17001708 RID: 5896
	// (get) Token: 0x0600F264 RID: 62052 RVA: 0x0047312D File Offset: 0x0047132D
	// (set) Token: 0x0600F265 RID: 62053 RVA: 0x00473135 File Offset: 0x00471335
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001709 RID: 5897
	// (get) Token: 0x0600F266 RID: 62054 RVA: 0x0047313E File Offset: 0x0047133E
	// (set) Token: 0x0600F267 RID: 62055 RVA: 0x00473146 File Offset: 0x00471346
	public bool TipsButtonVisible { get; set; }

	// Token: 0x1700170A RID: 5898
	// (get) Token: 0x0600F268 RID: 62056 RVA: 0x0047314F File Offset: 0x0047134F
	// (set) Token: 0x0600F269 RID: 62057 RVA: 0x00473157 File Offset: 0x00471357
	public bool BottomBgVisible { get; set; } = true;

	// Token: 0x1700170B RID: 5899
	// (get) Token: 0x0600F26A RID: 62058 RVA: 0x00473160 File Offset: 0x00471360
	// (set) Token: 0x0600F26B RID: 62059 RVA: 0x00473168 File Offset: 0x00471368
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700170C RID: 5900
	// (get) Token: 0x0600F26C RID: 62060 RVA: 0x00473171 File Offset: 0x00471371
	// (set) Token: 0x0600F26D RID: 62061 RVA: 0x00473179 File Offset: 0x00471379
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x1700170D RID: 5901
	// (get) Token: 0x0600F26E RID: 62062 RVA: 0x00473182 File Offset: 0x00471382
	// (set) Token: 0x0600F26F RID: 62063 RVA: 0x0047318A File Offset: 0x0047138A
	public bool PriceItemVisible { get; set; } = true;

	// Token: 0x1700170E RID: 5902
	// (get) Token: 0x0600F270 RID: 62064 RVA: 0x00473193 File Offset: 0x00471393
	// (set) Token: 0x0600F271 RID: 62065 RVA: 0x0047319B File Offset: 0x0047139B
	public bool CurrencyIconVisible { get; set; } = true;

	// Token: 0x1700170F RID: 5903
	// (get) Token: 0x0600F272 RID: 62066 RVA: 0x004731A4 File Offset: 0x004713A4
	// (set) Token: 0x0600F273 RID: 62067 RVA: 0x004731AC File Offset: 0x004713AC
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001710 RID: 5904
	// (get) Token: 0x0600F274 RID: 62068 RVA: 0x004731B5 File Offset: 0x004713B5
	// (set) Token: 0x0600F275 RID: 62069 RVA: 0x004731BD File Offset: 0x004713BD
	public string NowPriceTextColor { get; set; } = "000000FF";

	// Token: 0x17001711 RID: 5905
	// (get) Token: 0x0600F276 RID: 62070 RVA: 0x004731C6 File Offset: 0x004713C6
	// (set) Token: 0x0600F277 RID: 62071 RVA: 0x004731CE File Offset: 0x004713CE
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001712 RID: 5906
	// (get) Token: 0x0600F278 RID: 62072 RVA: 0x004731D7 File Offset: 0x004713D7
	// (set) Token: 0x0600F279 RID: 62073 RVA: 0x004731DF File Offset: 0x004713DF
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x17001713 RID: 5907
	// (get) Token: 0x0600F27A RID: 62074 RVA: 0x004731E8 File Offset: 0x004713E8
	// (set) Token: 0x0600F27B RID: 62075 RVA: 0x004731F0 File Offset: 0x004713F0
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001714 RID: 5908
	// (get) Token: 0x0600F27C RID: 62076 RVA: 0x004731F9 File Offset: 0x004713F9
	// (set) Token: 0x0600F27D RID: 62077 RVA: 0x00473201 File Offset: 0x00471401
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x17001715 RID: 5909
	// (get) Token: 0x0600F27E RID: 62078 RVA: 0x0047320A File Offset: 0x0047140A
	// (set) Token: 0x0600F27F RID: 62079 RVA: 0x00473212 File Offset: 0x00471412
	public bool RedDotVisible { get; set; }

	// Token: 0x17001716 RID: 5910
	// (get) Token: 0x0600F280 RID: 62080 RVA: 0x0047321B File Offset: 0x0047141B
	// (set) Token: 0x0600F281 RID: 62081 RVA: 0x00473223 File Offset: 0x00471423
	public virtual bool ItemBgItemVisible { get; set; } = true;

	// Token: 0x17001717 RID: 5911
	// (get) Token: 0x0600F282 RID: 62082 RVA: 0x0047322C File Offset: 0x0047142C
	// (set) Token: 0x0600F283 RID: 62083 RVA: 0x00473234 File Offset: 0x00471434
	public bool RaycastTarget { get; set; } = true;

	// Token: 0x0600F284 RID: 62084 RVA: 0x0047323D File Offset: 0x0047143D
	public virtual void OnTipsButtonClick()
	{
	}
}
