using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E85 RID: 3717
public class CommonPropTipsButtonData
{
	// Token: 0x0400573F RID: 22335
	[Nullable(1)]
	public string Content = "";

	// Token: 0x04005740 RID: 22336
	public bool NeedInteractionGroup;

	// Token: 0x04005741 RID: 22337
	[Nullable(2)]
	public Action<int> ClickFunction;
}
