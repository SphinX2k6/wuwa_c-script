using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1D RID: 15645
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/EPlantType.EPlantType")]
	public enum EPlantType : byte
	{
		// Token: 0x04012C03 RID: 76803
		SlenderJadeBamboo,
		// Token: 0x04012C04 RID: 76804
		BroadJadeBamboo,
		// Token: 0x04012C05 RID: 76805
		Grass,
		// Token: 0x04012C06 RID: 76806
		Flower,
		// Token: 0x04012C07 RID: 76807
		Reed,
		// Token: 0x04012C08 RID: 76808
		Vegetation,
		// Token: 0x04012C09 RID: 76809
		EPlantType_MAX
	}
}
