using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FE RID: 13054
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharViewDirectionState.ECharViewDirectionState")]
	public enum ECharViewDirectionState : byte
	{
		// Token: 0x0401202C RID: 73772
		注视方向,
		// Token: 0x0401202D RID: 73773
		瞄准方向,
		// Token: 0x0401202E RID: 73774
		面朝方向,
		// Token: 0x0401202F RID: 73775
		ECharViewDirectionState_MAX
	}
}
