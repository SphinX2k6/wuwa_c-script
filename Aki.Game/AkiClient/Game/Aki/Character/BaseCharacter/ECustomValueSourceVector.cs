using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003307 RID: 13063
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECustomValueSourceVector.ECustomValueSourceVector")]
	public enum ECustomValueSourceVector : byte
	{
		// Token: 0x04012060 RID: 73824
		固定值,
		// Token: 0x04012061 RID: 73825
		表达式,
		// Token: 0x04012062 RID: 73826
		技能目标位置,
		// Token: 0x04012063 RID: 73827
		使用者位置,
		// Token: 0x04012064 RID: 73828
		使用者朝技能目标标准向量,
		// Token: 0x04012065 RID: 73829
		使用者朝技能目标水平标准向量,
		// Token: 0x04012066 RID: 73830
		使用者前向量,
		// Token: 0x04012067 RID: 73831
		使用者右向量,
		// Token: 0x04012068 RID: 73832
		使用者上向量,
		// Token: 0x04012069 RID: 73833
		技能目标前向量,
		// Token: 0x0401206A RID: 73834
		技能目标右向量,
		// Token: 0x0401206B RID: 73835
		技能目标上向量,
		// Token: 0x0401206C RID: 73836
		ECustomValueSourceVector_MAX
	}
}
