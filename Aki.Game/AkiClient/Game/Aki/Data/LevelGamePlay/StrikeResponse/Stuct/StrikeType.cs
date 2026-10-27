using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.LevelGamePlay.StrikeResponse.Stuct
{
	// Token: 0x02003F18 RID: 16152
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/LevelGamePlay/StrikeResponse/Stuct/StrikeType.StrikeType")]
	public enum StrikeType : byte
	{
		// Token: 0x04014FC5 RID: 85957
		GeneralAttack,
		// Token: 0x04014FC6 RID: 85958
		StorageAttack,
		// Token: 0x04014FC7 RID: 85959
		ULT,
		// Token: 0x04014FC8 RID: 85960
		QTE,
		// Token: 0x04014FC9 RID: 85961
		StrikeType_MAX
	}
}
