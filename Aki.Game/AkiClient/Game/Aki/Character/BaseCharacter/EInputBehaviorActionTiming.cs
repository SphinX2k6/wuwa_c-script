using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003315 RID: 13077
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputBehaviorActionTiming.EInputBehaviorActionTiming")]
	public enum EInputBehaviorActionTiming : byte
	{
		// Token: 0x040120CC RID: 73932
		立即执行,
		// Token: 0x040120CD RID: 73933
		等待ANS完成时执行,
		// Token: 0x040120CE RID: 73934
		EInputBehaviorActionTiming_MAX
	}
}
