using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003260 RID: 12896
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletEffectParam.EBulletEffectParam")]
	public enum EBulletEffectParam : byte
	{
		// Token: 0x040115AD RID: 71085
		无,
		// Token: 0x040115AE RID: 71086
		激光子弹特效原长度,
		// Token: 0x040115AF RID: 71087
		相对位置,
		// Token: 0x040115B0 RID: 71088
		相对旋转,
		// Token: 0x040115B1 RID: 71089
		缩放,
		// Token: 0x040115B2 RID: 71090
		特效质量,
		// Token: 0x040115B3 RID: 71091
		移动端子弹特效DA,
		// Token: 0x040115B4 RID: 71092
		EBulletEffectParam_MAX
	}
}
