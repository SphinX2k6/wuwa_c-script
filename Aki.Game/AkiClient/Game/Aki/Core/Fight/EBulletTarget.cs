using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003265 RID: 12901
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletTarget.EBulletTarget")]
	public enum EBulletTarget : byte
	{
		// Token: 0x040115D4 RID: 71124
		空,
		// Token: 0x040115D5 RID: 71125
		队伍角色,
		// Token: 0x040115D6 RID: 71126
		技能目标,
		// Token: 0x040115D7 RID: 71127
		攻击者锁定目标动态,
		// Token: 0x040115D8 RID: 71128
		攻击者锁定目标静态,
		// Token: 0x040115D9 RID: 71129
		自定义目标,
		// Token: 0x040115DA RID: 71130
		子弹发射者,
		// Token: 0x040115DB RID: 71131
		父子弹受击者,
		// Token: 0x040115DC RID: 71132
		父子弹目标,
		// Token: 0x040115DD RID: 71133
		前台角色锁定目标,
		// Token: 0x040115DE RID: 71134
		外部传入坐标,
		// Token: 0x040115DF RID: 71135
		技能目标前台,
		// Token: 0x040115E0 RID: 71136
		父子弹位置,
		// Token: 0x040115E1 RID: 71137
		EBulletTarget_MAX
	}
}
