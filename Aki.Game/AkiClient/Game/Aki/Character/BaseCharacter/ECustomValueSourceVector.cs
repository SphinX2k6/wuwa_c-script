using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042AE RID: 17070
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceVector.ECustomValueSourceVector")]
	public enum ECustomValueSourceVector : byte
	{
		// Token: 0x0401736F RID: 95087
		固定值,
		// Token: 0x04017370 RID: 95088
		表达式,
		// Token: 0x04017371 RID: 95089
		技能目标位置,
		// Token: 0x04017372 RID: 95090
		使用者位置,
		// Token: 0x04017373 RID: 95091
		使用者朝技能目标标准向量,
		// Token: 0x04017374 RID: 95092
		使用者朝技能目标水平标准向量,
		// Token: 0x04017375 RID: 95093
		使用者前向量,
		// Token: 0x04017376 RID: 95094
		使用者右向量,
		// Token: 0x04017377 RID: 95095
		使用者上向量,
		// Token: 0x04017378 RID: 95096
		技能目标前向量,
		// Token: 0x04017379 RID: 95097
		技能目标右向量,
		// Token: 0x0401737A RID: 95098
		技能目标上向量,
		// Token: 0x0401737B RID: 95099
		ECustomValueSourceVector_MAX
	}
}
