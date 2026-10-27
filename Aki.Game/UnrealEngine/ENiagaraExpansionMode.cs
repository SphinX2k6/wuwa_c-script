using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200446F RID: 17519
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraExpansionMode.ENiagaraExpansionMode")]
	public enum ENiagaraExpansionMode : byte
	{
		// Token: 0x0401821D RID: 98845
		Inside,
		// Token: 0x0401821E RID: 98846
		Centered,
		// Token: 0x0401821F RID: 98847
		Outside,
		// Token: 0x04018220 RID: 98848
		ENiagaraExpansionMode_MAX
	}
}
