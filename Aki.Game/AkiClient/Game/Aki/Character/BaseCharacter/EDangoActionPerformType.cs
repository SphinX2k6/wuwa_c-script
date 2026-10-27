using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AF RID: 17071
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoActionPerformType.EDangoActionPerformType")]
	public enum EDangoActionPerformType : byte
	{
		// Token: 0x0401737D RID: 95101
		原地跳跃,
		// Token: 0x0401737E RID: 95102
		比赛胜利,
		// Token: 0x0401737F RID: 95103
		欢呼,
		// Token: 0x04017380 RID: 95104
		成功,
		// Token: 0x04017381 RID: 95105
		失败,
		// Token: 0x04017382 RID: 95106
		原地欢呼,
		// Token: 0x04017383 RID: 95107
		EDangoActionPerformType_MAX
	}
}
