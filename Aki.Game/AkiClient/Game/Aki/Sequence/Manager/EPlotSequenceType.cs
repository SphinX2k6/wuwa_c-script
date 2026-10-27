using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2B RID: 14891
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/EPlotSequenceType.EPlotSequenceType")]
	public enum EPlotSequenceType : byte
	{
		// Token: 0x0400F0D9 RID: 61657
		过场,
		// Token: 0x0400F0DA RID: 61658
		站桩,
		// Token: 0x0400F0DB RID: 61659
		其他,
		// Token: 0x0400F0DC RID: 61660
		EPlotSequenceType_MAX
	}
}
