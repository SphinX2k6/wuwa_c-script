using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Scene.Gacha.Blueprint
{
	// Token: 0x020030A5 RID: 12453
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Scene/Gacha/Blueprint/E_GachaResult.E_GachaResult")]
	public enum E_GachaResult : byte
	{
		// Token: 0x0400FB49 RID: 64329
		OneShotNormal,
		// Token: 0x0400FB4A RID: 64330
		OneShotPurple,
		// Token: 0x0400FB4B RID: 64331
		OneShotGolden,
		// Token: 0x0400FB4C RID: 64332
		TenShotsPurple,
		// Token: 0x0400FB4D RID: 64333
		TenShotsGolden,
		// Token: 0x0400FB4E RID: 64334
		E_MAX
	}
}
