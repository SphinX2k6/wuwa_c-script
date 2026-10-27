using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003F94 RID: 16276
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EEntityType.EEntityType")]
	public enum EEntityType : byte
	{
		// Token: 0x0401553B RID: 87355
		Player,
		// Token: 0x0401553C RID: 87356
		Npc,
		// Token: 0x0401553D RID: 87357
		Monster,
		// Token: 0x0401553E RID: 87358
		Spawner,
		// Token: 0x0401553F RID: 87359
		Building,
		// Token: 0x04015540 RID: 87360
		Gather,
		// Token: 0x04015541 RID: 87361
		Treasure,
		// Token: 0x04015542 RID: 87362
		Vision,
		// Token: 0x04015543 RID: 87363
		Animal,
		// Token: 0x04015544 RID: 87364
		ClientOnly,
		// Token: 0x04015545 RID: 87365
		Vehicle,
		// Token: 0x04015546 RID: 87366
		PlayerEntity,
		// Token: 0x04015547 RID: 87367
		SceneEntity,
		// Token: 0x04015548 RID: 87368
		EEntityType_MAX
	}
}
