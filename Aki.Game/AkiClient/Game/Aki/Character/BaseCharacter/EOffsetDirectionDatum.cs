using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C5 RID: 17093
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EOffsetDirectionDatum.EOffsetDirectionDatum")]
	public enum EOffsetDirectionDatum : byte
	{
		// Token: 0x04017412 RID: 95250
		User,
		// Token: 0x04017413 RID: 95251
		TargetPosition,
		// Token: 0x04017414 RID: 95252
		UserToTarget,
		// Token: 0x04017415 RID: 95253
		EOffsetDirectionDatum_MAX
	}
}
