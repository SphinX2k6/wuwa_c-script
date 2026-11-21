using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330E RID: 13070
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EExitClimb.EExitClimb")]
	public enum EExitClimb : byte
	{
		// Token: 0x04012093 RID: 73875
		跳下退出,
		// Token: 0x04012094 RID: 73876
		入水退出,
		// Token: 0x04012095 RID: 73877
		到顶退出,
		// Token: 0x04012096 RID: 73878
		到底退出,
		// Token: 0x04012097 RID: 73879
		蹬墙退出,
		// Token: 0x04012098 RID: 73880
		未知方式,
		// Token: 0x04012099 RID: 73881
		跑墙退出,
		// Token: 0x0401209A RID: 73882
		地面登上,
		// Token: 0x0401209B RID: 73883
		冲刺跨越远,
		// Token: 0x0401209C RID: 73884
		冲刺跨越近,
		// Token: 0x0401209D RID: 73885
		反斜登顶,
		// Token: 0x0401209E RID: 73886
		EExitClimb_MAX
	}
}
