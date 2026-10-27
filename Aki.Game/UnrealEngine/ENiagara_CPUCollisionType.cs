using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200449A RID: 17562
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_CPUCollisionType.ENiagara_CPUCollisionType")]
	public enum ENiagara_CPUCollisionType : byte
	{
		// Token: 0x040182FB RID: 99067
		Ray_Traced,
		// Token: 0x040182FC RID: 99068
		Analytical_Planes,
		// Token: 0x040182FD RID: 99069
		ENiagara_MAX
	}
}
