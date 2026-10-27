using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003F93 RID: 16275
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EDetachType.EDetachType")]
	public enum EDetachType : byte
	{
		// Token: 0x04015536 RID: 87350
		ManualDestroy,
		// Token: 0x04015537 RID: 87351
		EntityDestroy,
		// Token: 0x04015538 RID: 87352
		DestroyExternal,
		// Token: 0x04015539 RID: 87353
		EDetachType_MAX
	}
}
