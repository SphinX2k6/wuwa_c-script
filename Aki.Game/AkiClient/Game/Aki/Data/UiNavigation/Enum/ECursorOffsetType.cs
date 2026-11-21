using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiNavigation.Enum
{
	// Token: 0x02003162 RID: 12642
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Enum/ECursorOffsetType.ECursorOffsetType")]
	public enum ECursorOffsetType : byte
	{
		// Token: 0x04010A56 RID: 68182
		Left,
		// Token: 0x04010A57 RID: 68183
		Top,
		// Token: 0x04010A58 RID: 68184
		Right,
		// Token: 0x04010A59 RID: 68185
		Down,
		// Token: 0x04010A5A RID: 68186
		ECursorOffsetType_MAX
	}
}
