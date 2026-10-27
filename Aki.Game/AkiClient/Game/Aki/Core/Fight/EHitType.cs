using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004005 RID: 16389
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/EHitType.EHitType")]
	public enum EHitType : byte
	{
		// Token: 0x040159A9 RID: 88489
		对自己,
		// Token: 0x040159AA RID: 88490
		对友方,
		// Token: 0x040159AB RID: 88491
		对敌方,
		// Token: 0x040159AC RID: 88492
		对队伍,
		// Token: 0x040159AD RID: 88493
		对小队,
		// Token: 0x040159AE RID: 88494
		EHitType_MAX
	}
}
