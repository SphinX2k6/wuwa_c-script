using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C2 RID: 17090
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMovementState.EMovementState")]
	public enum EMovementState : byte
	{
		// Token: 0x040173FE RID: 95230
		None,
		// Token: 0x040173FF RID: 95231
		Grounded,
		// Token: 0x04017400 RID: 95232
		InAir,
		// Token: 0x04017401 RID: 95233
		Ragdoll,
		// Token: 0x04017402 RID: 95234
		Mantling,
		// Token: 0x04017403 RID: 95235
		InWater,
		// Token: 0x04017404 RID: 95236
		Climbing,
		// Token: 0x04017405 RID: 95237
		Flying,
		// Token: 0x04017406 RID: 95238
		EMovementState_MAX
	}
}
