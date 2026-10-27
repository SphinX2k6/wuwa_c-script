using System;
using System.Runtime.CompilerServices;

// Token: 0x020027F4 RID: 10228
[NullableContext(1)]
[Nullable(0)]
public class PlanSwitchButtonState : IPlanSwitchButtonState
{
	// Token: 0x17001BA8 RID: 7080
	// (get) Token: 0x06014FF7 RID: 86007 RVA: 0x005513EC File Offset: 0x0054F5EC
	// (set) Token: 0x06014FF8 RID: 86008 RVA: 0x005513F4 File Offset: 0x0054F5F4
	public bool IsShow { get; set; }

	// Token: 0x17001BA9 RID: 7081
	// (get) Token: 0x06014FF9 RID: 86009 RVA: 0x005513FD File Offset: 0x0054F5FD
	// (set) Token: 0x06014FFA RID: 86010 RVA: 0x00551405 File Offset: 0x0054F605
	public string Text { get; set; } = string.Empty;

	// Token: 0x17001BAA RID: 7082
	// (get) Token: 0x06014FFB RID: 86011 RVA: 0x0055140E File Offset: 0x0054F60E
	// (set) Token: 0x06014FFC RID: 86012 RVA: 0x00551416 File Offset: 0x0054F616
	public bool IsHighlight { get; set; }
}
