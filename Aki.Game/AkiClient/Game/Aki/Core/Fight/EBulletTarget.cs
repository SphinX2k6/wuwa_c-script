using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004001 RID: 16385
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EBulletTarget.EBulletTarget")]
	public enum EBulletTarget : byte
	{
		// Token: 0x04015974 RID: 88436
		空,
		// Token: 0x04015975 RID: 88437
		队伍角色,
		// Token: 0x04015976 RID: 88438
		技能目标,
		// Token: 0x04015977 RID: 88439
		攻击者锁定目标动态,
		// Token: 0x04015978 RID: 88440
		攻击者锁定目标静态,
		// Token: 0x04015979 RID: 88441
		自定义目标,
		// Token: 0x0401597A RID: 88442
		子弹发射者,
		// Token: 0x0401597B RID: 88443
		父子弹受击者,
		// Token: 0x0401597C RID: 88444
		父子弹目标,
		// Token: 0x0401597D RID: 88445
		前台角色锁定目标,
		// Token: 0x0401597E RID: 88446
		外部传入坐标,
		// Token: 0x0401597F RID: 88447
		技能目标前台,
		// Token: 0x04015980 RID: 88448
		父子弹位置,
		// Token: 0x04015981 RID: 88449
		EBulletTarget_MAX
	}
}
