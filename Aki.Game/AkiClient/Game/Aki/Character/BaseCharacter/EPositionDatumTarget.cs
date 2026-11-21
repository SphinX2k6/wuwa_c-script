using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003320 RID: 13088
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPositionDatumTarget.EPositionDatumTarget")]
	public enum EPositionDatumTarget : byte
	{
		// Token: 0x04012116 RID: 74006
		User,
		// Token: 0x04012117 RID: 74007
		Skill,
		// Token: 0x04012118 RID: 74008
		Blackboard,
		// Token: 0x04012119 RID: 74009
		EPositionDatumTarget_MAX
	}
}
