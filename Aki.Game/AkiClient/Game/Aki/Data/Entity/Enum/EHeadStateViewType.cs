using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003F95 RID: 16277
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EHeadStateViewType.EHeadStateViewType")]
	public enum EHeadStateViewType : byte
	{
		// Token: 0x0401554A RID: 87370
		None,
		// Token: 0x0401554B RID: 87371
		Common,
		// Token: 0x0401554C RID: 87372
		Elite,
		// Token: 0x0401554D RID: 87373
		NPC,
		// Token: 0x0401554E RID: 87374
		MingSuTi,
		// Token: 0x0401554F RID: 87375
		Guardian,
		// Token: 0x04015550 RID: 87376
		Durability,
		// Token: 0x04015551 RID: 87377
		DurabilityDamageBreakable,
		// Token: 0x04015552 RID: 87378
		DurabilityDamageUnbreakable,
		// Token: 0x04015553 RID: 87379
		EHeadStateViewType_MAX
	}
}
