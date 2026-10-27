using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.Cipher
{
	// Token: 0x02003E6B RID: 15979
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/Cipher/ECipherGameplayType.ECipherGameplayType")]
	public enum ECipherGameplayType : byte
	{
		// Token: 0x040147A2 RID: 83874
		数字,
		// Token: 0x040147A3 RID: 83875
		文字,
		// Token: 0x040147A4 RID: 83876
		图片,
		// Token: 0x040147A5 RID: 83877
		ECipherGameplayType_MAX
	}
}
