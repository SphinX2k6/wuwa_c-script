using System;
using System.Runtime.CompilerServices;

// Token: 0x020031EE RID: 12782
[NullableContext(1)]
[Nullable(0)]
public class NpcInterestLookAtParamImpl : INpcInterestLookAtParam
{
	// Token: 0x17002621 RID: 9761
	// (get) Token: 0x0601B940 RID: 112960 RVA: 0x00792369 File Offset: 0x00790569
	// (set) Token: 0x0601B941 RID: 112961 RVA: 0x00792371 File Offset: 0x00790571
	public int TargetPbDataId { get; set; }

	// Token: 0x17002622 RID: 9762
	// (get) Token: 0x0601B942 RID: 112962 RVA: 0x0079237A File Offset: 0x0079057A
	// (set) Token: 0x0601B943 RID: 112963 RVA: 0x00792382 File Offset: 0x00790582
	public Vector TargetPosition { get; set; }

	// Token: 0x17002623 RID: 9763
	// (get) Token: 0x0601B944 RID: 112964 RVA: 0x0079238B File Offset: 0x0079058B
	// (set) Token: 0x0601B945 RID: 112965 RVA: 0x00792393 File Offset: 0x00790593
	public float MaxAngle { get; set; }

	// Token: 0x17002624 RID: 9764
	// (get) Token: 0x0601B946 RID: 112966 RVA: 0x0079239C File Offset: 0x0079059C
	// (set) Token: 0x0601B947 RID: 112967 RVA: 0x007923A4 File Offset: 0x007905A4
	public float MaxDistance { get; set; }
}
