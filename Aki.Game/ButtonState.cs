using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D6D RID: 7533
[NullableContext(1)]
[Nullable(0)]
public class ButtonState : IButtonState
{
	// Token: 0x17001BFB RID: 7163
	// (get) Token: 0x060129EC RID: 76268 RVA: 0x0057C127 File Offset: 0x0057A327
	// (set) Token: 0x060129ED RID: 76269 RVA: 0x0057C12F File Offset: 0x0057A32F
	public string Text { get; set; } = string.Empty;

	// Token: 0x17001BFC RID: 7164
	// (get) Token: 0x060129EE RID: 76270 RVA: 0x0057C138 File Offset: 0x0057A338
	// (set) Token: 0x060129EF RID: 76271 RVA: 0x0057C140 File Offset: 0x0057A340
	public bool IsHighlight { get; set; }
}
