using System;

// Token: 0x02002EA6 RID: 11942
public class BoundsLocker : IBoundsLocker
{
	// Token: 0x17002337 RID: 9015
	// (get) Token: 0x06019809 RID: 104457 RVA: 0x0069531C File Offset: 0x0069351C
	// (set) Token: 0x0601980A RID: 104458 RVA: 0x00695324 File Offset: 0x00693524
	public bool LockUpperBounds { get; set; }

	// Token: 0x17002338 RID: 9016
	// (get) Token: 0x0601980B RID: 104459 RVA: 0x0069532D File Offset: 0x0069352D
	// (set) Token: 0x0601980C RID: 104460 RVA: 0x00695335 File Offset: 0x00693535
	public bool LockLowerBounds { get; set; }

	// Token: 0x17002339 RID: 9017
	// (get) Token: 0x0601980D RID: 104461 RVA: 0x0069533E File Offset: 0x0069353E
	// (set) Token: 0x0601980E RID: 104462 RVA: 0x00695346 File Offset: 0x00693546
	public float UpperPercent { get; set; }

	// Token: 0x1700233A RID: 9018
	// (get) Token: 0x0601980F RID: 104463 RVA: 0x0069534F File Offset: 0x0069354F
	// (set) Token: 0x06019810 RID: 104464 RVA: 0x00695357 File Offset: 0x00693557
	public float UpperOffset { get; set; }

	// Token: 0x1700233B RID: 9019
	// (get) Token: 0x06019811 RID: 104465 RVA: 0x00695360 File Offset: 0x00693560
	// (set) Token: 0x06019812 RID: 104466 RVA: 0x00695368 File Offset: 0x00693568
	public float LowerPercent { get; set; }

	// Token: 0x1700233C RID: 9020
	// (get) Token: 0x06019813 RID: 104467 RVA: 0x00695371 File Offset: 0x00693571
	// (set) Token: 0x06019814 RID: 104468 RVA: 0x00695379 File Offset: 0x00693579
	public float LowerOffset { get; set; }
}
