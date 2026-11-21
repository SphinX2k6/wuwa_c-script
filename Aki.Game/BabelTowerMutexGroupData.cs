using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005ED RID: 1517
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerMutexGroupData : IBabelTowerMutexGroupData
{
	// Token: 0x17000A1E RID: 2590
	// (get) Token: 0x0600476A RID: 18282 RVA: 0x001846C5 File Offset: 0x001828C5
	// (set) Token: 0x0600476B RID: 18283 RVA: 0x001846CD File Offset: 0x001828CD
	public int MutexId { get; set; }

	// Token: 0x17000A1F RID: 2591
	// (get) Token: 0x0600476C RID: 18284 RVA: 0x001846D6 File Offset: 0x001828D6
	// (set) Token: 0x0600476D RID: 18285 RVA: 0x001846DE File Offset: 0x001828DE
	public int GroupId { get; set; }

	// Token: 0x17000A20 RID: 2592
	// (get) Token: 0x0600476E RID: 18286 RVA: 0x001846E7 File Offset: 0x001828E7
	// (set) Token: 0x0600476F RID: 18287 RVA: 0x001846EF File Offset: 0x001828EF
	public List<int> DeTermList { get; set; }

	// Token: 0x17000A21 RID: 2593
	// (get) Token: 0x06004770 RID: 18288 RVA: 0x001846F8 File Offset: 0x001828F8
	// (set) Token: 0x06004771 RID: 18289 RVA: 0x00184700 File Offset: 0x00182900
	public bool? IsNecessary { get; set; }

	// Token: 0x17000A22 RID: 2594
	// (get) Token: 0x06004772 RID: 18290 RVA: 0x00184709 File Offset: 0x00182909
	// (set) Token: 0x06004773 RID: 18291 RVA: 0x00184711 File Offset: 0x00182911
	public int? CurrentDeTermId { get; set; }
}
