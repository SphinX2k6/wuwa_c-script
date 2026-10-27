using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CA RID: 17098
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPositionDatumTarget.EPositionDatumTarget")]
	public enum EPositionDatumTarget : byte
	{
		// Token: 0x04017434 RID: 95284
		User,
		// Token: 0x04017435 RID: 95285
		Skill,
		// Token: 0x04017436 RID: 95286
		Blackboard,
		// Token: 0x04017437 RID: 95287
		EPositionDatumTarget_MAX
	}
}
