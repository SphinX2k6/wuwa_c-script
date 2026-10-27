using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428E RID: 17038
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAttackType.EAttackType")]
	public enum EAttackType : byte
	{
		// Token: 0x0401728D RID: 94861
		Auto,
		// Token: 0x0401728E RID: 94862
		Cast,
		// Token: 0x0401728F RID: 94863
		Ultra,
		// Token: 0x04017290 RID: 94864
		QTE,
		// Token: 0x04017291 RID: 94865
		EAttackType_MAX
	}
}
