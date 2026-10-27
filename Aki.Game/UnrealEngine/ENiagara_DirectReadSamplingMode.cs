using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449D RID: 17565
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_DirectReadSamplingMode.ENiagara_DirectReadSamplingMode")]
	public enum ENiagara_DirectReadSamplingMode : byte
	{
		// Token: 0x04018308 RID: 99080
		Disabled,
		// Token: 0x04018309 RID: 99081
		Apply_to_Attribute,
		// Token: 0x0401830A RID: 99082
		Output_Only,
		// Token: 0x0401830B RID: 99083
		ENiagara_MAX
	}
}
