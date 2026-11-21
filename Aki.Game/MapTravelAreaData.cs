using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000788 RID: 1928
[NullableContext(1)]
[Nullable(0)]
public class MapTravelAreaData
{
	// Token: 0x06005874 RID: 22644 RVA: 0x001CD54A File Offset: 0x001CB74A
	public MapTravelAreaData(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x17000B7B RID: 2939
	// (get) Token: 0x06005875 RID: 22645 RVA: 0x001CD56F File Offset: 0x001CB76F
	public int AreaId { get; }

	// Token: 0x17000B7C RID: 2940
	// (get) Token: 0x06005876 RID: 22646 RVA: 0x001CD577 File Offset: 0x001CB777
	public HashSet<int> TravelTaskIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B7D RID: 2941
	// (get) Token: 0x06005877 RID: 22647 RVA: 0x001CD57F File Offset: 0x001CB77F
	public HashSet<int> PhantomTaskIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B7E RID: 2942
	// (get) Token: 0x06005878 RID: 22648 RVA: 0x001CD587 File Offset: 0x001CB787
	// (set) Token: 0x06005879 RID: 22649 RVA: 0x001CD58F File Offset: 0x001CB78F
	public bool IsUnlock { get; set; }
}
