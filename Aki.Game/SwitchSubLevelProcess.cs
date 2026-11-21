using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A83 RID: 10883
[NullableContext(1)]
[Nullable(0)]
public class SwitchSubLevelProcess : SubLevelProcess
{
	// Token: 0x0601B975 RID: 113013 RVA: 0x00880093 File Offset: 0x0087E293
	public SwitchSubLevelProcess(SwitchSubLevelParams param) : base(ESubLevelProcessType.SwitchSubLevel)
	{
	}

	// Token: 0x0400EE65 RID: 61029
	public SwitchSubLevelParams Params = param;
}
