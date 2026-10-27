using System;
using System.Runtime.CompilerServices;

// Token: 0x0200215A RID: 8538
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardPlanRecycleReport : PlayerCommonLogData
{
	// Token: 0x170014FC RID: 5372
	// (get) Token: 0x06010A42 RID: 68162 RVA: 0x0040C156 File Offset: 0x0040A356
	// (set) Token: 0x06010A43 RID: 68163 RVA: 0x0040C15E File Offset: 0x0040A35E
	public override string event_id { get; set; } = "1842";

	// Token: 0x04007E0F RID: 32271
	public int i_type;

	// Token: 0x04007E10 RID: 32272
	public int i_operation;
}
