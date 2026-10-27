using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B5 RID: 17077
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EExitClimb.EExitClimb")]
	public enum EExitClimb : byte
	{
		// Token: 0x040173A2 RID: 95138
		跳下退出,
		// Token: 0x040173A3 RID: 95139
		入水退出,
		// Token: 0x040173A4 RID: 95140
		到顶退出,
		// Token: 0x040173A5 RID: 95141
		到底退出,
		// Token: 0x040173A6 RID: 95142
		蹬墙退出,
		// Token: 0x040173A7 RID: 95143
		未知方式,
		// Token: 0x040173A8 RID: 95144
		跑墙退出,
		// Token: 0x040173A9 RID: 95145
		地面登上,
		// Token: 0x040173AA RID: 95146
		冲刺跨越远,
		// Token: 0x040173AB RID: 95147
		冲刺跨越近,
		// Token: 0x040173AC RID: 95148
		反斜登顶,
		// Token: 0x040173AD RID: 95149
		EExitClimb_MAX
	}
}
