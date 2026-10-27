using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027E2 RID: 10210
[NullableContext(1)]
[Nullable(0)]
public class MaterialGroup : IMaterialGroup
{
	// Token: 0x17001B68 RID: 7016
	// (get) Token: 0x06014F6E RID: 85870 RVA: 0x00551168 File Offset: 0x0054F368
	// (set) Token: 0x06014F6F RID: 85871 RVA: 0x00551170 File Offset: 0x0054F370
	public int Type { get; set; }

	// Token: 0x17001B69 RID: 7017
	// (get) Token: 0x06014F70 RID: 85872 RVA: 0x00551179 File Offset: 0x0054F379
	// (set) Token: 0x06014F71 RID: 85873 RVA: 0x00551181 File Offset: 0x0054F381
	public List<IItemMaterial> Materials { get; set; }
}
