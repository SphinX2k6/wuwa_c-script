using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042BC RID: 17084
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EHitAnim.EHitAnim")]
	public enum EHitAnim : byte
	{
		// Token: 0x040173D6 RID: 95190
		轻左,
		// Token: 0x040173D7 RID: 95191
		轻右,
		// Token: 0x040173D8 RID: 95192
		重左,
		// Token: 0x040173D9 RID: 95193
		重右,
		// Token: 0x040173DA RID: 95194
		击飞,
		// Token: 0x040173DB RID: 95195
		击倒,
		// Token: 0x040173DC RID: 95196
		压制,
		// Token: 0x040173DD RID: 95197
		被弹反,
		// Token: 0x040173DE RID: 95198
		轻前,
		// Token: 0x040173DF RID: 95199
		轻后,
		// Token: 0x040173E0 RID: 95200
		重前,
		// Token: 0x040173E1 RID: 95201
		重后,
		// Token: 0x040173E2 RID: 95202
		被破弱,
		// Token: 0x040173E3 RID: 95203
		EHitAnim_MAX
	}
}
