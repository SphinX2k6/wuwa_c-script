using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033BF RID: 13247
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EBaseCurveType.EBaseCurveType")]
	public enum EBaseCurveType : byte
	{
		// Token: 0x04012610 RID: 75280
		线性,
		// Token: 0x04012611 RID: 75281
		二阶_凹函数,
		// Token: 0x04012612 RID: 75282
		二阶_凸函数,
		// Token: 0x04012613 RID: 75283
		三阶_凹函数,
		// Token: 0x04012614 RID: 75284
		三阶_凸函数,
		// Token: 0x04012615 RID: 75285
		三阶_S函数,
		// Token: 0x04012616 RID: 75286
		三阶_反S函数,
		// Token: 0x04012617 RID: 75287
		幂函数_凹函数,
		// Token: 0x04012618 RID: 75288
		幂函数_凸函数,
		// Token: 0x04012619 RID: 75289
		幂函数_S函数,
		// Token: 0x0401261A RID: 75290
		幂函数_反S函数,
		// Token: 0x0401261B RID: 75291
		幂函数_抛物线,
		// Token: 0x0401261C RID: 75292
		缓入缓出,
		// Token: 0x0401261D RID: 75293
		缓入急出,
		// Token: 0x0401261E RID: 75294
		急入缓出,
		// Token: 0x0401261F RID: 75295
		急入急出,
		// Token: 0x04012620 RID: 75296
		资产曲线,
		// Token: 0x04012621 RID: 75297
		EBaseCurveType_MAX
	}
}
