using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A2 RID: 17058
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharState.ECharState")]
	public enum ECharState : byte
	{
		// Token: 0x0401730F RID: 94991
		其他,
		// Token: 0x04017310 RID: 94992
		站立,
		// Token: 0x04017311 RID: 94993
		行走,
		// Token: 0x04017312 RID: 94994
		行走停止,
		// Token: 0x04017313 RID: 94995
		跑步,
		// Token: 0x04017314 RID: 94996
		跑步停止,
		// Token: 0x04017315 RID: 94997
		冲刺,
		// Token: 0x04017316 RID: 94998
		冲刺停止,
		// Token: 0x04017317 RID: 94999
		闪避,
		// Token: 0x04017318 RID: 95000
		弹反,
		// Token: 0x04017319 RID: 95001
		落地翻滚,
		// Token: 0x0401731A RID: 95002
		击倒,
		// Token: 0x0401731B RID: 95003
		轻击,
		// Token: 0x0401731C RID: 95004
		重击,
		// Token: 0x0401731D RID: 95005
		正常攀爬,
		// Token: 0x0401731E RID: 95006
		快速攀爬,
		// Token: 0x0401731F RID: 95007
		滑翔,
		// Token: 0x04017320 RID: 95008
		击飞,
		// Token: 0x04017321 RID: 95009
		加速游泳,
		// Token: 0x04017322 RID: 95010
		正常游泳,
		// Token: 0x04017323 RID: 95011
		摇荡,
		// Token: 0x04017324 RID: 95012
		被抓取,
		// Token: 0x04017325 RID: 95013
		滑坡,
		// Token: 0x04017326 RID: 95014
		特殊飞行,
		// Token: 0x04017327 RID: 95015
		进入攀爬,
		// Token: 0x04017328 RID: 95016
		退出攀爬,
		// Token: 0x04017329 RID: 95017
		普通滑雪,
		// Token: 0x0401732A RID: 95018
		受击倒地起身,
		// Token: 0x0401732B RID: 95019
		翱翔,
		// Token: 0x0401732C RID: 95020
		ECharState_MAX
	}
}
