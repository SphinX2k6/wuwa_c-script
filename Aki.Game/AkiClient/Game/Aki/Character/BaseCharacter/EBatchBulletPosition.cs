using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004294 RID: 17044
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletPosition.EBatchBulletPosition")]
	public enum EBatchBulletPosition : byte
	{
		// Token: 0x040172AC RID: 94892
		DotMatrix,
		// Token: 0x040172AD RID: 94893
		Circle,
		// Token: 0x040172AE RID: 94894
		Spline,
		// Token: 0x040172AF RID: 94895
		EBatchBulletPosition_MAX
	}
}
