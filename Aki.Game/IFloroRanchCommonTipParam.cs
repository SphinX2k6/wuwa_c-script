using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B81 RID: 7041
[NullableContext(1)]
public interface IFloroRanchCommonTipParam
{
	// Token: 0x17001152 RID: 4434
	// (get) Token: 0x0600D192 RID: 53650
	// (set) Token: 0x0600D193 RID: 53651
	EFloroRanchCommonTipType TipType { get; set; }

	// Token: 0x17001153 RID: 4435
	// (get) Token: 0x0600D194 RID: 53652
	// (set) Token: 0x0600D195 RID: 53653
	FloroRanchEntityBase EntityData { get; set; }

	// Token: 0x17001154 RID: 4436
	// (get) Token: 0x0600D196 RID: 53654
	// (set) Token: 0x0600D197 RID: 53655
	Action<FloroRanchEntityBase> RemoveCallback { get; set; }

	// Token: 0x17001155 RID: 4437
	// (get) Token: 0x0600D198 RID: 53656
	// (set) Token: 0x0600D199 RID: 53657
	FloroRanchCurrencyData CurrencyData { get; set; }

	// Token: 0x17001156 RID: 4438
	// (get) Token: 0x0600D19A RID: 53658
	// (set) Token: 0x0600D19B RID: 53659
	FloroRanchToyData ToyData { get; set; }

	// Token: 0x17001157 RID: 4439
	// (get) Token: 0x0600D19C RID: 53660
	// (set) Token: 0x0600D19D RID: 53661
	FloroRanchCardData CardData { get; set; }
}
