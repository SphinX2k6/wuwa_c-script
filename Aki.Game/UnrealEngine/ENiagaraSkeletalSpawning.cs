using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004485 RID: 17541
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSkeletalSpawning.ENiagaraSkeletalSpawning")]
	public enum ENiagaraSkeletalSpawning : byte
	{
		// Token: 0x0401828E RID: 98958
		Bones,
		// Token: 0x0401828F RID: 98959
		Sockets,
		// Token: 0x04018290 RID: 98960
		Bones_and_Sockets,
		// Token: 0x04018291 RID: 98961
		ENiagaraSkeletalSpawning_MAX
	}
}
