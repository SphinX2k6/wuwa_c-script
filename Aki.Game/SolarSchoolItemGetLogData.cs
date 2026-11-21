using System;
using System.Runtime.CompilerServices;

// Token: 0x0200165F RID: 5727
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolItemGetLogData : SolarSchoolLogData
{
	// Token: 0x17001552 RID: 5458
	// (get) Token: 0x0600DF32 RID: 57138 RVA: 0x00418F76 File Offset: 0x00417176
	// (set) Token: 0x0600DF33 RID: 57139 RVA: 0x00418F7E File Offset: 0x0041717E
	public override string event_id { get; set; } = "2101";

	// Token: 0x0400800F RID: 32783
	public int i_activity_type;

	// Token: 0x04008010 RID: 32784
	public int i_item_id;

	// Token: 0x04008011 RID: 32785
	public int i_count;

	// Token: 0x04008012 RID: 32786
	public int i_type;
}
