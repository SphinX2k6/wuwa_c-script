using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A84 RID: 10884
[NullableContext(1)]
[Nullable(0)]
public class SetSubLevelVisibleProcess : SubLevelProcess
{
	// Token: 0x0601B976 RID: 113014 RVA: 0x008800A3 File Offset: 0x0087E2A3
	public SetSubLevelVisibleProcess(SetSubLevelVisibleParams param) : base(ESubLevelProcessType.SetSubLevelVisible)
	{
	}

	// Token: 0x0400EE66 RID: 61030
	public SetSubLevelVisibleParams Params = param;
}
