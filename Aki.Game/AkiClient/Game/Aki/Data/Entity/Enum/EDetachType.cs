using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003227 RID: 12839
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EDetachType.EDetachType")]
	public enum EDetachType : byte
	{
		// Token: 0x040113AC RID: 70572
		ManualDestroy,
		// Token: 0x040113AD RID: 70573
		EntityDestroy,
		// Token: 0x040113AE RID: 70574
		DestroyExternal,
		// Token: 0x040113AF RID: 70575
		EDetachType_MAX
	}
}
