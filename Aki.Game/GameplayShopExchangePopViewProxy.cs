using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002347 RID: 9031
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopExchangePopViewProxy : IGameplayShopExchangePopViewProxy
{
	// Token: 0x17001772 RID: 6002
	// (get) Token: 0x06011F5F RID: 73567 RVA: 0x00467EBC File Offset: 0x004660BC
	// (set) Token: 0x06011F60 RID: 73568 RVA: 0x00467EC4 File Offset: 0x004660C4
	[Nullable(2)]
	public object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001773 RID: 6003
	// (get) Token: 0x06011F61 RID: 73569 RVA: 0x00467ECD File Offset: 0x004660CD
	// (set) Token: 0x06011F62 RID: 73570 RVA: 0x00467ED5 File Offset: 0x004660D5
	public int CurrencyId { get; set; }

	// Token: 0x17001774 RID: 6004
	// (get) Token: 0x06011F63 RID: 73571 RVA: 0x00467EDE File Offset: 0x004660DE
	// (set) Token: 0x06011F64 RID: 73572 RVA: 0x00467EE6 File Offset: 0x004660E6
	public List<int> CurrencyIdList { get; set; } = new List<int>();

	// Token: 0x17001775 RID: 6005
	// (get) Token: 0x06011F65 RID: 73573 RVA: 0x00467EEF File Offset: 0x004660EF
	// (set) Token: 0x06011F66 RID: 73574 RVA: 0x00467EF7 File Offset: 0x004660F7
	public int Price { get; set; }

	// Token: 0x17001776 RID: 6006
	// (get) Token: 0x06011F67 RID: 73575 RVA: 0x00467F00 File Offset: 0x00466100
	// (set) Token: 0x06011F68 RID: 73576 RVA: 0x00467F08 File Offset: 0x00466108
	public GameplayShopTextData DescribeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001777 RID: 6007
	// (get) Token: 0x06011F69 RID: 73577 RVA: 0x00467F11 File Offset: 0x00466111
	// (set) Token: 0x06011F6A RID: 73578 RVA: 0x00467F19 File Offset: 0x00466119
	public bool TipTitleItemVisible { get; set; }

	// Token: 0x17001778 RID: 6008
	// (get) Token: 0x06011F6B RID: 73579 RVA: 0x00467F22 File Offset: 0x00466122
	// (set) Token: 0x06011F6C RID: 73580 RVA: 0x00467F2A File Offset: 0x0046612A
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x17001779 RID: 6009
	// (get) Token: 0x06011F6D RID: 73581 RVA: 0x00467F33 File Offset: 0x00466133
	// (set) Token: 0x06011F6E RID: 73582 RVA: 0x00467F3B File Offset: 0x0046613B
	public bool LeftTimeTextVisible { get; set; }

	// Token: 0x1700177A RID: 6010
	// (get) Token: 0x06011F6F RID: 73583 RVA: 0x00467F44 File Offset: 0x00466144
	// (set) Token: 0x06011F70 RID: 73584 RVA: 0x00467F4C File Offset: 0x0046614C
	public GameplayShopTextData LeftTimeDescTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700177B RID: 6011
	// (get) Token: 0x06011F71 RID: 73585 RVA: 0x00467F55 File Offset: 0x00466155
	// (set) Token: 0x06011F72 RID: 73586 RVA: 0x00467F5D File Offset: 0x0046615D
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700177C RID: 6012
	// (get) Token: 0x06011F73 RID: 73587 RVA: 0x00467F66 File Offset: 0x00466166
	// (set) Token: 0x06011F74 RID: 73588 RVA: 0x00467F6E File Offset: 0x0046616E
	public bool LimitTextItemVisible { get; set; }

	// Token: 0x1700177D RID: 6013
	// (get) Token: 0x06011F75 RID: 73589 RVA: 0x00467F77 File Offset: 0x00466177
	// (set) Token: 0x06011F76 RID: 73590 RVA: 0x00467F7F File Offset: 0x0046617F
	public GameplayShopTextData LimitTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700177E RID: 6014
	// (get) Token: 0x06011F77 RID: 73591 RVA: 0x00467F88 File Offset: 0x00466188
	// (set) Token: 0x06011F78 RID: 73592 RVA: 0x00467F90 File Offset: 0x00466190
	public bool LockItemVisible { get; set; }

	// Token: 0x1700177F RID: 6015
	// (get) Token: 0x06011F79 RID: 73593 RVA: 0x00467F99 File Offset: 0x00466199
	// (set) Token: 0x06011F7A RID: 73594 RVA: 0x00467FA1 File Offset: 0x004661A1
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001780 RID: 6016
	// (get) Token: 0x06011F7B RID: 73595 RVA: 0x00467FAA File Offset: 0x004661AA
	// (set) Token: 0x06011F7C RID: 73596 RVA: 0x00467FB2 File Offset: 0x004661B2
	public int ReSellTime { get; set; }

	// Token: 0x17001781 RID: 6017
	// (get) Token: 0x06011F7D RID: 73597 RVA: 0x00467FBB File Offset: 0x004661BB
	// (set) Token: 0x06011F7E RID: 73598 RVA: 0x00467FC3 File Offset: 0x004661C3
	public int BuyCount { get; set; }

	// Token: 0x17001782 RID: 6018
	// (get) Token: 0x06011F7F RID: 73599 RVA: 0x00467FCC File Offset: 0x004661CC
	// (set) Token: 0x06011F80 RID: 73600 RVA: 0x00467FD4 File Offset: 0x004661D4
	public int MaxBuyCount { get; set; }

	// Token: 0x17001783 RID: 6019
	// (get) Token: 0x06011F81 RID: 73601 RVA: 0x00467FDD File Offset: 0x004661DD
	// (set) Token: 0x06011F82 RID: 73602 RVA: 0x00467FE5 File Offset: 0x004661E5
	public string ExchangeTableTextId { get; set; } = "";

	// Token: 0x17001784 RID: 6020
	// (get) Token: 0x06011F83 RID: 73603 RVA: 0x00467FEE File Offset: 0x004661EE
	// (set) Token: 0x06011F84 RID: 73604 RVA: 0x00467FF6 File Offset: 0x004661F6
	[Nullable(2)]
	public string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001785 RID: 6021
	// (get) Token: 0x06011F85 RID: 73605 RVA: 0x00467FFF File Offset: 0x004661FF
	// (set) Token: 0x06011F86 RID: 73606 RVA: 0x00468007 File Offset: 0x00466207
	public string ShopItemResource { get; set; } = "";

	// Token: 0x06011F87 RID: 73607 RVA: 0x00468010 File Offset: 0x00466210
	public virtual void OnConfirmButtonClick(int viewId)
	{
	}

	// Token: 0x06011F88 RID: 73608 RVA: 0x00468012 File Offset: 0x00466212
	public virtual bool CheckConfirmButtonCanInteract()
	{
		return false;
	}

	// Token: 0x06011F89 RID: 73609 RVA: 0x00468015 File Offset: 0x00466215
	public virtual UiPanelBase ShopItemCreate()
	{
		return null;
	}

	// Token: 0x06011F8A RID: 73610 RVA: 0x00468018 File Offset: 0x00466218
	public virtual void ShopItemRefresh()
	{
	}

	// Token: 0x06011F8B RID: 73611 RVA: 0x0046801A File Offset: 0x0046621A
	public virtual bool CheckMoneyEnough()
	{
		return false;
	}

	// Token: 0x06011F8C RID: 73612 RVA: 0x0046801D File Offset: 0x0046621D
	public virtual void OnResellTimeRefresh()
	{
	}
}
