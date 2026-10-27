using System;
using System.Runtime.CompilerServices;

// Token: 0x020027F2 RID: 10226
[NullableContext(1)]
[Nullable(0)]
public class ButtonState : IButtonState
{
	// Token: 0x17001BA3 RID: 7075
	// (get) Token: 0x06014FEC RID: 85996 RVA: 0x005513B7 File Offset: 0x0054F5B7
	// (set) Token: 0x06014FED RID: 85997 RVA: 0x005513BF File Offset: 0x0054F5BF
	public string Text { get; set; } = string.Empty;

	// Token: 0x17001BA4 RID: 7076
	// (get) Token: 0x06014FEE RID: 85998 RVA: 0x005513C8 File Offset: 0x0054F5C8
	// (set) Token: 0x06014FEF RID: 85999 RVA: 0x005513D0 File Offset: 0x0054F5D0
	public bool IsHighlight { get; set; }
}
