using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x020033FF RID: 13311
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/E_FootstepVariant.E_FootstepVariant")]
	public enum E_FootstepVariant : byte
	{
		// Token: 0x04012A0C RID: 76300
		land,
		// Token: 0x04012A0D RID: 76301
		run,
		// Token: 0x04012A0E RID: 76302
		runstop,
		// Token: 0x04012A0F RID: 76303
		sprint,
		// Token: 0x04012A10 RID: 76304
		sprintstop,
		// Token: 0x04012A11 RID: 76305
		walk,
		// Token: 0x04012A12 RID: 76306
		walkstop,
		// Token: 0x04012A13 RID: 76307
		turnback,
		// Token: 0x04012A14 RID: 76308
		E_MAX
	}
}
