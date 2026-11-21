using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331A RID: 13082
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMovementProcessDirection.EMovementProcessDirection")]
	public enum EMovementProcessDirection : byte
	{
		// Token: 0x040120EF RID: 73967
		None,
		// Token: 0x040120F0 RID: 73968
		AlongTrack,
		// Token: 0x040120F1 RID: 73969
		TowardsTarget,
		// Token: 0x040120F2 RID: 73970
		EMovementProcessDirection_MAX
	}
}
