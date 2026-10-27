using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004479 RID: 17529
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraMeshSamplingMode.ENiagaraMeshSamplingMode")]
	public enum ENiagaraMeshSamplingMode : byte
	{
		// Token: 0x04018253 RID: 98899
		Random,
		// Token: 0x04018254 RID: 98900
		Direct,
		// Token: 0x04018255 RID: 98901
		ENiagaraMeshSamplingMode_MAX
	}
}
