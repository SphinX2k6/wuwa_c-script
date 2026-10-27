using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A3 RID: 17059
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharViewDirectionState.ECharViewDirectionState")]
	public enum ECharViewDirectionState : byte
	{
		// Token: 0x0401732E RID: 95022
		注视方向,
		// Token: 0x0401732F RID: 95023
		瞄准方向,
		// Token: 0x04017330 RID: 95024
		面朝方向,
		// Token: 0x04017331 RID: 95025
		ECharViewDirectionState_MAX
	}
}
