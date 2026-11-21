using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003269 RID: 12905
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EHitType.EHitType")]
	public enum EHitType : byte
	{
		// Token: 0x0401160A RID: 71178
		对自己,
		// Token: 0x0401160B RID: 71179
		对友方,
		// Token: 0x0401160C RID: 71180
		对敌方,
		// Token: 0x0401160D RID: 71181
		对队伍,
		// Token: 0x0401160E RID: 71182
		对小队,
		// Token: 0x0401160F RID: 71183
		EHitType_MAX
	}
}
