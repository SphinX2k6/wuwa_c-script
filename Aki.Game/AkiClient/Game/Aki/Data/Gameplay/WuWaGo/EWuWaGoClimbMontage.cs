using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x02003F2C RID: 16172
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/EWuWaGoClimbMontage.EWuWaGoClimbMontage")]
	public enum EWuWaGoClimbMontage : byte
	{
		// Token: 0x0401509F RID: 86175
		Idle,
		// Token: 0x040150A0 RID: 86176
		Ground2Wall_Up,
		// Token: 0x040150A1 RID: 86177
		Ground2Wall_Down,
		// Token: 0x040150A2 RID: 86178
		Wall2Ground_Up,
		// Token: 0x040150A3 RID: 86179
		Wall2Ground_Down,
		// Token: 0x040150A4 RID: 86180
		Up,
		// Token: 0x040150A5 RID: 86181
		Down,
		// Token: 0x040150A6 RID: 86182
		Left,
		// Token: 0x040150A7 RID: 86183
		Right,
		// Token: 0x040150A8 RID: 86184
		EWuWaGoClimbMontage_MAX
	}
}
