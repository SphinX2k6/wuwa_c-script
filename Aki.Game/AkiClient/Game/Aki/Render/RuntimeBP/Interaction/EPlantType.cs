using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F3 RID: 12531
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/EPlantType.EPlantType")]
	public enum EPlantType : byte
	{
		// Token: 0x040101FA RID: 66042
		SlenderJadeBamboo,
		// Token: 0x040101FB RID: 66043
		BroadJadeBamboo,
		// Token: 0x040101FC RID: 66044
		Grass,
		// Token: 0x040101FD RID: 66045
		Flower,
		// Token: 0x040101FE RID: 66046
		Reed,
		// Token: 0x040101FF RID: 66047
		Vegetation,
		// Token: 0x04010200 RID: 66048
		EPlantType_MAX
	}
}
