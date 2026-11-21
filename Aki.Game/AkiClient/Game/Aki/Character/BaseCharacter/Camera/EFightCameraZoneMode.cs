using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D7 RID: 13271
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraZoneMode.EFightCameraZoneMode")]
	public enum EFightCameraZoneMode : byte
	{
		// Token: 0x040127D0 RID: 75728
		None,
		// Token: 0x040127D1 RID: 75729
		Soar,
		// Token: 0x040127D2 RID: 75730
		Vehicle,
		// Token: 0x040127D3 RID: 75731
		Motor,
		// Token: 0x040127D4 RID: 75732
		Horizontal,
		// Token: 0x040127D5 RID: 75733
		Character,
		// Token: 0x040127D6 RID: 75734
		Flower,
		// Token: 0x040127D7 RID: 75735
		EFightCameraZoneMode_MAX
	}
}
