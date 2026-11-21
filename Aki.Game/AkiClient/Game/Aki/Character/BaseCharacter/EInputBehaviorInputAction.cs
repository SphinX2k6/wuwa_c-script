using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003318 RID: 13080
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputBehaviorInputAction.EInputBehaviorInputAction")]
	public enum EInputBehaviorInputAction : byte
	{
		// Token: 0x040120DE RID: 73950
		攻击,
		// Token: 0x040120DF RID: 73951
		技能1,
		// Token: 0x040120E0 RID: 73952
		大招,
		// Token: 0x040120E1 RID: 73953
		幻象1,
		// Token: 0x040120E2 RID: 73954
		幻象2,
		// Token: 0x040120E3 RID: 73955
		闪避,
		// Token: 0x040120E4 RID: 73956
		跳跃,
		// Token: 0x040120E5 RID: 73957
		锁定目标,
		// Token: 0x040120E6 RID: 73958
		瞄准,
		// Token: 0x040120E7 RID: 73959
		下降,
		// Token: 0x040120E8 RID: 73960
		EInputBehaviorInputAction_MAX
	}
}
