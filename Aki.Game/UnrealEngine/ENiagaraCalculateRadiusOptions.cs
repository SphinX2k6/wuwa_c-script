using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004466 RID: 17510
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraCalculateRadiusOptions.ENiagaraCalculateRadiusOptions")]
	public enum ENiagaraCalculateRadiusOptions : byte
	{
		// Token: 0x040181EF RID: 98799
		Bounds,
		// Token: 0x040181F0 RID: 98800
		Minimum_Axis,
		// Token: 0x040181F1 RID: 98801
		Maximum_Axis,
		// Token: 0x040181F2 RID: 98802
		ENiagaraCalculateRadiusOptions_MAX
	}
}
