using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.LevelGamePlay.StrikeResponse.Stuct
{
	// Token: 0x02003F16 RID: 16150
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/LevelGamePlay/StrikeResponse/Stuct/SrikeElement.SrikeElement")]
	public enum SrikeElement : byte
	{
		// Token: 0x04014FB4 RID: 85940
		AD,
		// Token: 0x04014FB5 RID: 85941
		Ice,
		// Token: 0x04014FB6 RID: 85942
		Fire,
		// Token: 0x04014FB7 RID: 85943
		Thunder,
		// Token: 0x04014FB8 RID: 85944
		Wind,
		// Token: 0x04014FB9 RID: 85945
		Light,
		// Token: 0x04014FBA RID: 85946
		Dark,
		// Token: 0x04014FBB RID: 85947
		AddBlood,
		// Token: 0x04014FBC RID: 85948
		Immune,
		// Token: 0x04014FBD RID: 85949
		SrikeElement_MAX
	}
}
