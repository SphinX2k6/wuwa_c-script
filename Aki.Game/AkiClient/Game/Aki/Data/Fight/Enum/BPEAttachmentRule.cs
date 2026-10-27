using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003F79 RID: 16249
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEAttachmentRule.BPEAttachmentRule")]
	public enum BPEAttachmentRule : byte
	{
		// Token: 0x0401543C RID: 87100
		KeepRelative,
		// Token: 0x0401543D RID: 87101
		KeepWorld,
		// Token: 0x0401543E RID: 87102
		SnapToTarget,
		// Token: 0x0401543F RID: 87103
		BPEAttachmentRule_MAX
	}
}
