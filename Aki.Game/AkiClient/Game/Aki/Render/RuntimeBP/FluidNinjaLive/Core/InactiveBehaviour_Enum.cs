using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D99 RID: 15769
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/InactiveBehaviour_Enum.InactiveBehaviour_Enum")]
	public enum InactiveBehaviour_Enum : byte
	{
		// Token: 0x04013B09 RID: 80649
		Hold_last_frame_when_inactive,
		// Token: 0x04013B0A RID: 80650
		Gray_when_inactive,
		// Token: 0x04013B0B RID: 80651
		Hidden_when_inactive,
		// Token: 0x04013B0C RID: 80652
		InactiveBehaviour_MAX
	}
}
