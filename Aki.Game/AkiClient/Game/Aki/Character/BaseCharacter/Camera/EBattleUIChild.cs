using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C0 RID: 13248
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EBattleUIChild.EBattleUIChild")]
	public enum EBattleUIChild : byte
	{
		// Token: 0x04012623 RID: 75299
		通用,
		// Token: 0x04012624 RID: 75300
		退出按钮,
		// Token: 0x04012625 RID: 75301
		菜单按钮,
		// Token: 0x04012626 RID: 75302
		顶部其他按钮,
		// Token: 0x04012627 RID: 75303
		小地图,
		// Token: 0x04012628 RID: 75304
		任务,
		// Token: 0x04012629 RID: 75305
		聊天按钮,
		// Token: 0x0401262A RID: 75306
		队伍头像,
		// Token: 0x0401262B RID: 75307
		队伍头像手柄,
		// Token: 0x0401262C RID: 75308
		技能按钮,
		// Token: 0x0401262D RID: 75309
		技能按钮手柄,
		// Token: 0x0401262E RID: 75310
		角色状态条,
		// Token: 0x0401262F RID: 75311
		摇杆,
		// Token: 0x04012630 RID: 75312
		boss状态条,
		// Token: 0x04012631 RID: 75313
		头顶状态条,
		// Token: 0x04012632 RID: 75314
		部位血条,
		// Token: 0x04012633 RID: 75315
		伤害数字,
		// Token: 0x04012634 RID: 75316
		战斗hud层,
		// Token: 0x04012635 RID: 75317
		战斗Float层,
		// Token: 0x04012636 RID: 75318
		交互,
		// Token: 0x04012637 RID: 75319
		QTE按键,
		// Token: 0x04012638 RID: 75320
		EBattleUIChild_MAX
	}
}
