using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001138 RID: 4408
[NullableContext(1)]
public interface IBabelTowerMutexGroupData
{
	// Token: 0x170009F9 RID: 2553
	// (get) Token: 0x060073C9 RID: 29641
	// (set) Token: 0x060073CA RID: 29642
	int MutexId { get; set; }

	// Token: 0x170009FA RID: 2554
	// (get) Token: 0x060073CB RID: 29643
	// (set) Token: 0x060073CC RID: 29644
	int GroupId { get; set; }

	// Token: 0x170009FB RID: 2555
	// (get) Token: 0x060073CD RID: 29645
	// (set) Token: 0x060073CE RID: 29646
	List<int> DeTermList { get; set; }

	// Token: 0x170009FC RID: 2556
	// (get) Token: 0x060073CF RID: 29647
	// (set) Token: 0x060073D0 RID: 29648
	bool? IsNecessary { get; set; }

	// Token: 0x170009FD RID: 2557
	// (get) Token: 0x060073D1 RID: 29649
	// (set) Token: 0x060073D2 RID: 29650
	int? CurrentDeTermId { get; set; }
}
