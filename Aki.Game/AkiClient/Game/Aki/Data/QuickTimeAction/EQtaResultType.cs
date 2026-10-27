using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EAB RID: 16043
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaResultType.EQtaResultType")]
	public enum EQtaResultType : byte
	{
		// Token: 0x04014B34 RID: 84788
		None,
		// Token: 0x04014B35 RID: 84789
		成功,
		// Token: 0x04014B36 RID: 84790
		失败,
		// Token: 0x04014B37 RID: 84791
		超时,
		// Token: 0x04014B38 RID: 84792
		失活,
		// Token: 0x04014B39 RID: 84793
		EQtaResultType_MAX
	}
}
