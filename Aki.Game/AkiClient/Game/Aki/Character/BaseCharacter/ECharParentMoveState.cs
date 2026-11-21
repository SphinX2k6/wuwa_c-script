using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FC RID: 13052
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharParentMoveState.ECharParentMoveState")]
	public enum ECharParentMoveState : byte
	{
		// Token: 0x04012005 RID: 73733
		地面状态,
		// Token: 0x04012006 RID: 73734
		攀爬状态,
		// Token: 0x04012007 RID: 73735
		空中状态,
		// Token: 0x04012008 RID: 73736
		水中状态,
		// Token: 0x04012009 RID: 73737
		滑雪状态,
		// Token: 0x0401200A RID: 73738
		载具状态,
		// Token: 0x0401200B RID: 73739
		ECharParentMoveState_MAX
	}
}
