using System;
using System.Runtime.CompilerServices;

// Token: 0x02001040 RID: 4160
[NullableContext(1)]
public interface IFloroRanchCommonTipParam
{
	// Token: 0x17001177 RID: 4471
	// (get) Token: 0x0600A5A3 RID: 42403
	// (set) Token: 0x0600A5A4 RID: 42404
	EFloroRanchCommonTipType TipType { get; set; }

	// Token: 0x17001178 RID: 4472
	// (get) Token: 0x0600A5A5 RID: 42405
	// (set) Token: 0x0600A5A6 RID: 42406
	FloroRanchEntityBase EntityData { get; set; }

	// Token: 0x17001179 RID: 4473
	// (get) Token: 0x0600A5A7 RID: 42407
	// (set) Token: 0x0600A5A8 RID: 42408
	Action<FloroRanchEntityBase> RemoveCallback { get; set; }

	// Token: 0x1700117A RID: 4474
	// (get) Token: 0x0600A5A9 RID: 42409
	// (set) Token: 0x0600A5AA RID: 42410
	FloroRanchCurrencyData CurrencyData { get; set; }

	// Token: 0x1700117B RID: 4475
	// (get) Token: 0x0600A5AB RID: 42411
	// (set) Token: 0x0600A5AC RID: 42412
	FloroRanchToyData ToyData { get; set; }

	// Token: 0x1700117C RID: 4476
	// (get) Token: 0x0600A5AD RID: 42413
	// (set) Token: 0x0600A5AE RID: 42414
	FloroRanchCardData CardData { get; set; }
}
