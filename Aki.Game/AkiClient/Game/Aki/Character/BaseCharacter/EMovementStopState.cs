using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C3 RID: 17091
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMovementStopState.EMovementStopState")]
	public enum EMovementStopState : byte
	{
		// Token: 0x04017408 RID: 95240
		None,
		// Token: 0x04017409 RID: 95241
		SprintStop,
		// Token: 0x0401740A RID: 95242
		RunStop,
		// Token: 0x0401740B RID: 95243
		WalkStop,
		// Token: 0x0401740C RID: 95244
		EMovementStopState_MAX
	}
}
