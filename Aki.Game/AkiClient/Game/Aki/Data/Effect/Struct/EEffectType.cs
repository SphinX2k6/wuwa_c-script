using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003F99 RID: 16281
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/EEffectType.EEffectType")]
	public enum EEffectType : byte
	{
		// Token: 0x04015564 RID: 87396
		Fight,
		// Token: 0x04015565 RID: 87397
		UiScene3D,
		// Token: 0x04015566 RID: 87398
		UI,
		// Token: 0x04015567 RID: 87399
		Scene,
		// Token: 0x04015568 RID: 87400
		EEffectType_MAX
	}
}
