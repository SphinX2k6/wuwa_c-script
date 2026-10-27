using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004457 RID: 17495
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/ImpostorBaker/ImpostorBaker/BP/Enums/EImpostorBakeTypes.EImpostorBakeTypes")]
	public enum EImpostorBakeTypes : byte
	{
		// Token: 0x0401818D RID: 98701
		BaseColor,
		// Token: 0x0401818E RID: 98702
		Metallic,
		// Token: 0x0401818F RID: 98703
		Specular,
		// Token: 0x04018190 RID: 98704
		Roughness,
		// Token: 0x04018191 RID: 98705
		Emissive,
		// Token: 0x04018192 RID: 98706
		Opacity,
		// Token: 0x04018193 RID: 98707
		WorldNormal,
		// Token: 0x04018194 RID: 98708
		Subsurface,
		// Token: 0x04018195 RID: 98709
		Depth,
		// Token: 0x04018196 RID: 98710
		Lit,
		// Token: 0x04018197 RID: 98711
		CustomLighting,
		// Token: 0x04018198 RID: 98712
		EImpostorBakeTypes_MAX
	}
}
