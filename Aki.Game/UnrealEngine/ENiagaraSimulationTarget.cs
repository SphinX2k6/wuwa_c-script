using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004484 RID: 17540
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSimulationTarget.ENiagaraSimulationTarget")]
	public enum ENiagaraSimulationTarget : byte
	{
		// Token: 0x0401828A RID: 98954
		CPU_Sim,
		// Token: 0x0401828B RID: 98955
		GPUCompute_Sim,
		// Token: 0x0401828C RID: 98956
		ENiagaraSimulationTarget_MAX
	}
}
