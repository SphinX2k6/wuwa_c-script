using System;
using System.Runtime.CompilerServices;

// Token: 0x02001649 RID: 5705
[NullableContext(1)]
[Nullable(0)]
public class WuWaGoGameplayFinishEvent : PlayerCommonLogData
{
	// Token: 0x17001541 RID: 5441
	// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x00418C32 File Offset: 0x00416E32
	// (set) Token: 0x0600DEFB RID: 57083 RVA: 0x00418C3A File Offset: 0x00416E3A
	public override string event_id { get; set; } = "1929";

	// Token: 0x04007F82 RID: 32642
	public int i_level_play_id;

	// Token: 0x04007F83 RID: 32643
	public int i_result_type;

	// Token: 0x04007F84 RID: 32644
	public int savepoint_count;

	// Token: 0x04007F85 RID: 32645
	public int back_count;

	// Token: 0x04007F86 RID: 32646
	public int reset_count;

	// Token: 0x04007F87 RID: 32647
	public int tip_count;
}
