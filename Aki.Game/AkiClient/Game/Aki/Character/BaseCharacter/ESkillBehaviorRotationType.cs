using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332B RID: 13099
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorRotationType.ESkillBehaviorRotationType")]
	public enum ESkillBehaviorRotationType : byte
	{
		// Token: 0x0401216F RID: 74095
		技能目标,
		// Token: 0x04012170 RID: 74096
		小队当前角色,
		// Token: 0x04012171 RID: 74097
		召唤者_伴生物专用_,
		// Token: 0x04012172 RID: 74098
		当前小队摄像机_玩家专用_,
		// Token: 0x04012173 RID: 74099
		技能目标玩家摄像机_怪物专用_,
		// Token: 0x04012174 RID: 74100
		技能施法者朝向,
		// Token: 0x04012175 RID: 74101
		输入朝向_玩家专用_,
		// Token: 0x04012176 RID: 74102
		ESkillBehaviorRotationType_MAX
	}
}
