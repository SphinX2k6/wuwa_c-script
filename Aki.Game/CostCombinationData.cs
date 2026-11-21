using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001932 RID: 6450
[NullableContext(1)]
[Nullable(0)]
public class CostCombinationData : ICostCombinationData
{
	// Token: 0x1700186A RID: 6250
	// (get) Token: 0x0600FEE7 RID: 65255 RVA: 0x004A66AA File Offset: 0x004A48AA
	// (set) Token: 0x0600FEE8 RID: 65256 RVA: 0x004A66B2 File Offset: 0x004A48B2
	public int CostId { get; set; }

	// Token: 0x1700186B RID: 6251
	// (get) Token: 0x0600FEE9 RID: 65257 RVA: 0x004A66BB File Offset: 0x004A48BB
	// (set) Token: 0x0600FEEA RID: 65258 RVA: 0x004A66C3 File Offset: 0x004A48C3
	public List<int> Costs { get; set; }

	// Token: 0x1700186C RID: 6252
	// (get) Token: 0x0600FEEB RID: 65259 RVA: 0x004A66CC File Offset: 0x004A48CC
	// (set) Token: 0x0600FEEC RID: 65260 RVA: 0x004A66D4 File Offset: 0x004A48D4
	public int Usage { get; set; }
}
