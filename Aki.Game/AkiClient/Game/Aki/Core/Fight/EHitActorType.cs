using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004004 RID: 16388
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EHitActorType.EHitActorType")]
	public enum EHitActorType : byte
	{
		// Token: 0x040159A2 RID: 88482
		全部,
		// Token: 0x040159A3 RID: 88483
		Character,
		// Token: 0x040159A4 RID: 88484
		子弹,
		// Token: 0x040159A5 RID: 88485
		场景物件,
		// Token: 0x040159A6 RID: 88486
		障碍物,
		// Token: 0x040159A7 RID: 88487
		EHitActorType_MAX
	}
}
