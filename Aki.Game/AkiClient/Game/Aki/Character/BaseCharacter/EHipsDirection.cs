using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042BB RID: 17083
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EHipsDirection.EHipsDirection")]
	public enum EHipsDirection : byte
	{
		// Token: 0x040173CE RID: 95182
		前,
		// Token: 0x040173CF RID: 95183
		后,
		// Token: 0x040173D0 RID: 95184
		左前,
		// Token: 0x040173D1 RID: 95185
		左后,
		// Token: 0x040173D2 RID: 95186
		右前,
		// Token: 0x040173D3 RID: 95187
		右后,
		// Token: 0x040173D4 RID: 95188
		EHipsDirection_MAX
	}
}
