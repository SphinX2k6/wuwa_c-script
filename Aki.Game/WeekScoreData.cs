using System;
using System.Runtime.CompilerServices;

// Token: 0x020023A7 RID: 9127
[NullableContext(1)]
[Nullable(0)]
public class WeekScoreData : IWeekScoreData
{
	// Token: 0x170017B6 RID: 6070
	// (get) Token: 0x06012407 RID: 74759 RVA: 0x0047E7BA File Offset: 0x0047C9BA
	// (set) Token: 0x06012408 RID: 74760 RVA: 0x0047E7C2 File Offset: 0x0047C9C2
	public string Tips { get; set; }

	// Token: 0x170017B7 RID: 6071
	// (get) Token: 0x06012409 RID: 74761 RVA: 0x0047E7CB File Offset: 0x0047C9CB
	// (set) Token: 0x0601240A RID: 74762 RVA: 0x0047E7D3 File Offset: 0x0047C9D3
	public string IconPath { get; set; }

	// Token: 0x170017B8 RID: 6072
	// (get) Token: 0x0601240B RID: 74763 RVA: 0x0047E7DC File Offset: 0x0047C9DC
	// (set) Token: 0x0601240C RID: 74764 RVA: 0x0047E7E4 File Offset: 0x0047C9E4
	public int Count { get; set; }
}
