using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C1 RID: 17345
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ESequenceCameraSpecificType.ESequenceCameraSpecificType")]
	public enum ESequenceCameraSpecificType : byte
	{
		// Token: 0x04017C9D RID: 97437
		无,
		// Token: 0x04017C9E RID: 97438
		梦境链接,
		// Token: 0x04017C9F RID: 97439
		ESequenceCameraSpecificType_MAX
	}
}
