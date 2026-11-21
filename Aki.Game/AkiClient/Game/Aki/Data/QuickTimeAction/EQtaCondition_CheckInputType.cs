using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003176 RID: 12662
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaCondition_CheckInputType.EQtaCondition_CheckInputType")]
	public enum EQtaCondition_CheckInputType : byte
	{
		// Token: 0x04010B4A RID: 68426
		按下按键,
		// Token: 0x04010B4B RID: 68427
		抬起按键,
		// Token: 0x04010B4C RID: 68428
		已按键,
		// Token: 0x04010B4D RID: 68429
		没按键,
		// Token: 0x04010B4E RID: 68430
		EQtaCondition_MAX
	}
}
