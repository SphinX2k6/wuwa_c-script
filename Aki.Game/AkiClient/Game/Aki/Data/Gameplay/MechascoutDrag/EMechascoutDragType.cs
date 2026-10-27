using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag
{
	// Token: 0x02003F45 RID: 16197
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MechascoutDrag/EMechascoutDragType.EMechascoutDragType")]
	public enum EMechascoutDragType : byte
	{
		// Token: 0x040151C9 RID: 86473
		LongPress,
		// Token: 0x040151CA RID: 86474
		Instant,
		// Token: 0x040151CB RID: 86475
		EMechascoutDragType_MAX
	}
}
