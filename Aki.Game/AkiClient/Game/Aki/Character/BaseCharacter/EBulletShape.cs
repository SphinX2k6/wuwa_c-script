using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429A RID: 17050
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletShape.EBulletShape")]
	public enum EBulletShape : byte
	{
		// Token: 0x040172CE RID: 94926
		单位长方体,
		// Token: 0x040172CF RID: 94927
		单位球体,
		// Token: 0x040172D0 RID: 94928
		扇形柱,
		// Token: 0x040172D1 RID: 94929
		圆柱,
		// Token: 0x040172D2 RID: 94930
		激光,
		// Token: 0x040172D3 RID: 94931
		自定义模型,
		// Token: 0x040172D4 RID: 94932
		大长方体,
		// Token: 0x040172D5 RID: 94933
		大球体,
		// Token: 0x040172D6 RID: 94934
		大扇形柱,
		// Token: 0x040172D7 RID: 94935
		大圆柱,
		// Token: 0x040172D8 RID: 94936
		EBulletShape_MAX
	}
}
