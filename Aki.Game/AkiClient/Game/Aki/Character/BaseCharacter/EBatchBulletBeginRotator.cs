using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032EF RID: 13039
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletBeginRotator.EBatchBulletBeginRotator")]
	public enum EBatchBulletBeginRotator : byte
	{
		// Token: 0x04011FAB RID: 73643
		读取子弹表,
		// Token: 0x04011FAC RID: 73644
		切线方向,
		// Token: 0x04011FAD RID: 73645
		法线方向,
		// Token: 0x04011FAE RID: 73646
		EBatchBulletBeginRotator_MAX
	}
}
