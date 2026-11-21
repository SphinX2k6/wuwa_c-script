using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200325B RID: 12891
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletBeginVelocityLimit.EBulletBeginVelocityLimit")]
	public enum EBulletBeginVelocityLimit : byte
	{
		// Token: 0x04011592 RID: 71058
		上角度范围,
		// Token: 0x04011593 RID: 71059
		下角度范围,
		// Token: 0x04011594 RID: 71060
		左角度范围,
		// Token: 0x04011595 RID: 71061
		右下角度范围,
		// Token: 0x04011596 RID: 71062
		EBulletBeginVelocityLimit_MAX
	}
}
