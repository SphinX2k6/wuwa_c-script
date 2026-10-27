using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA8 RID: 15784
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/SimPrecision_Enum.SimPrecision_Enum")]
	public enum SimPrecision_Enum : byte
	{
		// Token: 0x04013C29 RID: 80937
		_16_bit,
		// Token: 0x04013C2A RID: 80938
		_32_bit,
		// Token: 0x04013C2B RID: 80939
		SimPrecision_MAX
	}
}
