using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FFC RID: 16380
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletHitEffect.EBulletHitEffect")]
	public enum EBulletHitEffect : byte
	{
		// Token: 0x04015952 RID: 88402
		时间销毁触发,
		// Token: 0x04015953 RID: 88403
		子弹打断销毁触发,
		// Token: 0x04015954 RID: 88404
		碰撞障碍物触发,
		// Token: 0x04015955 RID: 88405
		碰撞水体触发,
		// Token: 0x04015956 RID: 88406
		碰撞单位触发,
		// Token: 0x04015957 RID: 88407
		碰撞障碍物销毁触发,
		// Token: 0x04015958 RID: 88408
		碰撞单位销毁触发,
		// Token: 0x04015959 RID: 88409
		触发弱点打击特效,
		// Token: 0x0401595A RID: 88410
		次数不足时触发,
		// Token: 0x0401595B RID: 88411
		碰撞无敌单位触发,
		// Token: 0x0401595C RID: 88412
		触发极限闪避,
		// Token: 0x0401595D RID: 88413
		命中处插箭,
		// Token: 0x0401595E RID: 88414
		特殊命中特效,
		// Token: 0x0401595F RID: 88415
		EBulletHitEffect_MAX
	}
}
