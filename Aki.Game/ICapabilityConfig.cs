using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000230 RID: 560
[NullableContext(1)]
public interface ICapabilityConfig
{
	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06002335 RID: 9013
	// (set) Token: 0x06002336 RID: 9014
	List<int> Tags { get; set; }

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06002337 RID: 9015
	// (set) Token: 0x06002338 RID: 9016
	ETickingGroup? TickGroup { get; set; }

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06002339 RID: 9017
	// (set) Token: 0x0600233A RID: 9018
	int TickGroupOrder { get; set; }

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x0600233B RID: 9019
	// (set) Token: 0x0600233C RID: 9020
	ETickingGroup? InactiveTickGroup { get; set; }

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x0600233D RID: 9021
	// (set) Token: 0x0600233E RID: 9022
	int? InactiveTickGroupOrder { get; set; }

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x0600233F RID: 9023
	// (set) Token: 0x06002340 RID: 9024
	List<int> InterruptsTags { get; set; }
}
