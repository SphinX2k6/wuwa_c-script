using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F0 RID: 13040
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletMoveStartMode.EBatchBulletMoveStartMode")]
	public enum EBatchBulletMoveStartMode : byte
	{
		// Token: 0x04011FB0 RID: 73648
		每个生成就移动,
		// Token: 0x04011FB1 RID: 73649
		所有生成才移动,
		// Token: 0x04011FB2 RID: 73650
		EBatchBulletMoveStartMode_MAX
	}
}
