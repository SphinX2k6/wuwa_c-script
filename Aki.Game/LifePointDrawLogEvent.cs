using System;
using System.Runtime.CompilerServices;

// Token: 0x02002114 RID: 8468
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BA RID: 5306
	// (get) Token: 0x06010978 RID: 67960 RVA: 0x0040B520 File Offset: 0x00409720
	// (set) Token: 0x06010979 RID: 67961 RVA: 0x0040B528 File Offset: 0x00409728
	public override string event_id { get; set; } = "1704";

	// Token: 0x04007CA7 RID: 31911
	public int i_config_id;

	// Token: 0x04007CA8 RID: 31912
	public int i_group_entity_id;

	// Token: 0x04007CA9 RID: 31913
	public string s_type_name = "";

	// Token: 0x04007CAA RID: 31914
	public int i_result;

	// Token: 0x04007CAB RID: 31915
	public int i_try_count;
}
