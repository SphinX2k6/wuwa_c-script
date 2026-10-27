using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FFB RID: 16379
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletEffectParam.EBulletEffectParam")]
	public enum EBulletEffectParam : byte
	{
		// Token: 0x0401594A RID: 88394
		无,
		// Token: 0x0401594B RID: 88395
		激光子弹特效原长度,
		// Token: 0x0401594C RID: 88396
		相对位置,
		// Token: 0x0401594D RID: 88397
		相对旋转,
		// Token: 0x0401594E RID: 88398
		缩放,
		// Token: 0x0401594F RID: 88399
		特效质量,
		// Token: 0x04015950 RID: 88400
		EBulletEffectParam_MAX
	}
}
