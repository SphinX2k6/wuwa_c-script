using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003308 RID: 13064
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoActionPerformType.EDangoActionPerformType")]
	public enum EDangoActionPerformType : byte
	{
		// Token: 0x0401206E RID: 73838
		原地跳跃,
		// Token: 0x0401206F RID: 73839
		比赛胜利,
		// Token: 0x04012070 RID: 73840
		欢呼,
		// Token: 0x04012071 RID: 73841
		成功,
		// Token: 0x04012072 RID: 73842
		失败,
		// Token: 0x04012073 RID: 73843
		原地欢呼,
		// Token: 0x04012074 RID: 73844
		EDangoActionPerformType_MAX
	}
}
