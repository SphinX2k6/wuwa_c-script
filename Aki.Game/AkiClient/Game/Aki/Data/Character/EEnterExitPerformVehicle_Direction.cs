using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Character
{
	// Token: 0x02003232 RID: 12850
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Character/EEnterExitPerformVehicle_Direction.EEnterExitPerformVehicle_Direction")]
	public enum EEnterExitPerformVehicle_Direction : byte
	{
		// Token: 0x04011403 RID: 70659
		All,
		// Token: 0x04011404 RID: 70660
		Left,
		// Token: 0x04011405 RID: 70661
		Right,
		// Token: 0x04011406 RID: 70662
		EEnterExitPerformVehicle_MAX
	}
}
