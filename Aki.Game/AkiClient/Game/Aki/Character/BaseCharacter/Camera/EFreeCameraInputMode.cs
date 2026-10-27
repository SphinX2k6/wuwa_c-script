using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BC RID: 17340
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFreeCameraInputMode.EFreeCameraInputMode")]
	public enum EFreeCameraInputMode : byte
	{
		// Token: 0x04017C6C RID: 97388
		禁止,
		// Token: 0x04017C6D RID: 97389
		拖动,
		// Token: 0x04017C6E RID: 97390
		EFreeCameraInputMode_MAX
	}
}
