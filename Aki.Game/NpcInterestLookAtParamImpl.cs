using System;
using System.Runtime.CompilerServices;

// Token: 0x0200275D RID: 10077
[NullableContext(1)]
[Nullable(0)]
public class NpcInterestLookAtParamImpl : INpcInterestLookAtParam
{
	// Token: 0x17002862 RID: 10338
	// (get) Token: 0x060194C5 RID: 103621 RVA: 0x007BAA95 File Offset: 0x007B8C95
	// (set) Token: 0x060194C6 RID: 103622 RVA: 0x007BAA9D File Offset: 0x007B8C9D
	public int TargetPbDataId { get; set; }

	// Token: 0x17002863 RID: 10339
	// (get) Token: 0x060194C7 RID: 103623 RVA: 0x007BAAA6 File Offset: 0x007B8CA6
	// (set) Token: 0x060194C8 RID: 103624 RVA: 0x007BAAAE File Offset: 0x007B8CAE
	public Vector TargetPosition { get; set; }

	// Token: 0x17002864 RID: 10340
	// (get) Token: 0x060194C9 RID: 103625 RVA: 0x007BAAB7 File Offset: 0x007B8CB7
	// (set) Token: 0x060194CA RID: 103626 RVA: 0x007BAABF File Offset: 0x007B8CBF
	public float MaxAngle { get; set; }

	// Token: 0x17002865 RID: 10341
	// (get) Token: 0x060194CB RID: 103627 RVA: 0x007BAAC8 File Offset: 0x007B8CC8
	// (set) Token: 0x060194CC RID: 103628 RVA: 0x007BAAD0 File Offset: 0x007B8CD0
	public float MaxDistance { get; set; }
}
