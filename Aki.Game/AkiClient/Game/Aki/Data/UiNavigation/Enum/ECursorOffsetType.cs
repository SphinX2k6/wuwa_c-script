using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiNavigation.Enum
{
	// Token: 0x02003E8B RID: 16011
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Enum/ECursorOffsetType.ECursorOffsetType")]
	public enum ECursorOffsetType : byte
	{
		// Token: 0x040149D5 RID: 84437
		Left,
		// Token: 0x040149D6 RID: 84438
		Top,
		// Token: 0x040149D7 RID: 84439
		Right,
		// Token: 0x040149D8 RID: 84440
		Down,
		// Token: 0x040149D9 RID: 84441
		ECursorOffsetType_MAX
	}
}
