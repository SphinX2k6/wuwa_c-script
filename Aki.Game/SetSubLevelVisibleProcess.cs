using System;
using System.Runtime.CompilerServices;

// Token: 0x0200350F RID: 13583
[NullableContext(1)]
[Nullable(0)]
public class SetSubLevelVisibleProcess : SubLevelProcess
{
	// Token: 0x0601DC5C RID: 121948 RVA: 0x00857AD7 File Offset: 0x00855CD7
	public SetSubLevelVisibleProcess(SetSubLevelVisibleParams param) : base(ESubLevelProcessType.SetSubLevelVisible)
	{
	}

	// Token: 0x0400E9AB RID: 59819
	public SetSubLevelVisibleParams Params = param;
}
