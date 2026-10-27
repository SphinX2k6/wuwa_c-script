using System;
using System.Runtime.CompilerServices;

// Token: 0x020019B9 RID: 6585
public class CommonTabItemData
{
	// Token: 0x04005663 RID: 22115
	public int Index;

	// Token: 0x04005664 RID: 22116
	[Nullable(2)]
	public CommonTabData Data;

	// Token: 0x04005665 RID: 22117
	public ERedDotName? RedDotName;

	// Token: 0x04005666 RID: 22118
	public int? RedDotUid;

	// Token: 0x04005667 RID: 22119
	public bool NeedUnBindAllRedDot = true;
}
