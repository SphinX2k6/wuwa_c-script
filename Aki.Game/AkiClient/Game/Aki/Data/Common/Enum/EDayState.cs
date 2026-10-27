using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Common.Enum
{
	// Token: 0x02003FA6 RID: 16294
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Enum/EDayState.EDayState")]
	public enum EDayState : byte
	{
		// Token: 0x040155CC RID: 87500
		白天,
		// Token: 0x040155CD RID: 87501
		晚上,
		// Token: 0x040155CE RID: 87502
		EDayState_MAX
	}
}
