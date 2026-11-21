using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003261 RID: 12897
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletHitEffect.EBulletHitEffect")]
	public enum EBulletHitEffect : byte
	{
		// Token: 0x040115B6 RID: 71094
		时间销毁触发,
		// Token: 0x040115B7 RID: 71095
		子弹打断销毁触发,
		// Token: 0x040115B8 RID: 71096
		碰撞障碍物触发,
		// Token: 0x040115B9 RID: 71097
		碰撞水体触发,
		// Token: 0x040115BA RID: 71098
		碰撞单位触发,
		// Token: 0x040115BB RID: 71099
		碰撞障碍物销毁触发,
		// Token: 0x040115BC RID: 71100
		碰撞单位销毁触发,
		// Token: 0x040115BD RID: 71101
		触发弱点打击特效,
		// Token: 0x040115BE RID: 71102
		次数不足时触发,
		// Token: 0x040115BF RID: 71103
		碰撞无敌单位触发,
		// Token: 0x040115C0 RID: 71104
		触发极限闪避,
		// Token: 0x040115C1 RID: 71105
		命中处插箭,
		// Token: 0x040115C2 RID: 71106
		特殊命中特效,
		// Token: 0x040115C3 RID: 71107
		EBulletHitEffect_MAX
	}
}
