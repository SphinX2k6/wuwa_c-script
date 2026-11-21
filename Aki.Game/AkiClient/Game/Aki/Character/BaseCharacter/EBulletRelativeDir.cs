using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F5 RID: 13045
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBulletRelativeDir.EBulletRelativeDir")]
	public enum EBulletRelativeDir : byte
	{
		// Token: 0x04011FC9 RID: 73673
		发射者,
		// Token: 0x04011FCA RID: 73674
		子弹中心,
		// Token: 0x04011FCB RID: 73675
		子弹方向,
		// Token: 0x04011FCC RID: 73676
		无影响,
		// Token: 0x04011FCD RID: 73677
		子弹中心相对位置,
		// Token: 0x04011FCE RID: 73678
		EBulletRelativeDir_MAX
	}
}
