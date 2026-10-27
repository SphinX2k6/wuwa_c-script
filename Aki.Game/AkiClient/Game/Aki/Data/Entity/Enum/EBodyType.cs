using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003F91 RID: 16273
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EBodyType.EBodyType")]
	public enum EBodyType : byte
	{
		// Token: 0x04015523 RID: 87331
		None,
		// Token: 0x04015524 RID: 87332
		MaleS,
		// Token: 0x04015525 RID: 87333
		MaleM,
		// Token: 0x04015526 RID: 87334
		MaleXL,
		// Token: 0x04015527 RID: 87335
		FemaleS,
		// Token: 0x04015528 RID: 87336
		FemaleMS,
		// Token: 0x04015529 RID: 87337
		FemaleM,
		// Token: 0x0401552A RID: 87338
		FemaleXL,
		// Token: 0x0401552B RID: 87339
		ShopHand,
		// Token: 0x0401552C RID: 87340
		ShopStore,
		// Token: 0x0401552D RID: 87341
		ShopDoll,
		// Token: 0x0401552E RID: 87342
		ShopPhonograph,
		// Token: 0x0401552F RID: 87343
		ShopPicture,
		// Token: 0x04015530 RID: 87344
		EBodyType_MAX
	}
}
