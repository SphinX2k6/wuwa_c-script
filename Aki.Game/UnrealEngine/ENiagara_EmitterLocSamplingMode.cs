using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449E RID: 17566
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_EmitterLocSamplingMode.ENiagara_EmitterLocSamplingMode")]
	public enum ENiagara_EmitterLocSamplingMode : byte
	{
		// Token: 0x0401830D RID: 99085
		Random,
		// Token: 0x0401830E RID: 99086
		Sequential,
		// Token: 0x0401830F RID: 99087
		ENiagara_MAX
	}
}
