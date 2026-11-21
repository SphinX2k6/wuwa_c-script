using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Battle
{
	// Token: 0x0200313F RID: 12607
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Battle/EWuYinQuState.EWuYinQuState")]
	public enum EWuYinQuState : byte
	{
		// Token: 0x04010853 RID: 67667
		StateIdle,
		// Token: 0x04010854 RID: 67668
		StateFighting1,
		// Token: 0x04010855 RID: 67669
		StateFighting2,
		// Token: 0x04010856 RID: 67670
		StateFighting3,
		// Token: 0x04010857 RID: 67671
		Nothing,
		// Token: 0x04010858 RID: 67672
		EWuYinQuState_MAX
	}
}
