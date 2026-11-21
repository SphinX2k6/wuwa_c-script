using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003300 RID: 13056
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECommonAxis.ECommonAxis")]
	public enum ECommonAxis : byte
	{
		// Token: 0x04012038 RID: 73784
		X,
		// Token: 0x04012039 RID: 73785
		Y,
		// Token: 0x0401203A RID: 73786
		Z,
		// Token: 0x0401203B RID: 73787
		ECommonAxis_MAX
	}
}
