using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x020033B9 RID: 13241
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/EGameplayABPType.EGameplayABPType")]
	public enum EGameplayABPType : byte
	{
		// Token: 0x040125DA RID: 75226
		None,
		// Token: 0x040125DB RID: 75227
		Motor,
		// Token: 0x040125DC RID: 75228
		Poker,
		// Token: 0x040125DD RID: 75229
		ThunderBird,
		// Token: 0x040125DE RID: 75230
		SlopeSlide,
		// Token: 0x040125DF RID: 75231
		SwordRiding,
		// Token: 0x040125E0 RID: 75232
		AssistedWalk,
		// Token: 0x040125E1 RID: 75233
		RideHorse,
		// Token: 0x040125E2 RID: 75234
		Selfie,
		// Token: 0x040125E3 RID: 75235
		Totter,
		// Token: 0x040125E4 RID: 75236
		Ecology,
		// Token: 0x040125E5 RID: 75237
		EGameplayABPType_MAX
	}
}
