using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003219 RID: 12825
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEFollowShooterAttachStrategy.BPEFollowShooterAttachStrategy")]
	public enum BPEFollowShooterAttachStrategy : byte
	{
		// Token: 0x040112ED RID: 70381
		DirectAttach,
		// Token: 0x040112EE RID: 70382
		SocketTracking,
		// Token: 0x040112EF RID: 70383
		BPEFollowShooterAttachStrategy_MAX
	}
}
