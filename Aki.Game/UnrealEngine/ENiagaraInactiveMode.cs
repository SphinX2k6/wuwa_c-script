using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004473 RID: 17523
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraInactiveMode.ENiagaraInactiveMode")]
	public enum ENiagaraInactiveMode : byte
	{
		// Token: 0x04018230 RID: 98864
		Complete__Let_Particles_Finish_then_Kill_Emitter_,
		// Token: 0x04018231 RID: 98865
		Kill__Emitter_and_Particles_Die_Immediately_,
		// Token: 0x04018232 RID: 98866
		Continue__Emitter_Deactivates_But_Doesn_t_Die_Until_System_Does_,
		// Token: 0x04018233 RID: 98867
		ENiagaraInactiveMode_MAX
	}
}
