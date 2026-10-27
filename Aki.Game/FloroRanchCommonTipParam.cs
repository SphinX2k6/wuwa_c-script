using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B82 RID: 7042
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCommonTipParam : IFloroRanchCommonTipParam
{
	// Token: 0x17001158 RID: 4440
	// (get) Token: 0x0600D19E RID: 53662 RVA: 0x00300C8A File Offset: 0x002FEE8A
	// (set) Token: 0x0600D19F RID: 53663 RVA: 0x00300C92 File Offset: 0x002FEE92
	public EFloroRanchCommonTipType TipType { get; set; }

	// Token: 0x17001159 RID: 4441
	// (get) Token: 0x0600D1A0 RID: 53664 RVA: 0x00300C9B File Offset: 0x002FEE9B
	// (set) Token: 0x0600D1A1 RID: 53665 RVA: 0x00300CA3 File Offset: 0x002FEEA3
	public FloroRanchEntityBase EntityData { get; set; }

	// Token: 0x1700115A RID: 4442
	// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x00300CAC File Offset: 0x002FEEAC
	// (set) Token: 0x0600D1A3 RID: 53667 RVA: 0x00300CB4 File Offset: 0x002FEEB4
	public Action<FloroRanchEntityBase> RemoveCallback { get; set; }

	// Token: 0x1700115B RID: 4443
	// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x00300CBD File Offset: 0x002FEEBD
	// (set) Token: 0x0600D1A5 RID: 53669 RVA: 0x00300CC5 File Offset: 0x002FEEC5
	public FloroRanchCurrencyData CurrencyData { get; set; }

	// Token: 0x1700115C RID: 4444
	// (get) Token: 0x0600D1A6 RID: 53670 RVA: 0x00300CCE File Offset: 0x002FEECE
	// (set) Token: 0x0600D1A7 RID: 53671 RVA: 0x00300CD6 File Offset: 0x002FEED6
	public FloroRanchToyData ToyData { get; set; }

	// Token: 0x1700115D RID: 4445
	// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x00300CDF File Offset: 0x002FEEDF
	// (set) Token: 0x0600D1A9 RID: 53673 RVA: 0x00300CE7 File Offset: 0x002FEEE7
	public FloroRanchCardData CardData { get; set; }
}
