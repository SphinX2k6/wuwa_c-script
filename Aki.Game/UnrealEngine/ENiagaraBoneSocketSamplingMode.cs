using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004463 RID: 17507
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraBoneSocketSamplingMode.ENiagaraBoneSocketSamplingMode")]
	public enum ENiagaraBoneSocketSamplingMode : byte
	{
		// Token: 0x040181DD RID: 98781
		Random__Filtered_Bone_or_Sockets_,
		// Token: 0x040181DE RID: 98782
		Direct__Filtered_Bone_or_Sockets_,
		// Token: 0x040181DF RID: 98783
		ENiagaraBoneSocketSamplingMode_MAX
	}
}
