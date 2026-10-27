using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200112A RID: 4394
[NullableContext(1)]
public interface IBabelTowerLevelInfo
{
	// Token: 0x170009B7 RID: 2487
	// (get) Token: 0x0600733E RID: 29502
	// (set) Token: 0x0600733F RID: 29503
	int BabelTowerLevelId { get; set; }

	// Token: 0x170009B8 RID: 2488
	// (get) Token: 0x06007340 RID: 29504
	// (set) Token: 0x06007341 RID: 29505
	int InstanceId { get; set; }

	// Token: 0x170009B9 RID: 2489
	// (get) Token: 0x06007342 RID: 29506
	// (set) Token: 0x06007343 RID: 29507
	List<int> RoleList { get; set; }

	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x06007344 RID: 29508
	// (set) Token: 0x06007345 RID: 29509
	List<int> BuffList { get; set; }

	// Token: 0x170009BB RID: 2491
	// (get) Token: 0x06007346 RID: 29510
	// (set) Token: 0x06007347 RID: 29511
	int BuffCount { get; set; }

	// Token: 0x170009BC RID: 2492
	// (get) Token: 0x06007348 RID: 29512
	// (set) Token: 0x06007349 RID: 29513
	int StarNumber { get; set; }
}
