using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200180F RID: 6159
	[EnumExtensions]
	public enum ESetBattleTagType
	{
		// Token: 0x04005193 RID: 20883
		[EnumStringMember("怪物.common.关卡.通信专用.幻象落地开启")]
		BattleMonsterLanding,
		// Token: 0x04005194 RID: 20884
		[EnumStringMember("怪物.common.关卡.通信专用.唤醒者")]
		BattleFinalMonsterLanding,
		// Token: 0x04005195 RID: 20885
		[EnumStringMember("怪物.common.关卡.睡觉")]
		BattleMonsterSleep
	}
}
