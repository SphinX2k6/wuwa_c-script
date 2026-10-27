using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004461 RID: 17505
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraArraySamplingMode.ENiagaraArraySamplingMode")]
	public enum ENiagaraArraySamplingMode : byte
	{
		// Token: 0x040181D0 RID: 98768
		Random,
		// Token: 0x040181D1 RID: 98769
		Direct,
		// Token: 0x040181D2 RID: 98770
		Interpolate,
		// Token: 0x040181D3 RID: 98771
		ENiagaraArraySamplingMode_MAX
	}
}
