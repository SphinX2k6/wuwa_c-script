using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Character
{
	// Token: 0x02003FA9 RID: 16297
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Character/EEnterExitPerformVehicle_Direction.EEnterExitPerformVehicle_Direction")]
	public enum EEnterExitPerformVehicle_Direction : byte
	{
		// Token: 0x040155DE RID: 87518
		All,
		// Token: 0x040155DF RID: 87519
		Left,
		// Token: 0x040155E0 RID: 87520
		Right,
		// Token: 0x040155E1 RID: 87521
		EEnterExitPerformVehicle_MAX
	}
}
