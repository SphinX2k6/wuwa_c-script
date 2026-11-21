using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass
{
	// Token: 0x02003069 RID: 12393
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/EBulletLogicStage.EBulletLogicStage")]
	public enum EBulletLogicStage : byte
	{
		// Token: 0x0400F802 RID: 63490
		OnBegin,
		// Token: 0x0400F803 RID: 63491
		OnHit,
		// Token: 0x0400F804 RID: 63492
		OnDestroy,
		// Token: 0x0400F805 RID: 63493
		OnRebound,
		// Token: 0x0400F806 RID: 63494
		OnSupport,
		// Token: 0x0400F807 RID: 63495
		ReplaceMove,
		// Token: 0x0400F808 RID: 63496
		OnHitBullet,
		// Token: 0x0400F809 RID: 63497
		OnBulletCollision,
		// Token: 0x0400F80A RID: 63498
		EBulletLogicStage_MAX
	}
}
