using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Common.Enum
{
	// Token: 0x0200322F RID: 12847
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Enum/EDayState.EDayState")]
	public enum EDayState : byte
	{
		// Token: 0x040113F1 RID: 70641
		白天,
		// Token: 0x040113F2 RID: 70642
		晚上,
		// Token: 0x040113F3 RID: 70643
		EDayState_MAX
	}
}
