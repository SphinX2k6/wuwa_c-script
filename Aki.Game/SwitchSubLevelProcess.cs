using System;
using System.Runtime.CompilerServices;

// Token: 0x0200350E RID: 13582
[NullableContext(1)]
[Nullable(0)]
public class SwitchSubLevelProcess : SubLevelProcess
{
	// Token: 0x0601DC5B RID: 121947 RVA: 0x00857AC7 File Offset: 0x00855CC7
	public SwitchSubLevelProcess(SwitchSubLevelParams param) : base(ESubLevelProcessType.SwitchSubLevel)
	{
	}

	// Token: 0x0400E9AA RID: 59818
	public SwitchSubLevelParams Params = param;
}
