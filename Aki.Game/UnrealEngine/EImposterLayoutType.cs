using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004456 RID: 17494
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/ImpostorBaker/ImpostorBaker/BP/Enums/EImposterLayoutType.EImposterLayoutType")]
	public enum EImposterLayoutType : byte
	{
		// Token: 0x04018188 RID: 98696
		Full_Sphere_View,
		// Token: 0x04018189 RID: 98697
		Upper_Hemisphere_Only,
		// Token: 0x0401818A RID: 98698
		Traditional_Billboards,
		// Token: 0x0401818B RID: 98699
		EImposterLayoutType_MAX
	}
}
