using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CD RID: 17101
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESelfCenteredMode.ESelfCenteredMode")]
	public enum ESelfCenteredMode : byte
	{
		// Token: 0x04017443 RID: 95299
		None,
		// Token: 0x04017444 RID: 95300
		Blueprint,
		// Token: 0x04017445 RID: 95301
		Gameplay,
		// Token: 0x04017446 RID: 95302
		LevelEvent,
		// Token: 0x04017447 RID: 95303
		GM,
		// Token: 0x04017448 RID: 95304
		Skill,
		// Token: 0x04017449 RID: 95305
		ESelfCenteredMode_MAX
	}
}
