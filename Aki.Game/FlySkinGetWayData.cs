using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A4B RID: 10827
[NullableContext(1)]
[Nullable(0)]
public class FlySkinGetWayData : IFlySkinGetWayData
{
	// Token: 0x17001DEB RID: 7659
	// (get) Token: 0x060168E2 RID: 92386 RVA: 0x005B781E File Offset: 0x005B5A1E
	// (set) Token: 0x060168E3 RID: 92387 RVA: 0x005B7826 File Offset: 0x005B5A26
	public int Id { get; set; }

	// Token: 0x17001DEC RID: 7660
	// (get) Token: 0x060168E4 RID: 92388 RVA: 0x005B782F File Offset: 0x005B5A2F
	// (set) Token: 0x060168E5 RID: 92389 RVA: 0x005B7837 File Offset: 0x005B5A37
	public int ConfigId { get; set; }

	// Token: 0x17001DED RID: 7661
	// (get) Token: 0x060168E6 RID: 92390 RVA: 0x005B7840 File Offset: 0x005B5A40
	// (set) Token: 0x060168E7 RID: 92391 RVA: 0x005B7848 File Offset: 0x005B5A48
	public EFlySkinGetWayType Type { get; set; }

	// Token: 0x17001DEE RID: 7662
	// (get) Token: 0x060168E8 RID: 92392 RVA: 0x005B7851 File Offset: 0x005B5A51
	// (set) Token: 0x060168E9 RID: 92393 RVA: 0x005B7859 File Offset: 0x005B5A59
	public string Text { get; set; }

	// Token: 0x17001DEF RID: 7663
	// (get) Token: 0x060168EA RID: 92394 RVA: 0x005B7862 File Offset: 0x005B5A62
	// (set) Token: 0x060168EB RID: 92395 RVA: 0x005B786A File Offset: 0x005B5A6A
	public int SortIndex { get; set; }
}
