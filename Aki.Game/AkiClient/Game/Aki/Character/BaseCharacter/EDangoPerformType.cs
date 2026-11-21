using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330B RID: 13067
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoPerformType.EDangoPerformType")]
	public enum EDangoPerformType : byte
	{
		// Token: 0x0401207F RID: 73855
		默认,
		// Token: 0x04012080 RID: 73856
		改变高度,
		// Token: 0x04012081 RID: 73857
		欢呼,
		// Token: 0x04012082 RID: 73858
		比赛胜利,
		// Token: 0x04012083 RID: 73859
		单人欢呼,
		// Token: 0x04012084 RID: 73860
		改变顺序,
		// Token: 0x04012085 RID: 73861
		EDangoPerformType_MAX
	}
}
