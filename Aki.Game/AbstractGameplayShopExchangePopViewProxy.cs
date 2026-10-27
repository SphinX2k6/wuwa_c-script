using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200233B RID: 9019
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopExchangePopViewProxy : IGameplayShopExchangePopViewProxy
{
	// Token: 0x170016DE RID: 5854
	// (get) Token: 0x06011DD6 RID: 73174 RVA: 0x00466218 File Offset: 0x00464418
	// (set) Token: 0x06011DD7 RID: 73175 RVA: 0x00466220 File Offset: 0x00464420
	[Nullable(2)]
	public object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170016DF RID: 5855
	// (get) Token: 0x06011DD8 RID: 73176 RVA: 0x00466229 File Offset: 0x00464429
	// (set) Token: 0x06011DD9 RID: 73177 RVA: 0x00466231 File Offset: 0x00464431
	public int CurrencyId { get; set; }

	// Token: 0x170016E0 RID: 5856
	// (get) Token: 0x06011DDA RID: 73178 RVA: 0x0046623A File Offset: 0x0046443A
	// (set) Token: 0x06011DDB RID: 73179 RVA: 0x00466242 File Offset: 0x00464442
	public List<int> CurrencyIdList { get; set; } = new List<int>();

	// Token: 0x170016E1 RID: 5857
	// (get) Token: 0x06011DDC RID: 73180 RVA: 0x0046624B File Offset: 0x0046444B
	// (set) Token: 0x06011DDD RID: 73181 RVA: 0x00466253 File Offset: 0x00464453
	public int Price { get; set; }

	// Token: 0x170016E2 RID: 5858
	// (get) Token: 0x06011DDE RID: 73182 RVA: 0x0046625C File Offset: 0x0046445C
	// (set) Token: 0x06011DDF RID: 73183 RVA: 0x00466264 File Offset: 0x00464464
	public GameplayShopTextData DescribeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016E3 RID: 5859
	// (get) Token: 0x06011DE0 RID: 73184 RVA: 0x0046626D File Offset: 0x0046446D
	// (set) Token: 0x06011DE1 RID: 73185 RVA: 0x00466275 File Offset: 0x00464475
	public bool TipTitleItemVisible { get; set; }

	// Token: 0x170016E4 RID: 5860
	// (get) Token: 0x06011DE2 RID: 73186 RVA: 0x0046627E File Offset: 0x0046447E
	// (set) Token: 0x06011DE3 RID: 73187 RVA: 0x00466286 File Offset: 0x00464486
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x170016E5 RID: 5861
	// (get) Token: 0x06011DE4 RID: 73188 RVA: 0x0046628F File Offset: 0x0046448F
	// (set) Token: 0x06011DE5 RID: 73189 RVA: 0x00466297 File Offset: 0x00464497
	public bool LeftTimeTextVisible { get; set; }

	// Token: 0x170016E6 RID: 5862
	// (get) Token: 0x06011DE6 RID: 73190 RVA: 0x004662A0 File Offset: 0x004644A0
	// (set) Token: 0x06011DE7 RID: 73191 RVA: 0x004662A8 File Offset: 0x004644A8
	public GameplayShopTextData LeftTimeDescTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016E7 RID: 5863
	// (get) Token: 0x06011DE8 RID: 73192 RVA: 0x004662B1 File Offset: 0x004644B1
	// (set) Token: 0x06011DE9 RID: 73193 RVA: 0x004662B9 File Offset: 0x004644B9
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016E8 RID: 5864
	// (get) Token: 0x06011DEA RID: 73194 RVA: 0x004662C2 File Offset: 0x004644C2
	// (set) Token: 0x06011DEB RID: 73195 RVA: 0x004662CA File Offset: 0x004644CA
	public bool LimitTextItemVisible { get; set; }

	// Token: 0x170016E9 RID: 5865
	// (get) Token: 0x06011DEC RID: 73196 RVA: 0x004662D3 File Offset: 0x004644D3
	// (set) Token: 0x06011DED RID: 73197 RVA: 0x004662DB File Offset: 0x004644DB
	public GameplayShopTextData LimitTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016EA RID: 5866
	// (get) Token: 0x06011DEE RID: 73198 RVA: 0x004662E4 File Offset: 0x004644E4
	// (set) Token: 0x06011DEF RID: 73199 RVA: 0x004662EC File Offset: 0x004644EC
	public bool LockItemVisible { get; set; }

	// Token: 0x170016EB RID: 5867
	// (get) Token: 0x06011DF0 RID: 73200 RVA: 0x004662F5 File Offset: 0x004644F5
	// (set) Token: 0x06011DF1 RID: 73201 RVA: 0x004662FD File Offset: 0x004644FD
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016EC RID: 5868
	// (get) Token: 0x06011DF2 RID: 73202 RVA: 0x00466306 File Offset: 0x00464506
	// (set) Token: 0x06011DF3 RID: 73203 RVA: 0x0046630E File Offset: 0x0046450E
	public int ReSellTime { get; set; }

	// Token: 0x170016ED RID: 5869
	// (get) Token: 0x06011DF4 RID: 73204 RVA: 0x00466317 File Offset: 0x00464517
	// (set) Token: 0x06011DF5 RID: 73205 RVA: 0x0046631F File Offset: 0x0046451F
	public int BuyCount { get; set; } = 1;

	// Token: 0x170016EE RID: 5870
	// (get) Token: 0x06011DF6 RID: 73206 RVA: 0x00466328 File Offset: 0x00464528
	// (set) Token: 0x06011DF7 RID: 73207 RVA: 0x00466330 File Offset: 0x00464530
	public int MaxBuyCount { get; set; }

	// Token: 0x170016EF RID: 5871
	// (get) Token: 0x06011DF8 RID: 73208 RVA: 0x00466339 File Offset: 0x00464539
	// (set) Token: 0x06011DF9 RID: 73209 RVA: 0x00466341 File Offset: 0x00464541
	public string ExchangeTableTextId { get; set; } = "";

	// Token: 0x170016F0 RID: 5872
	// (get) Token: 0x06011DFA RID: 73210 RVA: 0x0046634A File Offset: 0x0046454A
	// (set) Token: 0x06011DFB RID: 73211 RVA: 0x00466352 File Offset: 0x00464552
	public string ShopItemResource { get; set; } = "";

	// Token: 0x170016F1 RID: 5873
	// (get) Token: 0x06011DFC RID: 73212 RVA: 0x0046635B File Offset: 0x0046455B
	// (set) Token: 0x06011DFD RID: 73213 RVA: 0x00466363 File Offset: 0x00464563
	[Nullable(2)]
	public string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; } = "";

	// Token: 0x06011DFE RID: 73214
	public abstract void OnConfirmButtonClick(int viewId);

	// Token: 0x06011DFF RID: 73215
	public abstract bool CheckConfirmButtonCanInteract();

	// Token: 0x06011E00 RID: 73216
	public abstract UiPanelBase ShopItemCreate();

	// Token: 0x06011E01 RID: 73217
	public abstract void ShopItemRefresh();

	// Token: 0x06011E02 RID: 73218
	public abstract bool CheckMoneyEnough();

	// Token: 0x06011E03 RID: 73219
	public abstract void OnResellTimeRefresh();
}
