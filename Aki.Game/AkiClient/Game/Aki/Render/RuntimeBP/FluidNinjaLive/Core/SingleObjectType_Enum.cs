using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA9 RID: 15785
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/SingleObjectType_Enum.SingleObjectType_Enum")]
	public enum SingleObjectType_Enum : byte
	{
		// Token: 0x04013C2D RID: 80941
		Skeletal_Mesh_Bone,
		// Token: 0x04013C2E RID: 80942
		Primitive_Component,
		// Token: 0x04013C2F RID: 80943
		SingleObjectType_MAX
	}
}
