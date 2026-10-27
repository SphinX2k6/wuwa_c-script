using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP
{
	// Token: 0x02004399 RID: 17305
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/GameplayABP/EGameplayABPType.EGameplayABPType")]
	public enum EGameplayABPType : byte
	{
		// Token: 0x04017A5F RID: 96863
		None,
		// Token: 0x04017A60 RID: 96864
		Motor,
		// Token: 0x04017A61 RID: 96865
		Poker,
		// Token: 0x04017A62 RID: 96866
		ThunderBird,
		// Token: 0x04017A63 RID: 96867
		SlopeSlide,
		// Token: 0x04017A64 RID: 96868
		SwordRiding,
		// Token: 0x04017A65 RID: 96869
		AssistedWalk,
		// Token: 0x04017A66 RID: 96870
		RideHorse,
		// Token: 0x04017A67 RID: 96871
		Selfie,
		// Token: 0x04017A68 RID: 96872
		Totter,
		// Token: 0x04017A69 RID: 96873
		Ecology,
		// Token: 0x04017A6A RID: 96874
		EGameplayABPType_MAX
	}
}
