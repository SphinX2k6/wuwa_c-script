using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003074 RID: 12404
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/EPlotSequenceType.EPlotSequenceType")]
	public enum EPlotSequenceType : byte
	{
		// Token: 0x0400F95B RID: 63835
		过场,
		// Token: 0x0400F95C RID: 63836
		站桩,
		// Token: 0x0400F95D RID: 63837
		其他,
		// Token: 0x0400F95E RID: 63838
		EPlotSequenceType_MAX
	}
}
