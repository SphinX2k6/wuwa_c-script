using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027E1 RID: 10209
[NullableContext(1)]
public interface IMaterialGroup
{
	// Token: 0x17001B66 RID: 7014
	// (get) Token: 0x06014F6A RID: 85866
	// (set) Token: 0x06014F6B RID: 85867
	int Type { get; set; }

	// Token: 0x17001B67 RID: 7015
	// (get) Token: 0x06014F6C RID: 85868
	// (set) Token: 0x06014F6D RID: 85869
	List<IItemMaterial> Materials { get; set; }
}
