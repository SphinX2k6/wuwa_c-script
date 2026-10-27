using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x02004440 RID: 17472
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EMonsterType.EMonsterType")]
	public enum EMonsterType : byte
	{
		// Token: 0x040180EF RID: 98543
		地面单位,
		// Token: 0x040180F0 RID: 98544
		飞行单位,
		// Token: 0x040180F1 RID: 98545
		EMonsterType_MAX
	}
}
