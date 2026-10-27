using System;
using System.Runtime.CompilerServices;

// Token: 0x0200311A RID: 12570
[NullableContext(1)]
[Nullable(0)]
public class IStopMoveParams : IActionParamMap
{
	// Token: 0x17002567 RID: 9575
	// (get) Token: 0x0601B03B RID: 110651 RVA: 0x00754EC0 File Offset: 0x007530C0
	// (set) Token: 0x0601B03C RID: 110652 RVA: 0x00754EC8 File Offset: 0x007530C8
	public int SplineId { get; set; }

	// Token: 0x17002568 RID: 9576
	// (get) Token: 0x0601B03D RID: 110653 RVA: 0x00754ED1 File Offset: 0x007530D1
	// (set) Token: 0x0601B03E RID: 110654 RVA: 0x00754ED9 File Offset: 0x007530D9
	public string Context { get; set; }

	// Token: 0x17002569 RID: 9577
	// (get) Token: 0x0601B03F RID: 110655 RVA: 0x00754EE2 File Offset: 0x007530E2
	// (set) Token: 0x0601B040 RID: 110656 RVA: 0x00754EEA File Offset: 0x007530EA
	public EStopMoveMethod? Method { get; set; }
}
