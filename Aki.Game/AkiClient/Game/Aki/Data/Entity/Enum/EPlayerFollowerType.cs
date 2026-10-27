using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003F97 RID: 16279
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EPlayerFollowerType.EPlayerFollowerType")]
	public enum EPlayerFollowerType : byte
	{
		// Token: 0x04015559 RID: 87385
		Common,
		// Token: 0x0401555A RID: 87386
		SpecialItem,
		// Token: 0x0401555B RID: 87387
		LevelPlay,
		// Token: 0x0401555C RID: 87388
		Motor,
		// Token: 0x0401555D RID: 87389
		EPlayerFollowerType_MAX
	}
}
