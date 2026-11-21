using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003322 RID: 13090
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESelfCenteredMode.ESelfCenteredMode")]
	public enum ESelfCenteredMode : byte
	{
		// Token: 0x04012120 RID: 74016
		None,
		// Token: 0x04012121 RID: 74017
		Blueprint,
		// Token: 0x04012122 RID: 74018
		Gameplay,
		// Token: 0x04012123 RID: 74019
		LevelEvent,
		// Token: 0x04012124 RID: 74020
		GM,
		// Token: 0x04012125 RID: 74021
		Skill,
		// Token: 0x04012126 RID: 74022
		ESelfCenteredMode_MAX
	}
}
