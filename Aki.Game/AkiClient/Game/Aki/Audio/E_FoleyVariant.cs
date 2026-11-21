using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x020033FE RID: 13310
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/E_FoleyVariant.E_FoleyVariant")]
	public enum E_FoleyVariant : byte
	{
		// Token: 0x04012A02 RID: 76290
		bodyfall,
		// Token: 0x04012A03 RID: 76291
		fly,
		// Token: 0x04012A04 RID: 76292
		run,
		// Token: 0x04012A05 RID: 76293
		sprint,
		// Token: 0x04012A06 RID: 76294
		hard,
		// Token: 0x04012A07 RID: 76295
		hardfast,
		// Token: 0x04012A08 RID: 76296
		weak,
		// Token: 0x04012A09 RID: 76297
		weakfast,
		// Token: 0x04012A0A RID: 76298
		E_MAX
	}
}
