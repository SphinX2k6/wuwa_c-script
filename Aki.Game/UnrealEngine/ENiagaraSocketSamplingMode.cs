using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004488 RID: 17544
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSocketSamplingMode.ENiagaraSocketSamplingMode")]
	public enum ENiagaraSocketSamplingMode : byte
	{
		// Token: 0x0401829F RID: 98975
		Random__Filtered_Sockets_,
		// Token: 0x040182A0 RID: 98976
		Direct__Filtered_Sockets_,
		// Token: 0x040182A1 RID: 98977
		ENiagaraSocketSamplingMode_MAX
	}
}
