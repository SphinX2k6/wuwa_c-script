using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A1 RID: 17057
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharParentMoveState.ECharParentMoveState")]
	public enum ECharParentMoveState : byte
	{
		// Token: 0x04017307 RID: 94983
		地面状态,
		// Token: 0x04017308 RID: 94984
		攀爬状态,
		// Token: 0x04017309 RID: 94985
		空中状态,
		// Token: 0x0401730A RID: 94986
		水中状态,
		// Token: 0x0401730B RID: 94987
		滑雪状态,
		// Token: 0x0401730C RID: 94988
		载具状态,
		// Token: 0x0401730D RID: 94989
		ECharParentMoveState_MAX
	}
}
