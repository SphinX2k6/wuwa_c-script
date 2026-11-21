using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003190 RID: 12688
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteInteractiveTiming.ECommonQteInteractiveTiming")]
	public enum ECommonQteInteractiveTiming : byte
	{
		// Token: 0x04010C2C RID: 68652
		始终,
		// Token: 0x04010C2D RID: 68653
		开始动画结束后,
		// Token: 0x04010C2E RID: 68654
		ECommonQteInteractiveTiming_MAX
	}
}
