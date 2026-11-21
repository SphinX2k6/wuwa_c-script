using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005DE RID: 1502
[NullableContext(1)]
public interface IBabelTowerLevelInfo
{
	// Token: 0x170009D7 RID: 2519
	// (get) Token: 0x060046D5 RID: 18133
	// (set) Token: 0x060046D6 RID: 18134
	int BabelTowerLevelId { get; set; }

	// Token: 0x170009D8 RID: 2520
	// (get) Token: 0x060046D7 RID: 18135
	// (set) Token: 0x060046D8 RID: 18136
	int InstanceId { get; set; }

	// Token: 0x170009D9 RID: 2521
	// (get) Token: 0x060046D9 RID: 18137
	// (set) Token: 0x060046DA RID: 18138
	List<int> RoleList { get; set; }

	// Token: 0x170009DA RID: 2522
	// (get) Token: 0x060046DB RID: 18139
	// (set) Token: 0x060046DC RID: 18140
	List<int> BuffList { get; set; }

	// Token: 0x170009DB RID: 2523
	// (get) Token: 0x060046DD RID: 18141
	// (set) Token: 0x060046DE RID: 18142
	int BuffCount { get; set; }

	// Token: 0x170009DC RID: 2524
	// (get) Token: 0x060046DF RID: 18143
	// (set) Token: 0x060046E0 RID: 18144
	int StarNumber { get; set; }
}
