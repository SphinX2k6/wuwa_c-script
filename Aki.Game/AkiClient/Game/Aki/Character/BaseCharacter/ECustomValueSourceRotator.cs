using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AD RID: 17069
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceRotator.ECustomValueSourceRotator")]
	public enum ECustomValueSourceRotator : byte
	{
		// Token: 0x04017369 RID: 95081
		固定值,
		// Token: 0x0401736A RID: 95082
		表达式,
		// Token: 0x0401736B RID: 95083
		技能目标朝向,
		// Token: 0x0401736C RID: 95084
		使用者朝向,
		// Token: 0x0401736D RID: 95085
		ECustomValueSourceRotator_MAX
	}
}
