using System;
using System.Runtime.CompilerServices;

// Token: 0x02001821 RID: 6177
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopItemProxy : AbstractGameplayShopBaseItemProxy, IGameplayShopItemProxy, IGameplayShopItemBaseProxy
{
	// Token: 0x1700172C RID: 5932
	// (get) Token: 0x0600F2B5 RID: 62133 RVA: 0x004734B1 File Offset: 0x004716B1
	// (set) Token: 0x0600F2B6 RID: 62134 RVA: 0x004734B9 File Offset: 0x004716B9
	public GameplayShopTextData DiscountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700172D RID: 5933
	// (get) Token: 0x0600F2B7 RID: 62135 RVA: 0x004734C2 File Offset: 0x004716C2
	// (set) Token: 0x0600F2B8 RID: 62136 RVA: 0x004734CA File Offset: 0x004716CA
	public bool DiscountItemVisible { get; set; }

	// Token: 0x1700172E RID: 5934
	// (get) Token: 0x0600F2B9 RID: 62137 RVA: 0x004734D3 File Offset: 0x004716D3
	// (set) Token: 0x0600F2BA RID: 62138 RVA: 0x004734DB File Offset: 0x004716DB
	public GameplayShopTextData LabelTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700172F RID: 5935
	// (get) Token: 0x0600F2BB RID: 62139 RVA: 0x004734E4 File Offset: 0x004716E4
	// (set) Token: 0x0600F2BC RID: 62140 RVA: 0x004734EC File Offset: 0x004716EC
	public bool LabelVisible { get; set; }

	// Token: 0x17001730 RID: 5936
	// (get) Token: 0x0600F2BD RID: 62141 RVA: 0x004734F5 File Offset: 0x004716F5
	// (set) Token: 0x0600F2BE RID: 62142 RVA: 0x004734FD File Offset: 0x004716FD
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001731 RID: 5937
	// (get) Token: 0x0600F2BF RID: 62143 RVA: 0x00473506 File Offset: 0x00471706
	// (set) Token: 0x0600F2C0 RID: 62144 RVA: 0x0047350E File Offset: 0x0047170E
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x17001732 RID: 5938
	// (get) Token: 0x0600F2C1 RID: 62145 RVA: 0x00473517 File Offset: 0x00471717
	// (set) Token: 0x0600F2C2 RID: 62146 RVA: 0x0047351F File Offset: 0x0047171F
	public GameplayShopTextData ReSellTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001733 RID: 5939
	// (get) Token: 0x0600F2C3 RID: 62147 RVA: 0x00473528 File Offset: 0x00471728
	// (set) Token: 0x0600F2C4 RID: 62148 RVA: 0x00473530 File Offset: 0x00471730
	public bool ReSellItemVisible { get; set; }

	// Token: 0x17001734 RID: 5940
	// (get) Token: 0x0600F2C5 RID: 62149 RVA: 0x00473539 File Offset: 0x00471739
	// (set) Token: 0x0600F2C6 RID: 62150 RVA: 0x00473541 File Offset: 0x00471741
	public GameplayShopTextData SoldOutTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001735 RID: 5941
	// (get) Token: 0x0600F2C7 RID: 62151 RVA: 0x0047354A File Offset: 0x0047174A
	// (set) Token: 0x0600F2C8 RID: 62152 RVA: 0x00473552 File Offset: 0x00471752
	public bool SoldOutItemVisible { get; set; }

	// Token: 0x17001736 RID: 5942
	// (get) Token: 0x0600F2C9 RID: 62153 RVA: 0x0047355B File Offset: 0x0047175B
	// (set) Token: 0x0600F2CA RID: 62154 RVA: 0x00473563 File Offset: 0x00471763
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001737 RID: 5943
	// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x0047356C File Offset: 0x0047176C
	// (set) Token: 0x0600F2CC RID: 62156 RVA: 0x00473574 File Offset: 0x00471774
	public bool LockItemVisible { get; set; }

	// Token: 0x17001738 RID: 5944
	// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x0047357D File Offset: 0x0047177D
	// (set) Token: 0x0600F2CE RID: 62158 RVA: 0x00473585 File Offset: 0x00471785
	public bool TagNewItemVisible { get; set; }

	// Token: 0x0600F2CF RID: 62159
	public abstract void OnBuyButtonClick();
}
