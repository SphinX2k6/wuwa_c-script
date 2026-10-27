using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A0 RID: 17568
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_FadeOperationType.ENiagara_FadeOperationType")]
	public enum ENiagara_FadeOperationType : byte
	{
		// Token: 0x04018316 RID: 99094
		Linear,
		// Token: 0x04018317 RID: 99095
		Percentage,
		// Token: 0x04018318 RID: 99096
		ENiagara_MAX
	}
}
