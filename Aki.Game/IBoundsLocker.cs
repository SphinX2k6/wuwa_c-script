using System;

// Token: 0x020023F8 RID: 9208
public interface IBoundsLocker
{
	// Token: 0x170023C7 RID: 9159
	// (get) Token: 0x060170DD RID: 94429
	// (set) Token: 0x060170DE RID: 94430
	bool LockUpperBounds { get; set; }

	// Token: 0x170023C8 RID: 9160
	// (get) Token: 0x060170DF RID: 94431
	// (set) Token: 0x060170E0 RID: 94432
	bool LockLowerBounds { get; set; }

	// Token: 0x170023C9 RID: 9161
	// (get) Token: 0x060170E1 RID: 94433
	// (set) Token: 0x060170E2 RID: 94434
	float UpperPercent { get; set; }

	// Token: 0x170023CA RID: 9162
	// (get) Token: 0x060170E3 RID: 94435
	// (set) Token: 0x060170E4 RID: 94436
	float UpperOffset { get; set; }

	// Token: 0x170023CB RID: 9163
	// (get) Token: 0x060170E5 RID: 94437
	// (set) Token: 0x060170E6 RID: 94438
	float LowerPercent { get; set; }

	// Token: 0x170023CC RID: 9164
	// (get) Token: 0x060170E7 RID: 94439
	// (set) Token: 0x060170E8 RID: 94440
	float LowerOffset { get; set; }
}
