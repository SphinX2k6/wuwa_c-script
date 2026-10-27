using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004487 RID: 17543
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagaraSkelSamplingModeFull.ENiagaraSkelSamplingModeFull")]
	public enum ENiagaraSkelSamplingModeFull : byte
	{
		// Token: 0x04018298 RID: 98968
		Skeleton__Bones_,
		// Token: 0x04018299 RID: 98969
		Skeleton__Sockets_,
		// Token: 0x0401829A RID: 98970
		Skeleton__Bones_and_Sockets_,
		// Token: 0x0401829B RID: 98971
		Surface__Triangles_,
		// Token: 0x0401829C RID: 98972
		Surface__Vertices_,
		// Token: 0x0401829D RID: 98973
		ENiagaraSkelSamplingModeFull_MAX
	}
}
