using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020012D4 RID: 4820
[NullableContext(1)]
[Nullable(0)]
public class MapTravelAreaData
{
	// Token: 0x060084D9 RID: 34009 RVA: 0x001C46EE File Offset: 0x001C28EE
	public MapTravelAreaData(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x17000B5B RID: 2907
	// (get) Token: 0x060084DA RID: 34010 RVA: 0x001C4713 File Offset: 0x001C2913
	public int AreaId { get; }

	// Token: 0x17000B5C RID: 2908
	// (get) Token: 0x060084DB RID: 34011 RVA: 0x001C471B File Offset: 0x001C291B
	public HashSet<int> TravelTaskIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B5D RID: 2909
	// (get) Token: 0x060084DC RID: 34012 RVA: 0x001C4723 File Offset: 0x001C2923
	public HashSet<int> PhantomTaskIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B5E RID: 2910
	// (get) Token: 0x060084DD RID: 34013 RVA: 0x001C472B File Offset: 0x001C292B
	// (set) Token: 0x060084DE RID: 34014 RVA: 0x001C4733 File Offset: 0x001C2933
	public bool IsUnlock { get; set; }
}
