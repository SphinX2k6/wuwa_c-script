using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003310 RID: 13072
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFloatingMovementType.EFloatingMovementType")]
	public enum EFloatingMovementType : byte
	{
		// Token: 0x040120A6 RID: 73894
		None,
		// Token: 0x040120A7 RID: 73895
		Floating,
		// Token: 0x040120A8 RID: 73896
		Rise,
		// Token: 0x040120A9 RID: 73897
		Drop,
		// Token: 0x040120AA RID: 73898
		Walk,
		// Token: 0x040120AB RID: 73899
		EFloatingMovementType_MAX
	}
}
