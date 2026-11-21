using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x020031D8 RID: 12760
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/EWuWaGoClimbMontage.EWuWaGoClimbMontage")]
	public enum EWuWaGoClimbMontage : byte
	{
		// Token: 0x04010FCF RID: 69583
		Idle,
		// Token: 0x04010FD0 RID: 69584
		Ground2Wall_Up,
		// Token: 0x04010FD1 RID: 69585
		Ground2Wall_Down,
		// Token: 0x04010FD2 RID: 69586
		Wall2Ground_Up,
		// Token: 0x04010FD3 RID: 69587
		Wall2Ground_Down,
		// Token: 0x04010FD4 RID: 69588
		Up,
		// Token: 0x04010FD5 RID: 69589
		Down,
		// Token: 0x04010FD6 RID: 69590
		Left,
		// Token: 0x04010FD7 RID: 69591
		Right,
		// Token: 0x04010FD8 RID: 69592
		EWuWaGoClimbMontage_MAX
	}
}
