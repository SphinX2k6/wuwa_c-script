using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A4B RID: 14923
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/E_GachaResultNew.E_GachaResultNew")]
	public enum E_GachaResultNew : byte
	{
		// Token: 0x0400F2AC RID: 62124
		OneShotNormal,
		// Token: 0x0400F2AD RID: 62125
		OneShotPurple,
		// Token: 0x0400F2AE RID: 62126
		OneShotGolden,
		// Token: 0x0400F2AF RID: 62127
		TenShotsPurple,
		// Token: 0x0400F2B0 RID: 62128
		TenShotsGolden,
		// Token: 0x0400F2B1 RID: 62129
		E_MAX
	}
}
