using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2D RID: 14893
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/ESeqSwtichType.ESeqSwtichType")]
	public enum ESeqSwtichType : byte
	{
		// Token: 0x0400F0E2 RID: 61666
		Auto,
		// Token: 0x0400F0E3 RID: 61667
		Condition,
		// Token: 0x0400F0E4 RID: 61668
		Manual,
		// Token: 0x0400F0E5 RID: 61669
		ESeqSwtichType_MAX
	}
}
