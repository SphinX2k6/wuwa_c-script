using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D6 RID: 17110
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorRotationType.ESkillBehaviorRotationType")]
	public enum ESkillBehaviorRotationType : byte
	{
		// Token: 0x04017492 RID: 95378
		技能目标,
		// Token: 0x04017493 RID: 95379
		小队当前角色,
		// Token: 0x04017494 RID: 95380
		召唤者_伴生物专用_,
		// Token: 0x04017495 RID: 95381
		当前小队摄像机_玩家专用_,
		// Token: 0x04017496 RID: 95382
		技能目标玩家摄像机_怪物专用_,
		// Token: 0x04017497 RID: 95383
		技能施法者朝向,
		// Token: 0x04017498 RID: 95384
		输入朝向_玩家专用_,
		// Token: 0x04017499 RID: 95385
		ESkillBehaviorRotationType_MAX
	}
}
