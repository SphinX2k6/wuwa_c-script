using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044A2 RID: 17570
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_GPUCollisionType.ENiagara_GPUCollisionType")]
	public enum ENiagara_GPUCollisionType : byte
	{
		// Token: 0x04018320 RID: 99104
		GPU_Depth_Buffer,
		// Token: 0x04018321 RID: 99105
		GPU_Distance_Fields,
		// Token: 0x04018322 RID: 99106
		Analytical_Planes,
		// Token: 0x04018323 RID: 99107
		ENiagara_MAX
	}
}
