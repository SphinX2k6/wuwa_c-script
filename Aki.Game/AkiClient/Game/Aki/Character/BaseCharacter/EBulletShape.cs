using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F6 RID: 13046
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletShape.EBulletShape")]
	public enum EBulletShape : byte
	{
		// Token: 0x04011FD0 RID: 73680
		单位长方体,
		// Token: 0x04011FD1 RID: 73681
		单位球体,
		// Token: 0x04011FD2 RID: 73682
		扇形柱,
		// Token: 0x04011FD3 RID: 73683
		圆柱,
		// Token: 0x04011FD4 RID: 73684
		激光,
		// Token: 0x04011FD5 RID: 73685
		自定义模型,
		// Token: 0x04011FD6 RID: 73686
		大长方体,
		// Token: 0x04011FD7 RID: 73687
		大球体,
		// Token: 0x04011FD8 RID: 73688
		大扇形柱,
		// Token: 0x04011FD9 RID: 73689
		大圆柱,
		// Token: 0x04011FDA RID: 73690
		EBulletShape_MAX
	}
}
