using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020032C2 RID: 12994
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/EAnimalEcologicalState.EAnimalEcologicalState")]
	public enum EAnimalEcologicalState : byte
	{
		// Token: 0x04011D1A RID: 72986
		None,
		// Token: 0x04011D1B RID: 72987
		空闲,
		// Token: 0x04011D1C RID: 72988
		警觉,
		// Token: 0x04011D1D RID: 72989
		受击,
		// Token: 0x04011D1E RID: 72990
		起飞,
		// Token: 0x04011D1F RID: 72991
		交互,
		// Token: 0x04011D20 RID: 72992
		系统UI,
		// Token: 0x04011D21 RID: 72993
		EAnimalEcologicalState_MAX
	}
}
