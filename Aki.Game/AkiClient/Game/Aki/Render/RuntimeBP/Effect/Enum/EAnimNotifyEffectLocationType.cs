using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum
{
	// Token: 0x0200310E RID: 12558
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Enum/EAnimNotifyEffectLocationType.EAnimNotifyEffectLocationType")]
	public enum EAnimNotifyEffectLocationType : byte
	{
		// Token: 0x0401057D RID: 66941
		Normal,
		// Token: 0x0401057E RID: 66942
		FloorPassBy,
		// Token: 0x0401057F RID: 66943
		Raytrace,
		// Token: 0x04010580 RID: 66944
		EAnimNotifyEffectLocationType_MAX
	}
}
