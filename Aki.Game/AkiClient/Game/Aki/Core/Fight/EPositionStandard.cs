using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326C RID: 12908
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EPositionStandard.EPositionStandard")]
	public enum EPositionStandard : byte
	{
		// Token: 0x0401162C RID: 71212
		发射者位置,
		// Token: 0x0401162D RID: 71213
		技能目标位置,
		// Token: 0x0401162E RID: 71214
		世界位置,
		// Token: 0x0401162F RID: 71215
		父子弹或外部位置,
		// Token: 0x04011630 RID: 71216
		攻击者锁定目标位置,
		// Token: 0x04011631 RID: 71217
		自定义目标,
		// Token: 0x04011632 RID: 71218
		队伍角色,
		// Token: 0x04011633 RID: 71219
		父子弹受击者,
		// Token: 0x04011634 RID: 71220
		父子弹目标,
		// Token: 0x04011635 RID: 71221
		前台角色锁定目标,
		// Token: 0x04011636 RID: 71222
		伴生物,
		// Token: 0x04011637 RID: 71223
		伴生物位置和朝向,
		// Token: 0x04011638 RID: 71224
		技能目标位置和朝向,
		// Token: 0x04011639 RID: 71225
		EPositionStandard_MAX
	}
}
