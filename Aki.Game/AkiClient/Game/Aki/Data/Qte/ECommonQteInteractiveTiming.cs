using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECB RID: 16075
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteInteractiveTiming.ECommonQteInteractiveTiming")]
	public enum ECommonQteInteractiveTiming : byte
	{
		// Token: 0x04014C46 RID: 85062
		始终,
		// Token: 0x04014C47 RID: 85063
		开始动画结束后,
		// Token: 0x04014C48 RID: 85064
		ECommonQteInteractiveTiming_MAX
	}
}
