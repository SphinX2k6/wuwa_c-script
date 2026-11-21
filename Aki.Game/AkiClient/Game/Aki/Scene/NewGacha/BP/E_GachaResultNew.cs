using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003089 RID: 12425
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/E_GachaResultNew.E_GachaResultNew")]
	public enum E_GachaResultNew : byte
	{
		// Token: 0x0400FAE1 RID: 64225
		OneShotNormal,
		// Token: 0x0400FAE2 RID: 64226
		OneShotPurple,
		// Token: 0x0400FAE3 RID: 64227
		OneShotGolden,
		// Token: 0x0400FAE4 RID: 64228
		TenShotsPurple,
		// Token: 0x0400FAE5 RID: 64229
		TenShotsGolden,
		// Token: 0x0400FAE6 RID: 64230
		E_MAX
	}
}
