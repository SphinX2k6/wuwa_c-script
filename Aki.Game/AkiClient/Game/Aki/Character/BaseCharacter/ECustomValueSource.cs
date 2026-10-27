using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AB RID: 17067
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSource.ECustomValueSource")]
	public enum ECustomValueSource : byte
	{
		// Token: 0x0401735D RID: 95069
		固定值,
		// Token: 0x0401735E RID: 95070
		表达式,
		// Token: 0x0401735F RID: 95071
		技能目标位置,
		// Token: 0x04017360 RID: 95072
		使用者位置,
		// Token: 0x04017361 RID: 95073
		技能目标朝向,
		// Token: 0x04017362 RID: 95074
		使用者朝向,
		// Token: 0x04017363 RID: 95075
		ECustomValueSource_MAX
	}
}
