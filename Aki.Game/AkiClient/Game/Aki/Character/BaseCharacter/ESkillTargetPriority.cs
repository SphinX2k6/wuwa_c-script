using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E0 RID: 17120
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillTargetPriority.ESkillTargetPriority")]
	public enum ESkillTargetPriority : byte
	{
		// Token: 0x040174E4 RID: 95460
		摇杆方向优先,
		// Token: 0x040174E5 RID: 95461
		角色方向优先,
		// Token: 0x040174E6 RID: 95462
		锁定目标优先,
		// Token: 0x040174E7 RID: 95463
		距离优先,
		// Token: 0x040174E8 RID: 95464
		镜头方向优先,
		// Token: 0x040174E9 RID: 95465
		摇杆方向优先_精准模式_,
		// Token: 0x040174EA RID: 95466
		镜头方向优先_精准模式_,
		// Token: 0x040174EB RID: 95467
		角色方向优先_精准模式_,
		// Token: 0x040174EC RID: 95468
		系统设置,
		// Token: 0x040174ED RID: 95469
		ESkillTargetPriority_MAX
	}
}
