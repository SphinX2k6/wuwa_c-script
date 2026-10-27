using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Scene.Gacha.Blueprint
{
	// Token: 0x02003A69 RID: 14953
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Scene/Gacha/Blueprint/E_GachaResult.E_GachaResult")]
	public enum E_GachaResult : byte
	{
		// Token: 0x0400F32D RID: 62253
		OneShotNormal,
		// Token: 0x0400F32E RID: 62254
		OneShotPurple,
		// Token: 0x0400F32F RID: 62255
		OneShotGolden,
		// Token: 0x0400F330 RID: 62256
		TenShotsPurple,
		// Token: 0x0400F331 RID: 62257
		TenShotsGolden,
		// Token: 0x0400F332 RID: 62258
		E_MAX
	}
}
