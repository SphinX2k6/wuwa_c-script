using System;

// Token: 0x020008CE RID: 2254
public interface IBuffView
{
	// Token: 0x17000C8A RID: 3210
	// (get) Token: 0x060064A8 RID: 25768
	// (set) Token: 0x060064A9 RID: 25769
	int BuffId { get; set; }

	// Token: 0x17000C8B RID: 3211
	// (get) Token: 0x060064AA RID: 25770
	// (set) Token: 0x060064AB RID: 25771
	EPinballBuffType BuffType { get; set; }

	// Token: 0x17000C8C RID: 3212
	// (get) Token: 0x060064AC RID: 25772
	// (set) Token: 0x060064AD RID: 25773
	int BuffCount { get; set; }

	// Token: 0x17000C8D RID: 3213
	// (get) Token: 0x060064AE RID: 25774
	// (set) Token: 0x060064AF RID: 25775
	int Sort { get; set; }
}
