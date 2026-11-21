using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiNavigation.Enum
{
	// Token: 0x02003163 RID: 12643
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Enum/EHotKeyNameStateType.EHotKeyNameStateType")]
	public enum EHotKeyNameStateType : byte
	{
		// Token: 0x04010A5C RID: 68188
		None,
		// Token: 0x04010A5D RID: 68189
		Normal,
		// Token: 0x04010A5E RID: 68190
		ToggleSelected,
		// Token: 0x04010A5F RID: 68191
		EHotKeyNameStateType_MAX
	}
}
