using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C4 RID: 17092
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Enum_PositionToTarget.Enum_PositionToTarget")]
	public enum Enum_PositionToTarget : byte
	{
		// Token: 0x0401740E RID: 95246
		技能目标,
		// Token: 0x0401740F RID: 95247
		召唤者,
		// Token: 0x04017410 RID: 95248
		Enum_MAX
	}
}
