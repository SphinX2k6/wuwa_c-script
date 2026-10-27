using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004008 RID: 16392
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EPositionStandard.EPositionStandard")]
	public enum EPositionStandard : byte
	{
		// Token: 0x040159CB RID: 88523
		发射者位置,
		// Token: 0x040159CC RID: 88524
		技能目标位置,
		// Token: 0x040159CD RID: 88525
		世界位置,
		// Token: 0x040159CE RID: 88526
		父子弹或外部位置,
		// Token: 0x040159CF RID: 88527
		攻击者锁定目标位置,
		// Token: 0x040159D0 RID: 88528
		自定义目标,
		// Token: 0x040159D1 RID: 88529
		队伍角色,
		// Token: 0x040159D2 RID: 88530
		父子弹受击者,
		// Token: 0x040159D3 RID: 88531
		父子弹目标,
		// Token: 0x040159D4 RID: 88532
		前台角色锁定目标,
		// Token: 0x040159D5 RID: 88533
		伴生物,
		// Token: 0x040159D6 RID: 88534
		伴生物位置和朝向,
		// Token: 0x040159D7 RID: 88535
		技能目标位置和朝向,
		// Token: 0x040159D8 RID: 88536
		EPositionStandard_MAX
	}
}
