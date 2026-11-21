using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C3 RID: 13251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraGravityMode.ECameraGravityMode")]
	public enum ECameraGravityMode : byte
	{
		// Token: 0x0401264F RID: 75343
		None,
		// Token: 0x04012650 RID: 75344
		FixedGravityDirect,
		// Token: 0x04012651 RID: 75345
		CameraTargetGravityDirect,
		// Token: 0x04012652 RID: 75346
		ECameraGravityMode_MAX
	}
}
