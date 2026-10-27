using System;
using System.Runtime.CompilerServices;

// Token: 0x020029C6 RID: 10694
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerReviewViewParams
{
	// Token: 0x17001DA1 RID: 7585
	// (get) Token: 0x0601629F RID: 90783 RVA: 0x0059B1B8 File Offset: 0x005993B8
	// (set) Token: 0x060162A0 RID: 90784 RVA: 0x0059B1C0 File Offset: 0x005993C0
	public int SeasonId { get; set; }

	// Token: 0x17001DA2 RID: 7586
	// (get) Token: 0x060162A1 RID: 90785 RVA: 0x0059B1C9 File Offset: 0x005993C9
	// (set) Token: 0x060162A2 RID: 90786 RVA: 0x0059B1D1 File Offset: 0x005993D1
	public CustomPromise<bool> Promise { get; set; }
}
