using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C0 RID: 17088
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMovementAction.EMovementAction")]
	public enum EMovementAction : byte
	{
		// Token: 0x040173F1 RID: 95217
		None,
		// Token: 0x040173F2 RID: 95218
		LowClimb,
		// Token: 0x040173F3 RID: 95219
		HighClimb,
		// Token: 0x040173F4 RID: 95220
		Dodge,
		// Token: 0x040173F5 RID: 95221
		GettingUp,
		// Token: 0x040173F6 RID: 95222
		HeavyLand,
		// Token: 0x040173F7 RID: 95223
		EMovementAction_MAX
	}
}
