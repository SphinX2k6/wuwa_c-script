using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Role.Enum
{
	// Token: 0x02003173 RID: 12659
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Enum/ERoleInteractType.ERoleInteractType")]
	public enum ERoleInteractType : byte
	{
		// Token: 0x04010B38 RID: 68408
		SitDown,
		// Token: 0x04010B39 RID: 68409
		Bounce,
		// Token: 0x04010B3A RID: 68410
		Catapult,
		// Token: 0x04010B3B RID: 68411
		Manipulate,
		// Token: 0x04010B3C RID: 68412
		ERoleInteractType_MAX
	}
}
