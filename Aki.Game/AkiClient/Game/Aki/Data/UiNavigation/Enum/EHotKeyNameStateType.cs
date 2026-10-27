using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiNavigation.Enum
{
	// Token: 0x02003E8C RID: 16012
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Enum/EHotKeyNameStateType.EHotKeyNameStateType")]
	public enum EHotKeyNameStateType : byte
	{
		// Token: 0x040149DB RID: 84443
		None,
		// Token: 0x040149DC RID: 84444
		Normal,
		// Token: 0x040149DD RID: 84445
		ToggleSelected,
		// Token: 0x040149DE RID: 84446
		EHotKeyNameStateType_MAX
	}
}
