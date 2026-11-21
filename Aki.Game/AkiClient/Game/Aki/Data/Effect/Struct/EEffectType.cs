using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003229 RID: 12841
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/EEffectType.EEffectType")]
	public enum EEffectType : byte
	{
		// Token: 0x040113B6 RID: 70582
		Fight,
		// Token: 0x040113B7 RID: 70583
		UiScene3D,
		// Token: 0x040113B8 RID: 70584
		UI,
		// Token: 0x040113B9 RID: 70585
		Scene,
		// Token: 0x040113BA RID: 70586
		EEffectType_MAX
	}
}
