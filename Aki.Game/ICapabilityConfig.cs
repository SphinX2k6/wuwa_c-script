using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200022C RID: 556
[NullableContext(1)]
public interface ICapabilityConfig
{
	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x0600227D RID: 8829
	// (set) Token: 0x0600227E RID: 8830
	List<int> Tags { get; set; }

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x0600227F RID: 8831
	// (set) Token: 0x06002280 RID: 8832
	ETickingGroup? TickGroup { get; set; }

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06002281 RID: 8833
	// (set) Token: 0x06002282 RID: 8834
	int TickGroupOrder { get; set; }

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06002283 RID: 8835
	// (set) Token: 0x06002284 RID: 8836
	ETickingGroup? InactiveTickGroup { get; set; }

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06002285 RID: 8837
	// (set) Token: 0x06002286 RID: 8838
	int? InactiveTickGroupOrder { get; set; }

	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x06002287 RID: 8839
	// (set) Token: 0x06002288 RID: 8840
	List<int> InterruptsTags { get; set; }
}
