using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003F7C RID: 16252
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEFollowShooterAttachStrategy.BPEFollowShooterAttachStrategy")]
	public enum BPEFollowShooterAttachStrategy : byte
	{
		// Token: 0x0401544A RID: 87114
		DirectAttach,
		// Token: 0x0401544B RID: 87115
		SocketTracking,
		// Token: 0x0401544C RID: 87116
		BPEFollowShooterAttachStrategy_MAX
	}
}
