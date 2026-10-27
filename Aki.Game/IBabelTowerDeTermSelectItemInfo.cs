using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001132 RID: 4402
[NullableContext(1)]
public interface IBabelTowerDeTermSelectItemInfo
{
	// Token: 0x170009DB RID: 2523
	// (get) Token: 0x0600738A RID: 29578
	// (set) Token: 0x0600738B RID: 29579
	bool IsNecessary { get; set; }

	// Token: 0x170009DC RID: 2524
	// (get) Token: 0x0600738C RID: 29580
	// (set) Token: 0x0600738D RID: 29581
	List<int> AllDeTerm { get; set; }

	// Token: 0x170009DD RID: 2525
	// (get) Token: 0x0600738E RID: 29582
	// (set) Token: 0x0600738F RID: 29583
	List<int> DailyDeTerm { get; set; }

	// Token: 0x170009DE RID: 2526
	// (get) Token: 0x06007390 RID: 29584
	// (set) Token: 0x06007391 RID: 29585
	Action<int> OnChangeSelectDeTerm { get; set; }
}
