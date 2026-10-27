using System;
using System.Runtime.CompilerServices;

// Token: 0x0200233A RID: 9018
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopBaseItemProxy : IGameplayShopItemBaseProxy
{
	// Token: 0x170016C7 RID: 5831
	// (get) Token: 0x06011DA6 RID: 73126 RVA: 0x00465FEE File Offset: 0x004641EE
	// (set) Token: 0x06011DA7 RID: 73127 RVA: 0x00465FF6 File Offset: 0x004641F6
	public int CurrencyId { get; set; }

	// Token: 0x170016C8 RID: 5832
	// (get) Token: 0x06011DA8 RID: 73128 RVA: 0x00465FFF File Offset: 0x004641FF
	// (set) Token: 0x06011DA9 RID: 73129 RVA: 0x00466007 File Offset: 0x00464207
	public int ItemId { get; set; }

	// Token: 0x170016C9 RID: 5833
	// (get) Token: 0x06011DAA RID: 73130 RVA: 0x00466010 File Offset: 0x00464210
	// (set) Token: 0x06011DAB RID: 73131 RVA: 0x00466018 File Offset: 0x00464218
	public string QualitySpritePath { get; set; } = "";

	// Token: 0x170016CA RID: 5834
	// (get) Token: 0x06011DAC RID: 73132 RVA: 0x00466021 File Offset: 0x00464221
	// (set) Token: 0x06011DAD RID: 73133 RVA: 0x00466029 File Offset: 0x00464229
	public string ItemTexturePath { get; set; } = "";

	// Token: 0x170016CB RID: 5835
	// (get) Token: 0x06011DAE RID: 73134 RVA: 0x00466032 File Offset: 0x00464232
	// (set) Token: 0x06011DAF RID: 73135 RVA: 0x0046603A File Offset: 0x0046423A
	public bool ItemTextureVisible { get; set; } = true;

	// Token: 0x170016CC RID: 5836
	// (get) Token: 0x06011DB0 RID: 73136 RVA: 0x00466043 File Offset: 0x00464243
	// (set) Token: 0x06011DB1 RID: 73137 RVA: 0x0046604B File Offset: 0x0046424B
	public virtual string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x170016CD RID: 5837
	// (get) Token: 0x06011DB2 RID: 73138 RVA: 0x00466054 File Offset: 0x00464254
	// (set) Token: 0x06011DB3 RID: 73139 RVA: 0x0046605C File Offset: 0x0046425C
	public virtual bool BigItemIconVisible { get; set; }

	// Token: 0x170016CE RID: 5838
	// (get) Token: 0x06011DB4 RID: 73140 RVA: 0x00466065 File Offset: 0x00464265
	// (set) Token: 0x06011DB5 RID: 73141 RVA: 0x0046606D File Offset: 0x0046426D
	public GameplayShopTextData ItemNameTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016CF RID: 5839
	// (get) Token: 0x06011DB6 RID: 73142 RVA: 0x00466076 File Offset: 0x00464276
	// (set) Token: 0x06011DB7 RID: 73143 RVA: 0x0046607E File Offset: 0x0046427E
	public bool TipsButtonVisible { get; set; }

	// Token: 0x170016D0 RID: 5840
	// (get) Token: 0x06011DB8 RID: 73144 RVA: 0x00466087 File Offset: 0x00464287
	// (set) Token: 0x06011DB9 RID: 73145 RVA: 0x0046608F File Offset: 0x0046428F
	public bool BottomBgVisible { get; set; } = true;

	// Token: 0x170016D1 RID: 5841
	// (get) Token: 0x06011DBA RID: 73146 RVA: 0x00466098 File Offset: 0x00464298
	// (set) Token: 0x06011DBB RID: 73147 RVA: 0x004660A0 File Offset: 0x004642A0
	public GameplayShopTextData BuyLimitCountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016D2 RID: 5842
	// (get) Token: 0x06011DBC RID: 73148 RVA: 0x004660A9 File Offset: 0x004642A9
	// (set) Token: 0x06011DBD RID: 73149 RVA: 0x004660B1 File Offset: 0x004642B1
	public bool BuyLimitCountTextVisible { get; set; }

	// Token: 0x170016D3 RID: 5843
	// (get) Token: 0x06011DBE RID: 73150 RVA: 0x004660BA File Offset: 0x004642BA
	// (set) Token: 0x06011DBF RID: 73151 RVA: 0x004660C2 File Offset: 0x004642C2
	public bool PriceItemVisible { get; set; } = true;

	// Token: 0x170016D4 RID: 5844
	// (get) Token: 0x06011DC0 RID: 73152 RVA: 0x004660CB File Offset: 0x004642CB
	// (set) Token: 0x06011DC1 RID: 73153 RVA: 0x004660D3 File Offset: 0x004642D3
	public bool CurrencyIconVisible { get; set; } = true;

	// Token: 0x170016D5 RID: 5845
	// (get) Token: 0x06011DC2 RID: 73154 RVA: 0x004660DC File Offset: 0x004642DC
	// (set) Token: 0x06011DC3 RID: 73155 RVA: 0x004660E4 File Offset: 0x004642E4
	public GameplayShopTextData NowPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016D6 RID: 5846
	// (get) Token: 0x06011DC4 RID: 73156 RVA: 0x004660ED File Offset: 0x004642ED
	// (set) Token: 0x06011DC5 RID: 73157 RVA: 0x004660F5 File Offset: 0x004642F5
	public string NowPriceTextColor { get; set; } = "000000FF";

	// Token: 0x170016D7 RID: 5847
	// (get) Token: 0x06011DC6 RID: 73158 RVA: 0x004660FE File Offset: 0x004642FE
	// (set) Token: 0x06011DC7 RID: 73159 RVA: 0x00466106 File Offset: 0x00464306
	public GameplayShopTextData OriginalPriceTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016D8 RID: 5848
	// (get) Token: 0x06011DC8 RID: 73160 RVA: 0x0046610F File Offset: 0x0046430F
	// (set) Token: 0x06011DC9 RID: 73161 RVA: 0x00466117 File Offset: 0x00464317
	public bool OriginalPriceVisible { get; set; }

	// Token: 0x170016D9 RID: 5849
	// (get) Token: 0x06011DCA RID: 73162 RVA: 0x00466120 File Offset: 0x00464320
	// (set) Token: 0x06011DCB RID: 73163 RVA: 0x00466128 File Offset: 0x00464328
	public GameplayShopTextData PriceTipsTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016DA RID: 5850
	// (get) Token: 0x06011DCC RID: 73164 RVA: 0x00466131 File Offset: 0x00464331
	// (set) Token: 0x06011DCD RID: 73165 RVA: 0x00466139 File Offset: 0x00464339
	public bool PriceTipsTextVisible { get; set; }

	// Token: 0x170016DB RID: 5851
	// (get) Token: 0x06011DCE RID: 73166 RVA: 0x00466142 File Offset: 0x00464342
	// (set) Token: 0x06011DCF RID: 73167 RVA: 0x0046614A File Offset: 0x0046434A
	public bool RedDotVisible { get; set; }

	// Token: 0x170016DC RID: 5852
	// (get) Token: 0x06011DD0 RID: 73168 RVA: 0x00466153 File Offset: 0x00464353
	// (set) Token: 0x06011DD1 RID: 73169 RVA: 0x0046615B File Offset: 0x0046435B
	public virtual bool ItemBgItemVisible { get; set; } = true;

	// Token: 0x170016DD RID: 5853
	// (get) Token: 0x06011DD2 RID: 73170 RVA: 0x00466164 File Offset: 0x00464364
	// (set) Token: 0x06011DD3 RID: 73171 RVA: 0x0046616C File Offset: 0x0046436C
	public bool RaycastTarget { get; set; } = true;

	// Token: 0x06011DD4 RID: 73172 RVA: 0x00466175 File Offset: 0x00464375
	public virtual void OnTipsButtonClick()
	{
	}
}
