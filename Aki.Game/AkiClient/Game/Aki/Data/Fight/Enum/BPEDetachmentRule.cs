using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003F7A RID: 16250
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEDetachmentRule.BPEDetachmentRule")]
	public enum BPEDetachmentRule : byte
	{
		// Token: 0x04015441 RID: 87105
		KeepRelative,
		// Token: 0x04015442 RID: 87106
		KeepWorld,
		// Token: 0x04015443 RID: 87107
		BPEDetachmentRule_MAX
	}
}
