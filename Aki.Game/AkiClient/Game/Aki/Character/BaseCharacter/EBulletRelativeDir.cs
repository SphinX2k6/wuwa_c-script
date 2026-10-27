using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004299 RID: 17049
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletRelativeDir.EBulletRelativeDir")]
	public enum EBulletRelativeDir : byte
	{
		// Token: 0x040172C7 RID: 94919
		发射者,
		// Token: 0x040172C8 RID: 94920
		子弹中心,
		// Token: 0x040172C9 RID: 94921
		子弹方向,
		// Token: 0x040172CA RID: 94922
		无影响,
		// Token: 0x040172CB RID: 94923
		子弹中心相对位置,
		// Token: 0x040172CC RID: 94924
		EBulletRelativeDir_MAX
	}
}
