using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F1 RID: 13041
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBatchBulletPosition.EBatchBulletPosition")]
	public enum EBatchBulletPosition : byte
	{
		// Token: 0x04011FB4 RID: 73652
		DotMatrix,
		// Token: 0x04011FB5 RID: 73653
		Circle,
		// Token: 0x04011FB6 RID: 73654
		Spline,
		// Token: 0x04011FB7 RID: 73655
		EBatchBulletPosition_MAX
	}
}
