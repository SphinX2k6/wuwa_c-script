using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x02003EEF RID: 16111
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/ESimpleNpcWorldState.ESimpleNpcWorldState")]
	public enum ESimpleNpcWorldState : byte
	{
		// Token: 0x04014DBF RID: 85439
		DefaultState,
		// Token: 0x04014DC0 RID: 85440
		FirstState,
		// Token: 0x04014DC1 RID: 85441
		State,
		// Token: 0x04014DC2 RID: 85442
		ESimpleNpcWorldState_MAX
	}
}
