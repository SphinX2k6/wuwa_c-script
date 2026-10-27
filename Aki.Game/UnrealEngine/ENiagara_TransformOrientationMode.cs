using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044B1 RID: 17585
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_TransformOrientationMode.ENiagara_TransformOrientationMode")]
	public enum ENiagara_TransformOrientationMode : byte
	{
		// Token: 0x0401836D RID: 99181
		Yaw_Pitch_Roll,
		// Token: 0x0401836E RID: 99182
		Quaternion,
		// Token: 0x0401836F RID: 99183
		Matrix,
		// Token: 0x04018370 RID: 99184
		Basis_Vectors,
		// Token: 0x04018371 RID: 99185
		ENiagara_MAX
	}
}
