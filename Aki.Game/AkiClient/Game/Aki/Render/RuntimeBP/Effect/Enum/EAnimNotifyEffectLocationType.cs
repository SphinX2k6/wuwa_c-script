using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum
{
	// Token: 0x02003DDA RID: 15834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Enum/EAnimNotifyEffectLocationType.EAnimNotifyEffectLocationType")]
	public enum EAnimNotifyEffectLocationType : byte
	{
		// Token: 0x04013F4D RID: 81741
		Normal,
		// Token: 0x04013F4E RID: 81742
		FloorPassBy,
		// Token: 0x04013F4F RID: 81743
		Raytrace,
		// Token: 0x04013F50 RID: 81744
		EAnimNotifyEffectLocationType_MAX
	}
}
