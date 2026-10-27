using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A5 RID: 17317
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraGravityMode.ECameraGravityMode")]
	public enum ECameraGravityMode : byte
	{
		// Token: 0x04017ADD RID: 96989
		None,
		// Token: 0x04017ADE RID: 96990
		FixedGravityDirect,
		// Token: 0x04017ADF RID: 96991
		CameraTargetGravityDirect,
		// Token: 0x04017AE0 RID: 96992
		ECameraGravityMode_MAX
	}
}
