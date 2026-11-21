using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003179 RID: 12665
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaResultType.EQtaResultType")]
	public enum EQtaResultType : byte
	{
		// Token: 0x04010B60 RID: 68448
		None,
		// Token: 0x04010B61 RID: 68449
		成功,
		// Token: 0x04010B62 RID: 68450
		失败,
		// Token: 0x04010B63 RID: 68451
		超时,
		// Token: 0x04010B64 RID: 68452
		失活,
		// Token: 0x04010B65 RID: 68453
		EQtaResultType_MAX
	}
}
