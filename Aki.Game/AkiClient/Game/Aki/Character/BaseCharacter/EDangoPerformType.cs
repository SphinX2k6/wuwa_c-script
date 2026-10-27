using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B2 RID: 17074
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoPerformType.EDangoPerformType")]
	public enum EDangoPerformType : byte
	{
		// Token: 0x0401738E RID: 95118
		默认,
		// Token: 0x0401738F RID: 95119
		改变高度,
		// Token: 0x04017390 RID: 95120
		欢呼,
		// Token: 0x04017391 RID: 95121
		比赛胜利,
		// Token: 0x04017392 RID: 95122
		单人欢呼,
		// Token: 0x04017393 RID: 95123
		改变顺序,
		// Token: 0x04017394 RID: 95124
		EDangoPerformType_MAX
	}
}
