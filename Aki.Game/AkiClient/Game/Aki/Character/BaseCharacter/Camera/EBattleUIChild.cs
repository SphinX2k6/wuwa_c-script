using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A2 RID: 17314
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EBattleUIChild.EBattleUIChild")]
	public enum EBattleUIChild : byte
	{
		// Token: 0x04017AB1 RID: 96945
		通用,
		// Token: 0x04017AB2 RID: 96946
		退出按钮,
		// Token: 0x04017AB3 RID: 96947
		菜单按钮,
		// Token: 0x04017AB4 RID: 96948
		顶部其他按钮,
		// Token: 0x04017AB5 RID: 96949
		小地图,
		// Token: 0x04017AB6 RID: 96950
		任务,
		// Token: 0x04017AB7 RID: 96951
		聊天按钮,
		// Token: 0x04017AB8 RID: 96952
		队伍头像,
		// Token: 0x04017AB9 RID: 96953
		队伍头像手柄,
		// Token: 0x04017ABA RID: 96954
		技能按钮,
		// Token: 0x04017ABB RID: 96955
		技能按钮手柄,
		// Token: 0x04017ABC RID: 96956
		角色状态条,
		// Token: 0x04017ABD RID: 96957
		摇杆,
		// Token: 0x04017ABE RID: 96958
		boss状态条,
		// Token: 0x04017ABF RID: 96959
		头顶状态条,
		// Token: 0x04017AC0 RID: 96960
		部位血条,
		// Token: 0x04017AC1 RID: 96961
		伤害数字,
		// Token: 0x04017AC2 RID: 96962
		战斗hud层,
		// Token: 0x04017AC3 RID: 96963
		战斗Float层,
		// Token: 0x04017AC4 RID: 96964
		交互,
		// Token: 0x04017AC5 RID: 96965
		QTE按键,
		// Token: 0x04017AC6 RID: 96966
		EBattleUIChild_MAX
	}
}
