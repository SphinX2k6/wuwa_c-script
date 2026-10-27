using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x02004441 RID: 17473
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EMovement8Direction.EMovement8Direction")]
	public enum EMovement8Direction : byte
	{
		// Token: 0x040180F3 RID: 98547
		前,
		// Token: 0x040180F4 RID: 98548
		后,
		// Token: 0x040180F5 RID: 98549
		左,
		// Token: 0x040180F6 RID: 98550
		右,
		// Token: 0x040180F7 RID: 98551
		停,
		// Token: 0x040180F8 RID: 98552
		左前,
		// Token: 0x040180F9 RID: 98553
		左后,
		// Token: 0x040180FA RID: 98554
		右前,
		// Token: 0x040180FB RID: 98555
		右后,
		// Token: 0x040180FC RID: 98556
		EMovement8Direction_MAX
	}
}
