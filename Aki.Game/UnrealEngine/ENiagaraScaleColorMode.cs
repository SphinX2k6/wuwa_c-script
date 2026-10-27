using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004483 RID: 17539
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraScaleColorMode.ENiagaraScaleColorMode")]
	public enum ENiagaraScaleColorMode : byte
	{
		// Token: 0x04018286 RID: 98950
		RGB_and_Alpha_Separately,
		// Token: 0x04018287 RID: 98951
		RGBA_Together,
		// Token: 0x04018288 RID: 98952
		ENiagaraScaleColorMode_MAX
	}
}
