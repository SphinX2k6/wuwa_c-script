using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B4 RID: 17076
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EEnterClimb.EEnterClimb")]
	public enum EEnterClimb : byte
	{
		// Token: 0x0401739B RID: 95131
		空中进入,
		// Token: 0x0401739C RID: 95132
		水中进入,
		// Token: 0x0401739D RID: 95133
		地面上爬进入,
		// Token: 0x0401739E RID: 95134
		崖顶下爬进入,
		// Token: 0x0401739F RID: 95135
		技能进入,
		// Token: 0x040173A0 RID: 95136
		EEnterClimb_MAX
	}
}
