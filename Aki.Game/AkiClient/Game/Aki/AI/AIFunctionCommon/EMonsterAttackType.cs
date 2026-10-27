using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x0200443F RID: 17471
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EMonsterAttackType.EMonsterAttackType")]
	public enum EMonsterAttackType : byte
	{
		// Token: 0x040180EA RID: 98538
		近远都行,
		// Token: 0x040180EB RID: 98539
		近战攻击,
		// Token: 0x040180EC RID: 98540
		远程攻击,
		// Token: 0x040180ED RID: 98541
		EMonsterAttackType_MAX
	}
}
