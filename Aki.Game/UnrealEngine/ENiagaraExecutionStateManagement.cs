using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200446E RID: 17518
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraExecutionStateManagement.ENiagaraExecutionStateManagement")]
	public enum ENiagaraExecutionStateManagement : byte
	{
		// Token: 0x04018216 RID: 98838
		Awaken,
		// Token: 0x04018217 RID: 98839
		Sleep_and_Let_Particles_Finish,
		// Token: 0x04018218 RID: 98840
		Sleep_and_Clear_Particles,
		// Token: 0x04018219 RID: 98841
		Kill_Immediately,
		// Token: 0x0401821A RID: 98842
		Kill_After_Particles_Finish,
		// Token: 0x0401821B RID: 98843
		ENiagaraExecutionStateManagement_MAX
	}
}
