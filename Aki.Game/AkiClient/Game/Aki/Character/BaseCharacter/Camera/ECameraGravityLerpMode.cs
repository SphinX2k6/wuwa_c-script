using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C2 RID: 13250
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ECameraGravityLerpMode.ECameraGravityLerpMode")]
	public enum ECameraGravityLerpMode : byte
	{
		// Token: 0x0401264A RID: 75338
		None,
		// Token: 0x0401264B RID: 75339
		Time,
		// Token: 0x0401264C RID: 75340
		AngleVelocity,
		// Token: 0x0401264D RID: 75341
		ECameraGravityLerpMode_MAX
	}
}
