using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E1 RID: 8417
[NullableContext(1)]
[Nullable(0)]
public class ActivityLockConditionClickLogData : PlayerCommonLogData
{
	// Token: 0x17001489 RID: 5257
	// (get) Token: 0x060108E3 RID: 67811 RVA: 0x0040AD72 File Offset: 0x00408F72
	// (set) Token: 0x060108E4 RID: 67812 RVA: 0x0040AD7A File Offset: 0x00408F7A
	public override string event_id { get; set; } = "1029";

	// Token: 0x04007C00 RID: 31744
	public int i_activity_id;

	// Token: 0x04007C01 RID: 31745
	public int i_activity_type;
}
