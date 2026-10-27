using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004289 RID: 17033
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAimViewState.EAimViewState")]
	public enum EAimViewState : byte
	{
		// Token: 0x04017271 RID: 94833
		瞄准154身高,
		// Token: 0x04017272 RID: 94834
		瞄准180身高,
		// Token: 0x04017273 RID: 94835
		寂寞小姐身高,
		// Token: 0x04017274 RID: 94836
		露帕瞄准,
		// Token: 0x04017275 RID: 94837
		Rebecca瞄准,
		// Token: 0x04017276 RID: 94838
		EAimViewState_MAX
	}
}
