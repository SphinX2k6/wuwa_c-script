using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200448B RID: 17547
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSystemInactiveMode.ENiagaraSystemInactiveMode")]
	public enum ENiagaraSystemInactiveMode : byte
	{
		// Token: 0x040182AC RID: 98988
		Complete__Let_Emitters_Finish_then_Kill_The_System_,
		// Token: 0x040182AD RID: 98989
		Kill__System_and_Emitters_Die_Immediately_,
		// Token: 0x040182AE RID: 98990
		ENiagaraSystemInactiveMode_MAX
	}
}
