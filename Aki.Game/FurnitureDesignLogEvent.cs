using System;
using System.Runtime.CompilerServices;

// Token: 0x02001628 RID: 5672
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignLogEvent : PlayerCommonLogData
{
	// Token: 0x17001523 RID: 5411
	// (get) Token: 0x0600DE9D RID: 56989 RVA: 0x0041875E File Offset: 0x0041695E
	// (set) Token: 0x0600DE9E RID: 56990 RVA: 0x00418766 File Offset: 0x00416966
	public override string event_id { get; set; } = "1835";

	// Token: 0x04007EEC RID: 32492
	public int i_area_id;

	// Token: 0x04007EED RID: 32493
	public int i_slot_id;

	// Token: 0x04007EEE RID: 32494
	public int i_sub_slot_index;

	// Token: 0x04007EEF RID: 32495
	public int i_new_furniture_id;

	// Token: 0x04007EF0 RID: 32496
	public int i_old_furniture_id;

	// Token: 0x04007EF1 RID: 32497
	public int i_type;

	// Token: 0x04007EF2 RID: 32498
	public int i_if_finish;

	// Token: 0x04007EF3 RID: 32499
	public string s_trace_id = "";
}
