using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020044AA RID: 17578
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_RotationDefinitionApproach.ENiagara_RotationDefinitionApproach")]
	public enum ENiagara_RotationDefinitionApproach : byte
	{
		// Token: 0x04018347 RID: 99143
		Euler,
		// Token: 0x04018348 RID: 99144
		Quaternion,
		// Token: 0x04018349 RID: 99145
		Axis_Angle_,
		// Token: 0x0401834A RID: 99146
		Basis_Vectors,
		// Token: 0x0401834B RID: 99147
		Matrix,
		// Token: 0x0401834C RID: 99148
		ENiagara_MAX
	}
}
