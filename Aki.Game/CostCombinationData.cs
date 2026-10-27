using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200244D RID: 9293
[NullableContext(1)]
[Nullable(0)]
public class CostCombinationData : ICostCombinationData
{
	// Token: 0x17001830 RID: 6192
	// (get) Token: 0x06012A30 RID: 76336 RVA: 0x004990A2 File Offset: 0x004972A2
	// (set) Token: 0x06012A31 RID: 76337 RVA: 0x004990AA File Offset: 0x004972AA
	public int CostId { get; set; }

	// Token: 0x17001831 RID: 6193
	// (get) Token: 0x06012A32 RID: 76338 RVA: 0x004990B3 File Offset: 0x004972B3
	// (set) Token: 0x06012A33 RID: 76339 RVA: 0x004990BB File Offset: 0x004972BB
	public List<int> Costs { get; set; }

	// Token: 0x17001832 RID: 6194
	// (get) Token: 0x06012A34 RID: 76340 RVA: 0x004990C4 File Offset: 0x004972C4
	// (set) Token: 0x06012A35 RID: 76341 RVA: 0x004990CC File Offset: 0x004972CC
	public int Usage { get; set; }
}
