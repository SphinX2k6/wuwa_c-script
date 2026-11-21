using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331B RID: 13083
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EOffsetDirectionDatum.EOffsetDirectionDatum")]
	public enum EOffsetDirectionDatum : byte
	{
		// Token: 0x040120F4 RID: 73972
		User,
		// Token: 0x040120F5 RID: 73973
		TargetPosition,
		// Token: 0x040120F6 RID: 73974
		UserToTarget,
		// Token: 0x040120F7 RID: 73975
		EOffsetDirectionDatum_MAX
	}
}
