using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x02004442 RID: 17474
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EMovementDirection.EMovementDirection")]
	public enum EMovementDirection : byte
	{
		// Token: 0x040180FE RID: 98558
		前,
		// Token: 0x040180FF RID: 98559
		后,
		// Token: 0x04018100 RID: 98560
		左,
		// Token: 0x04018101 RID: 98561
		右,
		// Token: 0x04018102 RID: 98562
		停,
		// Token: 0x04018103 RID: 98563
		EMovementDirection_MAX
	}
}
