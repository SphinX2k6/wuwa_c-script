using System;
using System.Runtime.CompilerServices;

// Token: 0x0200285E RID: 10334
[NullableContext(1)]
[Nullable(0)]
public class WaterfallMoveParams : IWaterfallMoveParams
{
	// Token: 0x17002AAA RID: 10922
	// (get) Token: 0x0601A280 RID: 107136 RVA: 0x00815937 File Offset: 0x00813B37
	// (set) Token: 0x0601A281 RID: 107137 RVA: 0x0081593F File Offset: 0x00813B3F
	public int SplineId { get; set; }

	// Token: 0x17002AAB RID: 10923
	// (get) Token: 0x0601A282 RID: 107138 RVA: 0x00815948 File Offset: 0x00813B48
	// (set) Token: 0x0601A283 RID: 107139 RVA: 0x00815950 File Offset: 0x00813B50
	public Vector Direct { get; set; }

	// Token: 0x17002AAC RID: 10924
	// (get) Token: 0x0601A284 RID: 107140 RVA: 0x00815959 File Offset: 0x00813B59
	// (set) Token: 0x0601A285 RID: 107141 RVA: 0x00815961 File Offset: 0x00813B61
	[Nullable(2)]
	public Vector ChangeGravity { [NullableContext(2)] get; [NullableContext(2)] set; }
}
