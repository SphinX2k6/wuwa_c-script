using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x020031B0 RID: 12720
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/ESimpleNpcWorldState.ESimpleNpcWorldState")]
	public enum ESimpleNpcWorldState : byte
	{
		// Token: 0x04010D78 RID: 68984
		DefaultState,
		// Token: 0x04010D79 RID: 68985
		FirstState,
		// Token: 0x04010D7A RID: 68986
		State,
		// Token: 0x04010D7B RID: 68987
		ESimpleNpcWorldState_MAX
	}
}
