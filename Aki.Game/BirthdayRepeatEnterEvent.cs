using System;
using System.Runtime.CompilerServices;

// Token: 0x02002138 RID: 8504
[NullableContext(1)]
[Nullable(0)]
public class BirthdayRepeatEnterEvent : PlayerCommonLogData
{
	// Token: 0x170014DE RID: 5342
	// (get) Token: 0x060109E4 RID: 68068 RVA: 0x0040BBE1 File Offset: 0x00409DE1
	// (set) Token: 0x060109E5 RID: 68069 RVA: 0x0040BBE9 File Offset: 0x00409DE9
	public override string event_id { get; set; } = "1063";

	// Token: 0x04007D53 RID: 32083
	public int i_item_id;

	// Token: 0x04007D54 RID: 32084
	public int i_trigger_type;

	// Token: 0x04007D55 RID: 32085
	public int bird_round_id;
}
