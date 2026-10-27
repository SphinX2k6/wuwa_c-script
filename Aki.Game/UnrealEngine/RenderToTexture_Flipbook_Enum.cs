using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004453 RID: 17491
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Engine/ArtTools/RenderToTexture/Enums/RenderToTexture_Flipbook_Enum.RenderToTexture_Flipbook_Enum")]
	public enum RenderToTexture_Flipbook_Enum : byte
	{
		// Token: 0x04018174 RID: 98676
		Simple_Mesh_rotation,
		// Token: 0x04018175 RID: 98677
		Material_Instance_Interpolation,
		// Token: 0x04018176 RID: 98678
		Both_Mesh_rotation_and_Material_Instance_Interpolation,
		// Token: 0x04018177 RID: 98679
		RenderToTexture_Flipbook_MAX
	}
}
