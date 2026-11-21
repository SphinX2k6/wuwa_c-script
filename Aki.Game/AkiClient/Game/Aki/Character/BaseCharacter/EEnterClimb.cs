using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330D RID: 13069
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EEnterClimb.EEnterClimb")]
	public enum EEnterClimb : byte
	{
		// Token: 0x0401208C RID: 73868
		空中进入,
		// Token: 0x0401208D RID: 73869
		水中进入,
		// Token: 0x0401208E RID: 73870
		地面上爬进入,
		// Token: 0x0401208F RID: 73871
		崖顶下爬进入,
		// Token: 0x04012090 RID: 73872
		技能进入,
		// Token: 0x04012091 RID: 73873
		EEnterClimb_MAX
	}
}
