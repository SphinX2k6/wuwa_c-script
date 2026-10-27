using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core.Niagara.SPH
{
	// Token: 0x02003DAF RID: 15791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/Niagara/SPH/ENiagaraGrid2DResolution.ENiagaraGrid2DResolution")]
	public enum ENiagaraGrid2DResolution : byte
	{
		// Token: 0x04013C4A RID: 80970
		Independent,
		// Token: 0x04013C4B RID: 80971
		Max_Axis,
		// Token: 0x04013C4C RID: 80972
		World_Cell_Size,
		// Token: 0x04013C4D RID: 80973
		Other_Grid,
		// Token: 0x04013C4E RID: 80974
		ENiagaraGrid2DResolution_MAX
	}
}
