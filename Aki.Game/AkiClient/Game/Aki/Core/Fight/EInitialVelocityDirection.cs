using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326A RID: 12906
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EInitialVelocityDirection.EInitialVelocityDirection")]
	public enum EInitialVelocityDirection : byte
	{
		// Token: 0x04011611 RID: 71185
		默认,
		// Token: 0x04011612 RID: 71186
		面向目标,
		// Token: 0x04011613 RID: 71187
		面向发射者,
		// Token: 0x04011614 RID: 71188
		父子弹方向,
		// Token: 0x04011615 RID: 71189
		跟随骨骼默认朝向,
		// Token: 0x04011616 RID: 71190
		面向发射者锁定目标,
		// Token: 0x04011617 RID: 71191
		面向自定义目标,
		// Token: 0x04011618 RID: 71192
		队伍角色,
		// Token: 0x04011619 RID: 71193
		父子弹受击者,
		// Token: 0x0401161A RID: 71194
		父子弹目标,
		// Token: 0x0401161B RID: 71195
		前台角色锁定目标,
		// Token: 0x0401161C RID: 71196
		伴生物,
		// Token: 0x0401161D RID: 71197
		伴生物朝向,
		// Token: 0x0401161E RID: 71198
		世界旋转,
		// Token: 0x0401161F RID: 71199
		跟随技能目标旋转,
		// Token: 0x04011620 RID: 71200
		面向父子弹位置,
		// Token: 0x04011621 RID: 71201
		EInitialVelocityDirection_MAX
	}
}
