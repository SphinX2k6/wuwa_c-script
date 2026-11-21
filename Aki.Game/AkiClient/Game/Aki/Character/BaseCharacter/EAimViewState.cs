using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032EA RID: 13034
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAimViewState.EAimViewState")]
	public enum EAimViewState : byte
	{
		// Token: 0x04011F8F RID: 73615
		瞄准154身高,
		// Token: 0x04011F90 RID: 73616
		瞄准180身高,
		// Token: 0x04011F91 RID: 73617
		寂寞小姐身高,
		// Token: 0x04011F92 RID: 73618
		露帕瞄准,
		// Token: 0x04011F93 RID: 73619
		Rebecca瞄准,
		// Token: 0x04011F94 RID: 73620
		EAimViewState_MAX
	}
}
