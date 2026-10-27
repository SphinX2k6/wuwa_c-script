using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004434 RID: 17460
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/EAudioPhysicalSurface.EAudioPhysicalSurface")]
	public enum EAudioPhysicalSurface : byte
	{
		// Token: 0x04018041 RID: 98369
		DirtSurface,
		// Token: 0x04018042 RID: 98370
		ConcreteSurface,
		// Token: 0x04018043 RID: 98371
		GrassSurface,
		// Token: 0x04018044 RID: 98372
		MetalSheetSurface,
		// Token: 0x04018045 RID: 98373
		MetalHardSurface,
		// Token: 0x04018046 RID: 98374
		WoodFloorSurface,
		// Token: 0x04018047 RID: 98375
		Default,
		// Token: 0x04018048 RID: 98376
		FabricSurface,
		// Token: 0x04018049 RID: 98377
		SandSurface,
		// Token: 0x0401804A RID: 98378
		IceSurface,
		// Token: 0x0401804B RID: 98379
		EAudioPhysicalSurface_MAX
	}
}
