using System;
using System.Runtime.CompilerServices;

// Token: 0x0200163C RID: 5692
[NullableContext(1)]
[Nullable(0)]
public class NextVersionContentLogEvent : PlayerCommonLogData
{
	// Token: 0x17001534 RID: 5428
	// (get) Token: 0x0600DED3 RID: 57043 RVA: 0x00418A32 File Offset: 0x00416C32
	// (set) Token: 0x0600DED4 RID: 57044 RVA: 0x00418A3A File Offset: 0x00416C3A
	public override string event_id { get; set; } = "1813";

	// Token: 0x04007F49 RID: 32585
	public int i_activity_id;

	// Token: 0x04007F4A RID: 32586
	public int i_second_tab;

	// Token: 0x04007F4B RID: 32587
	public int i_third_tab;
}
