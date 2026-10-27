using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A4A RID: 10826
[NullableContext(1)]
public interface IFlySkinGetWayData
{
	// Token: 0x17001DE6 RID: 7654
	// (get) Token: 0x060168D8 RID: 92376
	// (set) Token: 0x060168D9 RID: 92377
	int Id { get; set; }

	// Token: 0x17001DE7 RID: 7655
	// (get) Token: 0x060168DA RID: 92378
	// (set) Token: 0x060168DB RID: 92379
	int ConfigId { get; set; }

	// Token: 0x17001DE8 RID: 7656
	// (get) Token: 0x060168DC RID: 92380
	// (set) Token: 0x060168DD RID: 92381
	EFlySkinGetWayType Type { get; set; }

	// Token: 0x17001DE9 RID: 7657
	// (get) Token: 0x060168DE RID: 92382
	// (set) Token: 0x060168DF RID: 92383
	string Text { get; set; }

	// Token: 0x17001DEA RID: 7658
	// (get) Token: 0x060168E0 RID: 92384
	// (set) Token: 0x060168E1 RID: 92385
	int SortIndex { get; set; }
}
