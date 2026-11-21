using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.MechascoutDrag
{
	// Token: 0x020031F1 RID: 12785
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MechascoutDrag/EMechascoutDragType.EMechascoutDragType")]
	public enum EMechascoutDragType : byte
	{
		// Token: 0x04011105 RID: 69893
		LongPress,
		// Token: 0x04011106 RID: 69894
		Instant,
		// Token: 0x04011107 RID: 69895
		EMechascoutDragType_MAX
	}
}
