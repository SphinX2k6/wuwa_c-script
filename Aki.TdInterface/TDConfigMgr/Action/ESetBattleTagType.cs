using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001696 RID: 5782
	[EnumExtensions]
	public enum ESetBattleTagType
	{
		// Token: 0x04004D7C RID: 19836
		[EnumStringMember("怪物.common.关卡.通信专用.幻象落地开启")]
		BattleMonsterLanding,
		// Token: 0x04004D7D RID: 19837
		[EnumStringMember("怪物.common.关卡.通信专用.唤醒者")]
		BattleFinalMonsterLanding,
		// Token: 0x04004D7E RID: 19838
		[EnumStringMember("怪物.common.关卡.睡觉")]
		BattleMonsterSleep
	}
}
