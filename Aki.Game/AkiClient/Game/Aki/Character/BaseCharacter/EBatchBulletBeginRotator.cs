using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004292 RID: 17042
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletBeginRotator.EBatchBulletBeginRotator")]
	public enum EBatchBulletBeginRotator : byte
	{
		// Token: 0x040172A3 RID: 94883
		读取子弹表,
		// Token: 0x040172A4 RID: 94884
		切线方向,
		// Token: 0x040172A5 RID: 94885
		法线方向,
		// Token: 0x040172A6 RID: 94886
		EBatchBulletBeginRotator_MAX
	}
}
