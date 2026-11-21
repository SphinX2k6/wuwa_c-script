using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003217 RID: 12823
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEDetachmentRule.BPEDetachmentRule")]
	public enum BPEDetachmentRule : byte
	{
		// Token: 0x040112E4 RID: 70372
		KeepRelative,
		// Token: 0x040112E5 RID: 70373
		KeepWorld,
		// Token: 0x040112E6 RID: 70374
		BPEDetachmentRule_MAX
	}
}
