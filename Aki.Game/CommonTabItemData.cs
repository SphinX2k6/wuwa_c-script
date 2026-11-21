using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E77 RID: 3703
public class CommonTabItemData
{
	// Token: 0x04005715 RID: 22293
	public int Index;

	// Token: 0x04005716 RID: 22294
	[Nullable(2)]
	public CommonTabData Data;

	// Token: 0x04005717 RID: 22295
	public ERedDotName? RedDotName;

	// Token: 0x04005718 RID: 22296
	public int? RedDotUid;

	// Token: 0x04005719 RID: 22297
	public bool NeedUnBindAllRedDot = true;
}
