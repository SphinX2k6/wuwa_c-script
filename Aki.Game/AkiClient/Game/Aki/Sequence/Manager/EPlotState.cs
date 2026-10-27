using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2C RID: 14892
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/EPlotState.EPlotState")]
	public enum EPlotState : byte
	{
		// Token: 0x0400F0DE RID: 61662
		Start,
		// Token: 0x0400F0DF RID: 61663
		End,
		// Token: 0x0400F0E0 RID: 61664
		EPlotState_MAX
	}
}
