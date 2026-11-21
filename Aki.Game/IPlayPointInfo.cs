using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F60 RID: 3936
[NullableContext(2)]
public interface IPlayPointInfo
{
	// Token: 0x170010A9 RID: 4265
	// (get) Token: 0x06009DE5 RID: 40421
	// (set) Token: 0x06009DE6 RID: 40422
	int PlayId { get; set; }

	// Token: 0x170010AA RID: 4266
	// (get) Token: 0x06009DE7 RID: 40423
	// (set) Token: 0x06009DE8 RID: 40424
	int EntityId { get; set; }

	// Token: 0x170010AB RID: 4267
	// (get) Token: 0x06009DE9 RID: 40425
	// (set) Token: 0x06009DEA RID: 40426
	EPlayPointState PlayState { get; set; }

	// Token: 0x170010AC RID: 4268
	// (get) Token: 0x06009DEB RID: 40427
	// (set) Token: 0x06009DEC RID: 40428
	bool? IsClear { get; set; }

	// Token: 0x170010AD RID: 4269
	// (get) Token: 0x06009DED RID: 40429
	// (set) Token: 0x06009DEE RID: 40430
	string ClearInfo { get; set; }

	// Token: 0x170010AE RID: 4270
	// (get) Token: 0x06009DEF RID: 40431
	// (set) Token: 0x06009DF0 RID: 40432
	bool? LevelPlayMarkUnlock { get; set; }

	// Token: 0x170010AF RID: 4271
	// (get) Token: 0x06009DF1 RID: 40433
	// (set) Token: 0x06009DF2 RID: 40434
	bool IsUnlock { get; set; }
}
