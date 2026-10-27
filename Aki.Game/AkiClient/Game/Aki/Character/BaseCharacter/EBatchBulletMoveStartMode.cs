using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004293 RID: 17043
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletMoveStartMode.EBatchBulletMoveStartMode")]
	public enum EBatchBulletMoveStartMode : byte
	{
		// Token: 0x040172A8 RID: 94888
		每个生成就移动,
		// Token: 0x040172A9 RID: 94889
		所有生成才移动,
		// Token: 0x040172AA RID: 94890
		EBatchBulletMoveStartMode_MAX
	}
}
