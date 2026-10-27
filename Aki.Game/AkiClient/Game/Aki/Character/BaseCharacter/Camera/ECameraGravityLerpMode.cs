using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A4 RID: 17316
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraGravityLerpMode.ECameraGravityLerpMode")]
	public enum ECameraGravityLerpMode : byte
	{
		// Token: 0x04017AD8 RID: 96984
		None,
		// Token: 0x04017AD9 RID: 96985
		Time,
		// Token: 0x04017ADA RID: 96986
		AngleVelocity,
		// Token: 0x04017ADB RID: 96987
		ECameraGravityLerpMode_MAX
	}
}
