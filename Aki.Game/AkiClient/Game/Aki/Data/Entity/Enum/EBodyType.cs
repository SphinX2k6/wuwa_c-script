using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Entity.Enum
{
	// Token: 0x02003225 RID: 12837
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Enum/EBodyType.EBodyType")]
	public enum EBodyType : byte
	{
		// Token: 0x04011399 RID: 70553
		None,
		// Token: 0x0401139A RID: 70554
		MaleS,
		// Token: 0x0401139B RID: 70555
		MaleM,
		// Token: 0x0401139C RID: 70556
		MaleXL,
		// Token: 0x0401139D RID: 70557
		FemaleS,
		// Token: 0x0401139E RID: 70558
		FemaleMS,
		// Token: 0x0401139F RID: 70559
		FemaleM,
		// Token: 0x040113A0 RID: 70560
		FemaleXL,
		// Token: 0x040113A1 RID: 70561
		ShopHand,
		// Token: 0x040113A2 RID: 70562
		ShopStore,
		// Token: 0x040113A3 RID: 70563
		ShopDoll,
		// Token: 0x040113A4 RID: 70564
		ShopPhonograph,
		// Token: 0x040113A5 RID: 70565
		ShopPicture,
		// Token: 0x040113A6 RID: 70566
		EBodyType_MAX
	}
}
