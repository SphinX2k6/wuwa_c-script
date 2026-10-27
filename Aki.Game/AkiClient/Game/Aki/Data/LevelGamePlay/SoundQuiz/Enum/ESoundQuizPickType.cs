using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.LevelGamePlay.SoundQuiz.Enum
{
	// Token: 0x02003F19 RID: 16153
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/LevelGamePlay/SoundQuiz/Enum/ESoundQuizPickType.ESoundQuizPickType")]
	public enum ESoundQuizPickType : byte
	{
		// Token: 0x04014FCB RID: 85963
		指定音源,
		// Token: 0x04014FCC RID: 85964
		指定音源类型,
		// Token: 0x04014FCD RID: 85965
		无指定,
		// Token: 0x04014FCE RID: 85966
		ESoundQuizPickType_MAX
	}
}
