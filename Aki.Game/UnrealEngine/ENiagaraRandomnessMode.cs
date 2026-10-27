using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004481 RID: 17537
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraRandomnessMode.ENiagaraRandomnessMode")]
	public enum ENiagaraRandomnessMode : byte
	{
		// Token: 0x0401827B RID: 98939
		Simulation_Defaults,
		// Token: 0x0401827C RID: 98940
		Determinisitic,
		// Token: 0x0401827D RID: 98941
		Non_Deterministic,
		// Token: 0x0401827E RID: 98942
		ENiagaraRandomnessMode_MAX
	}
}
