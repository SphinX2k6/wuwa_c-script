using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003216 RID: 12822
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEAttachmentRule.BPEAttachmentRule")]
	public enum BPEAttachmentRule : byte
	{
		// Token: 0x040112DF RID: 70367
		KeepRelative,
		// Token: 0x040112E0 RID: 70368
		KeepWorld,
		// Token: 0x040112E1 RID: 70369
		SnapToTarget,
		// Token: 0x040112E2 RID: 70370
		BPEAttachmentRule_MAX
	}
}
