using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200244C RID: 9292
[NullableContext(1)]
public interface ICostCombinationData
{
	// Token: 0x1700182D RID: 6189
	// (get) Token: 0x06012A2A RID: 76330
	// (set) Token: 0x06012A2B RID: 76331
	int CostId { get; set; }

	// Token: 0x1700182E RID: 6190
	// (get) Token: 0x06012A2C RID: 76332
	// (set) Token: 0x06012A2D RID: 76333
	List<int> Costs { get; set; }

	// Token: 0x1700182F RID: 6191
	// (get) Token: 0x06012A2E RID: 76334
	// (set) Token: 0x06012A2F RID: 76335
	int Usage { get; set; }
}
