using System;
using System.Runtime.CompilerServices;

// Token: 0x02002150 RID: 8528
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F5 RID: 5365
	// (get) Token: 0x06010A2A RID: 68138 RVA: 0x0040C016 File Offset: 0x0040A216
	// (set) Token: 0x06010A2B RID: 68139 RVA: 0x0040C01E File Offset: 0x0040A21E
	public override string event_id { get; set; } = "1835";

	// Token: 0x04007DDC RID: 32220
	public int i_area_id;

	// Token: 0x04007DDD RID: 32221
	public int i_slot_id;

	// Token: 0x04007DDE RID: 32222
	public int i_sub_slot_index;

	// Token: 0x04007DDF RID: 32223
	public int i_new_furniture_id;

	// Token: 0x04007DE0 RID: 32224
	public int i_old_furniture_id;

	// Token: 0x04007DE1 RID: 32225
	public int i_type;

	// Token: 0x04007DE2 RID: 32226
	public int i_if_finish;

	// Token: 0x04007DE3 RID: 32227
	public string s_trace_id = "";
}
