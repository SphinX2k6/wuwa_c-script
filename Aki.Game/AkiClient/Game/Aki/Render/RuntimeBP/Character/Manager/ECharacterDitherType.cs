using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager
{
	// Token: 0x0200313C RID: 12604
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/ECharacterDitherType.ECharacterDitherType")]
	public enum ECharacterDitherType : byte
	{
		// Token: 0x0401083B RID: 67643
		UnDefined,
		// Token: 0x0401083C RID: 67644
		Fight,
		// Token: 0x0401083D RID: 67645
		Sequence,
		// Token: 0x0401083E RID: 67646
		Temporary,
		// Token: 0x0401083F RID: 67647
		CanBePassedThrough,
		// Token: 0x04010840 RID: 67648
		ECharacterDitherType_MAX
	}
}
