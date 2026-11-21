using System;
using System.Runtime.CompilerServices;

// Token: 0x02001610 RID: 5648
[NullableContext(1)]
[Nullable(0)]
public class BirthdayRepeatEnterEvent : PlayerCommonLogData
{
	// Token: 0x1700150C RID: 5388
	// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x00418329 File Offset: 0x00416529
	// (set) Token: 0x0600DE58 RID: 56920 RVA: 0x00418331 File Offset: 0x00416531
	public override string event_id { get; set; } = "1063";

	// Token: 0x04007E63 RID: 32355
	public int i_item_id;

	// Token: 0x04007E64 RID: 32356
	public int i_trigger_type;

	// Token: 0x04007E65 RID: 32357
	public int bird_round_id;
}
