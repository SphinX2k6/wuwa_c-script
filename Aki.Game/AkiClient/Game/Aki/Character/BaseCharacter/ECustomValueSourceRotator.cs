using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003306 RID: 13062
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceRotator.ECustomValueSourceRotator")]
	public enum ECustomValueSourceRotator : byte
	{
		// Token: 0x0401205A RID: 73818
		固定值,
		// Token: 0x0401205B RID: 73819
		表达式,
		// Token: 0x0401205C RID: 73820
		技能目标朝向,
		// Token: 0x0401205D RID: 73821
		使用者朝向,
		// Token: 0x0401205E RID: 73822
		ECustomValueSourceRotator_MAX
	}
}
