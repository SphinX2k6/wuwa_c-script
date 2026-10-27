using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C1 RID: 17089
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EMovementProcessDirection.EMovementProcessDirection")]
	public enum EMovementProcessDirection : byte
	{
		// Token: 0x040173F9 RID: 95225
		None,
		// Token: 0x040173FA RID: 95226
		AlongTrack,
		// Token: 0x040173FB RID: 95227
		TowardsTarget,
		// Token: 0x040173FC RID: 95228
		EMovementProcessDirection_MAX
	}
}
