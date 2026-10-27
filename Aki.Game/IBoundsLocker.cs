using System;

// Token: 0x02002EA5 RID: 11941
public interface IBoundsLocker
{
	// Token: 0x17002331 RID: 9009
	// (get) Token: 0x060197FD RID: 104445
	// (set) Token: 0x060197FE RID: 104446
	bool LockUpperBounds { get; set; }

	// Token: 0x17002332 RID: 9010
	// (get) Token: 0x060197FF RID: 104447
	// (set) Token: 0x06019800 RID: 104448
	bool LockLowerBounds { get; set; }

	// Token: 0x17002333 RID: 9011
	// (get) Token: 0x06019801 RID: 104449
	// (set) Token: 0x06019802 RID: 104450
	float UpperPercent { get; set; }

	// Token: 0x17002334 RID: 9012
	// (get) Token: 0x06019803 RID: 104451
	// (set) Token: 0x06019804 RID: 104452
	float UpperOffset { get; set; }

	// Token: 0x17002335 RID: 9013
	// (get) Token: 0x06019805 RID: 104453
	// (set) Token: 0x06019806 RID: 104454
	float LowerPercent { get; set; }

	// Token: 0x17002336 RID: 9014
	// (get) Token: 0x06019807 RID: 104455
	// (set) Token: 0x06019808 RID: 104456
	float LowerOffset { get; set; }
}
