using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003331 RID: 13105
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillTargetPriority.ESkillTargetPriority")]
	public enum ESkillTargetPriority : byte
	{
		// Token: 0x040121A1 RID: 74145
		摇杆方向优先,
		// Token: 0x040121A2 RID: 74146
		角色方向优先,
		// Token: 0x040121A3 RID: 74147
		锁定目标优先,
		// Token: 0x040121A4 RID: 74148
		距离优先,
		// Token: 0x040121A5 RID: 74149
		镜头方向优先,
		// Token: 0x040121A6 RID: 74150
		摇杆方向优先_精准模式_,
		// Token: 0x040121A7 RID: 74151
		镜头方向优先_精准模式_,
		// Token: 0x040121A8 RID: 74152
		角色方向优先_精准模式_,
		// Token: 0x040121A9 RID: 74153
		系统设置,
		// Token: 0x040121AA RID: 74154
		ESkillTargetPriority_MAX
	}
}
