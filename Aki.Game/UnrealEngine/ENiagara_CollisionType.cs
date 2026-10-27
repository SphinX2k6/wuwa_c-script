using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004498 RID: 17560
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_CollisionType.ENiagara_CollisionType")]
	public enum ENiagara_CollisionType : byte
	{
		// Token: 0x040182F1 RID: 99057
		GPU_Depth_Buffer,
		// Token: 0x040182F2 RID: 99058
		GPU_Distance_Fields,
		// Token: 0x040182F3 RID: 99059
		ENiagara_MAX
	}
}
