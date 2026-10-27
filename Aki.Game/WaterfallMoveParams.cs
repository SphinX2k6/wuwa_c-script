using System;
using System.Runtime.CompilerServices;

// Token: 0x020032EC RID: 13036
[NullableContext(1)]
[Nullable(0)]
public class WaterfallMoveParams : IWaterfallMoveParams
{
	// Token: 0x17002743 RID: 10051
	// (get) Token: 0x0601C5C5 RID: 116165 RVA: 0x007EF291 File Offset: 0x007ED491
	// (set) Token: 0x0601C5C6 RID: 116166 RVA: 0x007EF299 File Offset: 0x007ED499
	public int SplineId { get; set; }

	// Token: 0x17002744 RID: 10052
	// (get) Token: 0x0601C5C7 RID: 116167 RVA: 0x007EF2A2 File Offset: 0x007ED4A2
	// (set) Token: 0x0601C5C8 RID: 116168 RVA: 0x007EF2AA File Offset: 0x007ED4AA
	public Vector Direct { get; set; }

	// Token: 0x17002745 RID: 10053
	// (get) Token: 0x0601C5C9 RID: 116169 RVA: 0x007EF2B3 File Offset: 0x007ED4B3
	// (set) Token: 0x0601C5CA RID: 116170 RVA: 0x007EF2BB File Offset: 0x007ED4BB
	[Nullable(2)]
	public Vector ChangeGravity { [NullableContext(2)] get; [NullableContext(2)] set; }
}
