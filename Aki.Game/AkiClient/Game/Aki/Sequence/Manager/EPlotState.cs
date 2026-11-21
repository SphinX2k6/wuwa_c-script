using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003075 RID: 12405
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/EPlotState.EPlotState")]
	public enum EPlotState : byte
	{
		// Token: 0x0400F960 RID: 63840
		Start,
		// Token: 0x0400F961 RID: 63841
		End,
		// Token: 0x0400F962 RID: 63842
		EPlotState_MAX
	}
}
