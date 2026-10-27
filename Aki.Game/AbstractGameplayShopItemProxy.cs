using System;
using System.Runtime.CompilerServices;

// Token: 0x0200233C RID: 9020
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopItemProxy : AbstractGameplayShopBaseItemProxy, IGameplayShopItemProxy, IGameplayShopItemBaseProxy
{
	// Token: 0x170016F2 RID: 5874
	// (get) Token: 0x06011E05 RID: 73221 RVA: 0x004663E9 File Offset: 0x004645E9
	// (set) Token: 0x06011E06 RID: 73222 RVA: 0x004663F1 File Offset: 0x004645F1
	public GameplayShopTextData DiscountTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016F3 RID: 5875
	// (get) Token: 0x06011E07 RID: 73223 RVA: 0x004663FA File Offset: 0x004645FA
	// (set) Token: 0x06011E08 RID: 73224 RVA: 0x00466402 File Offset: 0x00464602
	public bool DiscountItemVisible { get; set; }

	// Token: 0x170016F4 RID: 5876
	// (get) Token: 0x06011E09 RID: 73225 RVA: 0x0046640B File Offset: 0x0046460B
	// (set) Token: 0x06011E0A RID: 73226 RVA: 0x00466413 File Offset: 0x00464613
	public GameplayShopTextData LabelTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016F5 RID: 5877
	// (get) Token: 0x06011E0B RID: 73227 RVA: 0x0046641C File Offset: 0x0046461C
	// (set) Token: 0x06011E0C RID: 73228 RVA: 0x00466424 File Offset: 0x00464624
	public bool LabelVisible { get; set; }

	// Token: 0x170016F6 RID: 5878
	// (get) Token: 0x06011E0D RID: 73229 RVA: 0x0046642D File Offset: 0x0046462D
	// (set) Token: 0x06011E0E RID: 73230 RVA: 0x00466435 File Offset: 0x00464635
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016F7 RID: 5879
	// (get) Token: 0x06011E0F RID: 73231 RVA: 0x0046643E File Offset: 0x0046463E
	// (set) Token: 0x06011E10 RID: 73232 RVA: 0x00466446 File Offset: 0x00464646
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x170016F8 RID: 5880
	// (get) Token: 0x06011E11 RID: 73233 RVA: 0x0046644F File Offset: 0x0046464F
	// (set) Token: 0x06011E12 RID: 73234 RVA: 0x00466457 File Offset: 0x00464657
	public GameplayShopTextData ReSellTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016F9 RID: 5881
	// (get) Token: 0x06011E13 RID: 73235 RVA: 0x00466460 File Offset: 0x00464660
	// (set) Token: 0x06011E14 RID: 73236 RVA: 0x00466468 File Offset: 0x00464668
	public bool ReSellItemVisible { get; set; }

	// Token: 0x170016FA RID: 5882
	// (get) Token: 0x06011E15 RID: 73237 RVA: 0x00466471 File Offset: 0x00464671
	// (set) Token: 0x06011E16 RID: 73238 RVA: 0x00466479 File Offset: 0x00464679
	public GameplayShopTextData SoldOutTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016FB RID: 5883
	// (get) Token: 0x06011E17 RID: 73239 RVA: 0x00466482 File Offset: 0x00464682
	// (set) Token: 0x06011E18 RID: 73240 RVA: 0x0046648A File Offset: 0x0046468A
	public bool SoldOutItemVisible { get; set; }

	// Token: 0x170016FC RID: 5884
	// (get) Token: 0x06011E19 RID: 73241 RVA: 0x00466493 File Offset: 0x00464693
	// (set) Token: 0x06011E1A RID: 73242 RVA: 0x0046649B File Offset: 0x0046469B
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x170016FD RID: 5885
	// (get) Token: 0x06011E1B RID: 73243 RVA: 0x004664A4 File Offset: 0x004646A4
	// (set) Token: 0x06011E1C RID: 73244 RVA: 0x004664AC File Offset: 0x004646AC
	public bool LockItemVisible { get; set; }

	// Token: 0x170016FE RID: 5886
	// (get) Token: 0x06011E1D RID: 73245 RVA: 0x004664B5 File Offset: 0x004646B5
	// (set) Token: 0x06011E1E RID: 73246 RVA: 0x004664BD File Offset: 0x004646BD
	public bool TagNewItemVisible { get; set; }

	// Token: 0x06011E1F RID: 73247
	public abstract void OnBuyButtonClick();
}
