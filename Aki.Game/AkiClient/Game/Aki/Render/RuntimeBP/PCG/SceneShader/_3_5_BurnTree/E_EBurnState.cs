using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_5_BurnTree
{
	// Token: 0x02003C12 RID: 15378
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_5_BurnTree/E_EBurnState.E_EBurnState")]
	public enum E_EBurnState : byte
	{
		// Token: 0x0401156C RID: 71020
		Idle,
		// Token: 0x0401156D RID: 71021
		PreBurn,
		// Token: 0x0401156E RID: 71022
		Burning,
		// Token: 0x0401156F RID: 71023
		LeavesDecay,
		// Token: 0x04011570 RID: 71024
		EmberFadeOut,
		// Token: 0x04011571 RID: 71025
		BurnedOut,
		// Token: 0x04011572 RID: 71026
		E_MAX
	}
}
