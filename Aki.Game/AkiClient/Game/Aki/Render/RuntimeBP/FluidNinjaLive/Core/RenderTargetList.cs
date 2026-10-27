using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA6 RID: 15782
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/RenderTargetList.RenderTargetList")]
	public enum RenderTargetList : byte
	{
		// Token: 0x04013C1E RID: 80926
		RT_VelocityDensity,
		// Token: 0x04013C1F RID: 80927
		RT_Divergence,
		// Token: 0x04013C20 RID: 80928
		RT_Pressure,
		// Token: 0x04013C21 RID: 80929
		RT_Painter,
		// Token: 0x04013C22 RID: 80930
		RT_Output,
		// Token: 0x04013C23 RID: 80931
		RenderTargetList_MAX
	}
}
