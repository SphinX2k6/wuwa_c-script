using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020041A7 RID: 16807
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/EAnimalEcologicalState.EAnimalEcologicalState")]
	public enum EAnimalEcologicalState : byte
	{
		// Token: 0x04016CCC RID: 93388
		None,
		// Token: 0x04016CCD RID: 93389
		空闲,
		// Token: 0x04016CCE RID: 93390
		警觉,
		// Token: 0x04016CCF RID: 93391
		受击,
		// Token: 0x04016CD0 RID: 93392
		起飞,
		// Token: 0x04016CD1 RID: 93393
		交互,
		// Token: 0x04016CD2 RID: 93394
		系统UI,
		// Token: 0x04016CD3 RID: 93395
		EAnimalEcologicalState_MAX
	}
}
