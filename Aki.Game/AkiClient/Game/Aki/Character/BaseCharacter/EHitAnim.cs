using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003313 RID: 13075
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EHitAnim.EHitAnim")]
	public enum EHitAnim : byte
	{
		// Token: 0x040120B9 RID: 73913
		轻左,
		// Token: 0x040120BA RID: 73914
		轻右,
		// Token: 0x040120BB RID: 73915
		重左,
		// Token: 0x040120BC RID: 73916
		重右,
		// Token: 0x040120BD RID: 73917
		击飞,
		// Token: 0x040120BE RID: 73918
		击倒,
		// Token: 0x040120BF RID: 73919
		压制,
		// Token: 0x040120C0 RID: 73920
		被弹反,
		// Token: 0x040120C1 RID: 73921
		轻前,
		// Token: 0x040120C2 RID: 73922
		轻后,
		// Token: 0x040120C3 RID: 73923
		重前,
		// Token: 0x040120C4 RID: 73924
		重后,
		// Token: 0x040120C5 RID: 73925
		被破弱,
		// Token: 0x040120C6 RID: 73926
		EHitAnim_MAX
	}
}
