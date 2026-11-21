using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001517 RID: 5399
[NullableContext(1)]
[Nullable(0)]
public class KingShipPlotViewData : IKingShipPlotViewData
{
	// Token: 0x17001402 RID: 5122
	// (get) Token: 0x0600D812 RID: 55314 RVA: 0x004021F9 File Offset: 0x004003F9
	// (set) Token: 0x0600D813 RID: 55315 RVA: 0x00402201 File Offset: 0x00400401
	public string Path { get; set; }

	// Token: 0x17001403 RID: 5123
	// (get) Token: 0x0600D814 RID: 55316 RVA: 0x0040220A File Offset: 0x0040040A
	// (set) Token: 0x0600D815 RID: 55317 RVA: 0x00402212 File Offset: 0x00400412
	public List<string> FlowId { get; set; }

	// Token: 0x17001404 RID: 5124
	// (get) Token: 0x0600D816 RID: 55318 RVA: 0x0040221B File Offset: 0x0040041B
	// (set) Token: 0x0600D817 RID: 55319 RVA: 0x00402223 File Offset: 0x00400423
	public Action OnCloseCallBack { get; set; }
}
