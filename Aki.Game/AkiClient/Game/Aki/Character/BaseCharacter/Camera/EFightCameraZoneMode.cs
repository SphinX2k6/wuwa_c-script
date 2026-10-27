using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BB RID: 17339
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraZoneMode.EFightCameraZoneMode")]
	public enum EFightCameraZoneMode : byte
	{
		// Token: 0x04017C65 RID: 97381
		None,
		// Token: 0x04017C66 RID: 97382
		Soar,
		// Token: 0x04017C67 RID: 97383
		Vehicle,
		// Token: 0x04017C68 RID: 97384
		Motor,
		// Token: 0x04017C69 RID: 97385
		Horizontal,
		// Token: 0x04017C6A RID: 97386
		EFightCameraZoneMode_MAX
	}
}
