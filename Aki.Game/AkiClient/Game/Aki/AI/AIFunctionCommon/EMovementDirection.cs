using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x02003404 RID: 13316
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EMovementDirection.EMovementDirection")]
	public enum EMovementDirection : byte
	{
		// Token: 0x04012A65 RID: 76389
		前,
		// Token: 0x04012A66 RID: 76390
		后,
		// Token: 0x04012A67 RID: 76391
		左,
		// Token: 0x04012A68 RID: 76392
		右,
		// Token: 0x04012A69 RID: 76393
		停,
		// Token: 0x04012A6A RID: 76394
		EMovementDirection_MAX
	}
}
