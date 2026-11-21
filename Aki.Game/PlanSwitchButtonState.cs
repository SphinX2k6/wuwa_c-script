using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D6F RID: 7535
[NullableContext(1)]
[Nullable(0)]
public class PlanSwitchButtonState : IPlanSwitchButtonState
{
	// Token: 0x17001C00 RID: 7168
	// (get) Token: 0x060129F7 RID: 76279 RVA: 0x0057C15C File Offset: 0x0057A35C
	// (set) Token: 0x060129F8 RID: 76280 RVA: 0x0057C164 File Offset: 0x0057A364
	public bool IsShow { get; set; }

	// Token: 0x17001C01 RID: 7169
	// (get) Token: 0x060129F9 RID: 76281 RVA: 0x0057C16D File Offset: 0x0057A36D
	// (set) Token: 0x060129FA RID: 76282 RVA: 0x0057C175 File Offset: 0x0057A375
	public string Text { get; set; } = string.Empty;

	// Token: 0x17001C02 RID: 7170
	// (get) Token: 0x060129FB RID: 76283 RVA: 0x0057C17E File Offset: 0x0057A37E
	// (set) Token: 0x060129FC RID: 76284 RVA: 0x0057C186 File Offset: 0x0057A386
	public bool IsHighlight { get; set; }
}
