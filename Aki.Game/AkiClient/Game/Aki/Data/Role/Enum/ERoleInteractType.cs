using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Role.Enum
{
	// Token: 0x02003EA4 RID: 16036
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Enum/ERoleInteractType.ERoleInteractType")]
	public enum ERoleInteractType : byte
	{
		// Token: 0x04014B07 RID: 84743
		SitDown,
		// Token: 0x04014B08 RID: 84744
		Bounce,
		// Token: 0x04014B09 RID: 84745
		Catapult,
		// Token: 0x04014B0A RID: 84746
		Manipulate,
		// Token: 0x04014B0B RID: 84747
		ERoleInteractType_MAX
	}
}
