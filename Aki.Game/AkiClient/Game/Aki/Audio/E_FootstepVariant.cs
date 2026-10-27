using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004436 RID: 17462
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/E_FootstepVariant.E_FootstepVariant")]
	public enum E_FootstepVariant : byte
	{
		// Token: 0x04018057 RID: 98391
		land,
		// Token: 0x04018058 RID: 98392
		run,
		// Token: 0x04018059 RID: 98393
		runstop,
		// Token: 0x0401805A RID: 98394
		sprint,
		// Token: 0x0401805B RID: 98395
		sprintstop,
		// Token: 0x0401805C RID: 98396
		walk,
		// Token: 0x0401805D RID: 98397
		walkstop,
		// Token: 0x0401805E RID: 98398
		turnback,
		// Token: 0x0401805F RID: 98399
		E_MAX
	}
}
