using System;
using System.Runtime.CompilerServices;

// Token: 0x02001041 RID: 4161
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCommonTipParam : IFloroRanchCommonTipParam
{
	// Token: 0x1700117D RID: 4477
	// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x0030BD62 File Offset: 0x00309F62
	// (set) Token: 0x0600A5B0 RID: 42416 RVA: 0x0030BD6A File Offset: 0x00309F6A
	public EFloroRanchCommonTipType TipType { get; set; }

	// Token: 0x1700117E RID: 4478
	// (get) Token: 0x0600A5B1 RID: 42417 RVA: 0x0030BD73 File Offset: 0x00309F73
	// (set) Token: 0x0600A5B2 RID: 42418 RVA: 0x0030BD7B File Offset: 0x00309F7B
	public FloroRanchEntityBase EntityData { get; set; }

	// Token: 0x1700117F RID: 4479
	// (get) Token: 0x0600A5B3 RID: 42419 RVA: 0x0030BD84 File Offset: 0x00309F84
	// (set) Token: 0x0600A5B4 RID: 42420 RVA: 0x0030BD8C File Offset: 0x00309F8C
	public Action<FloroRanchEntityBase> RemoveCallback { get; set; }

	// Token: 0x17001180 RID: 4480
	// (get) Token: 0x0600A5B5 RID: 42421 RVA: 0x0030BD95 File Offset: 0x00309F95
	// (set) Token: 0x0600A5B6 RID: 42422 RVA: 0x0030BD9D File Offset: 0x00309F9D
	public FloroRanchCurrencyData CurrencyData { get; set; }

	// Token: 0x17001181 RID: 4481
	// (get) Token: 0x0600A5B7 RID: 42423 RVA: 0x0030BDA6 File Offset: 0x00309FA6
	// (set) Token: 0x0600A5B8 RID: 42424 RVA: 0x0030BDAE File Offset: 0x00309FAE
	public FloroRanchToyData ToyData { get; set; }

	// Token: 0x17001182 RID: 4482
	// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x0030BDB7 File Offset: 0x00309FB7
	// (set) Token: 0x0600A5BA RID: 42426 RVA: 0x0030BDBF File Offset: 0x00309FBF
	public FloroRanchCardData CardData { get; set; }
}
