using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EA8 RID: 16040
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaCondition_CheckInputType.EQtaCondition_CheckInputType")]
	public enum EQtaCondition_CheckInputType : byte
	{
		// Token: 0x04014B1E RID: 84766
		按下按键,
		// Token: 0x04014B1F RID: 84767
		抬起按键,
		// Token: 0x04014B20 RID: 84768
		已按键,
		// Token: 0x04014B21 RID: 84769
		没按键,
		// Token: 0x04014B22 RID: 84770
		EQtaCondition_MAX
	}
}
