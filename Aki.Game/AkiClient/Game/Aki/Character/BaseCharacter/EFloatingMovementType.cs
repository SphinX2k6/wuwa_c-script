using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B7 RID: 17079
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EFloatingMovementType.EFloatingMovementType")]
	public enum EFloatingMovementType : byte
	{
		// Token: 0x040173B5 RID: 95157
		None,
		// Token: 0x040173B6 RID: 95158
		Floating,
		// Token: 0x040173B7 RID: 95159
		Rise,
		// Token: 0x040173B8 RID: 95160
		Drop,
		// Token: 0x040173B9 RID: 95161
		Walk,
		// Token: 0x040173BA RID: 95162
		EFloatingMovementType_MAX
	}
}
