using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004486 RID: 17542
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSkelSamplingFilteringMode.ENiagaraSkelSamplingFilteringMode")]
	public enum ENiagaraSkelSamplingFilteringMode : byte
	{
		// Token: 0x04018293 RID: 98963
		All,
		// Token: 0x04018294 RID: 98964
		Filtered,
		// Token: 0x04018295 RID: 98965
		Unfiltered,
		// Token: 0x04018296 RID: 98966
		ENiagaraSkelSamplingFilteringMode_MAX
	}
}
