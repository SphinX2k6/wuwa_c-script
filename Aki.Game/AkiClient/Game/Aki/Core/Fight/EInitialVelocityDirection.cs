using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004006 RID: 16390
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EInitialVelocityDirection.EInitialVelocityDirection")]
	public enum EInitialVelocityDirection : byte
	{
		// Token: 0x040159B0 RID: 88496
		默认,
		// Token: 0x040159B1 RID: 88497
		面向目标,
		// Token: 0x040159B2 RID: 88498
		面向发射者,
		// Token: 0x040159B3 RID: 88499
		父子弹方向,
		// Token: 0x040159B4 RID: 88500
		跟随骨骼默认朝向,
		// Token: 0x040159B5 RID: 88501
		面向发射者锁定目标,
		// Token: 0x040159B6 RID: 88502
		面向自定义目标,
		// Token: 0x040159B7 RID: 88503
		队伍角色,
		// Token: 0x040159B8 RID: 88504
		父子弹受击者,
		// Token: 0x040159B9 RID: 88505
		父子弹目标,
		// Token: 0x040159BA RID: 88506
		前台角色锁定目标,
		// Token: 0x040159BB RID: 88507
		伴生物,
		// Token: 0x040159BC RID: 88508
		伴生物朝向,
		// Token: 0x040159BD RID: 88509
		世界旋转,
		// Token: 0x040159BE RID: 88510
		跟随技能目标旋转,
		// Token: 0x040159BF RID: 88511
		面向父子弹位置,
		// Token: 0x040159C0 RID: 88512
		EInitialVelocityDirection_MAX
	}
}
