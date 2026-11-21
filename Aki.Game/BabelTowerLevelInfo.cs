using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005DF RID: 1503
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerLevelInfo : IBabelTowerLevelInfo
{
	// Token: 0x170009DD RID: 2525
	// (get) Token: 0x060046E1 RID: 18145 RVA: 0x0018445C File Offset: 0x0018265C
	// (set) Token: 0x060046E2 RID: 18146 RVA: 0x00184464 File Offset: 0x00182664
	public int BabelTowerLevelId { get; set; }

	// Token: 0x170009DE RID: 2526
	// (get) Token: 0x060046E3 RID: 18147 RVA: 0x0018446D File Offset: 0x0018266D
	// (set) Token: 0x060046E4 RID: 18148 RVA: 0x00184475 File Offset: 0x00182675
	public int InstanceId { get; set; }

	// Token: 0x170009DF RID: 2527
	// (get) Token: 0x060046E5 RID: 18149 RVA: 0x0018447E File Offset: 0x0018267E
	// (set) Token: 0x060046E6 RID: 18150 RVA: 0x00184486 File Offset: 0x00182686
	public List<int> RoleList { get; set; }

	// Token: 0x170009E0 RID: 2528
	// (get) Token: 0x060046E7 RID: 18151 RVA: 0x0018448F File Offset: 0x0018268F
	// (set) Token: 0x060046E8 RID: 18152 RVA: 0x00184497 File Offset: 0x00182697
	public List<int> BuffList { get; set; }

	// Token: 0x170009E1 RID: 2529
	// (get) Token: 0x060046E9 RID: 18153 RVA: 0x001844A0 File Offset: 0x001826A0
	// (set) Token: 0x060046EA RID: 18154 RVA: 0x001844A8 File Offset: 0x001826A8
	public int BuffCount { get; set; }

	// Token: 0x170009E2 RID: 2530
	// (get) Token: 0x060046EB RID: 18155 RVA: 0x001844B1 File Offset: 0x001826B1
	// (set) Token: 0x060046EC RID: 18156 RVA: 0x001844B9 File Offset: 0x001826B9
	public int StarNumber { get; set; }
}
