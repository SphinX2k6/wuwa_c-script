using System;
using System.Runtime.CompilerServices;

// Token: 0x02002171 RID: 8561
[NullableContext(1)]
[Nullable(0)]
public class WuWaGoGameplayFinishEvent : PlayerCommonLogData
{
	// Token: 0x17001513 RID: 5395
	// (get) Token: 0x06010A87 RID: 68231 RVA: 0x0040C4EA File Offset: 0x0040A6EA
	// (set) Token: 0x06010A88 RID: 68232 RVA: 0x0040C4F2 File Offset: 0x0040A6F2
	public override string event_id { get; set; } = "1929";

	// Token: 0x04007E72 RID: 32370
	public int i_level_play_id;

	// Token: 0x04007E73 RID: 32371
	public int i_result_type;

	// Token: 0x04007E74 RID: 32372
	public int savepoint_count;

	// Token: 0x04007E75 RID: 32373
	public int back_count;

	// Token: 0x04007E76 RID: 32374
	public int reset_count;

	// Token: 0x04007E77 RID: 32375
	public int tip_count;
}
