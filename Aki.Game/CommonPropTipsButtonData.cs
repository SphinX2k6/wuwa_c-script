using System;
using System.Runtime.CompilerServices;

// Token: 0x020019C6 RID: 6598
public class CommonPropTipsButtonData
{
	// Token: 0x0400568D RID: 22157
	[Nullable(1)]
	public string Content = "";

	// Token: 0x0400568E RID: 22158
	public bool NeedInteractionGroup;

	// Token: 0x0400568F RID: 22159
	[Nullable(2)]
	public Action<int> ClickFunction;
}
