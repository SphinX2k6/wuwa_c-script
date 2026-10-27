using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02004452 RID: 17490
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Engine/ArtTools/RenderToTexture/Enums/RenderToTexture_Enum.RenderToTexture_Enum")]
	public enum RenderToTexture_Enum : byte
	{
		// Token: 0x04018169 RID: 98665
		Material,
		// Token: 0x0401816A RID: 98666
		_3D_Imposter_Sprites,
		// Token: 0x0401816B RID: 98667
		Unwrapped_Mesh,
		// Token: 0x0401816C RID: 98668
		Depth_Map,
		// Token: 0x0401816D RID: 98669
		Lightmaps,
		// Token: 0x0401816E RID: 98670
		Lightmaps_2_sided,
		// Token: 0x0401816F RID: 98671
		Flipbook_Mesh_Animation,
		// Token: 0x04018170 RID: 98672
		Physics_Ground___Tiling_Physics_Drop_of_Meshes,
		// Token: 0x04018171 RID: 98673
		Tiling_Material_from_Hand_Placed_Meshes,
		// Token: 0x04018172 RID: 98674
		RenderToTexture_MAX
	}
}
