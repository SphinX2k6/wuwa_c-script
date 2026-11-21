using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DC RID: 13276
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ESequenceCameraSpecificType.ESequenceCameraSpecificType")]
	public enum ESequenceCameraSpecificType : byte
	{
		// Token: 0x04012805 RID: 75781
		无,
		// Token: 0x04012806 RID: 75782
		梦境链接,
		// Token: 0x04012807 RID: 75783
		ESequenceCameraSpecificType_MAX
	}
}
