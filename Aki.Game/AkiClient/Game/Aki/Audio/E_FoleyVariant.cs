using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004435 RID: 17461
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/E_FoleyVariant.E_FoleyVariant")]
	public enum E_FoleyVariant : byte
	{
		// Token: 0x0401804D RID: 98381
		bodyfall,
		// Token: 0x0401804E RID: 98382
		fly,
		// Token: 0x0401804F RID: 98383
		run,
		// Token: 0x04018050 RID: 98384
		sprint,
		// Token: 0x04018051 RID: 98385
		hard,
		// Token: 0x04018052 RID: 98386
		hardfast,
		// Token: 0x04018053 RID: 98387
		weak,
		// Token: 0x04018054 RID: 98388
		weakfast,
		// Token: 0x04018055 RID: 98389
		E_MAX
	}
}
