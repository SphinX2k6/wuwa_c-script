using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D8 RID: 13272
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFreeCameraInputMode.EFreeCameraInputMode")]
	public enum EFreeCameraInputMode : byte
	{
		// Token: 0x040127D9 RID: 75737
		禁止,
		// Token: 0x040127DA RID: 75738
		拖动,
		// Token: 0x040127DB RID: 75739
		EFreeCameraInputMode_MAX
	}
}
