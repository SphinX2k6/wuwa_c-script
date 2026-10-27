using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF5 RID: 16373
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletBeginVelocityLimit.EBulletBeginVelocityLimit")]
	public enum EBulletBeginVelocityLimit : byte
	{
		// Token: 0x0401592A RID: 88362
		上角度范围,
		// Token: 0x0401592B RID: 88363
		下角度范围,
		// Token: 0x0401592C RID: 88364
		左角度范围,
		// Token: 0x0401592D RID: 88365
		右下角度范围,
		// Token: 0x0401592E RID: 88366
		EBulletBeginVelocityLimit_MAX
	}
}
