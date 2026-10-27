using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449F RID: 17567
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_EmitterStateOptions.ENiagara_EmitterStateOptions")]
	public enum ENiagara_EmitterStateOptions : byte
	{
		// Token: 0x04018311 RID: 99089
		Infinite,
		// Token: 0x04018312 RID: 99090
		Once,
		// Token: 0x04018313 RID: 99091
		Multiple,
		// Token: 0x04018314 RID: 99092
		ENiagara_MAX
	}
}
