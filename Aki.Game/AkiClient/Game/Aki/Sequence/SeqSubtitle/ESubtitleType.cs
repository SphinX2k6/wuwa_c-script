using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.SeqSubtitle
{
	// Token: 0x02003A25 RID: 14885
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/SeqSubtitle/ESubtitleType.ESubtitleType")]
	public enum ESubtitleType : byte
	{
		// Token: 0x0400F059 RID: 61529
		Normal,
		// Token: 0x0400F05A RID: 61530
		Dialog,
		// Token: 0x0400F05B RID: 61531
		Option,
		// Token: 0x0400F05C RID: 61532
		Reply,
		// Token: 0x0400F05D RID: 61533
		ESubtitleType_MAX
	}
}
