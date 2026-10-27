using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004480 RID: 17536
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraRandomnessEvaluation.ENiagaraRandomnessEvaluation")]
	public enum ENiagaraRandomnessEvaluation : byte
	{
		// Token: 0x04018277 RID: 98935
		Spawn_Only,
		// Token: 0x04018278 RID: 98936
		Every_Frame,
		// Token: 0x04018279 RID: 98937
		ENiagaraRandomnessEvaluation_MAX
	}
}
