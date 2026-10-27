using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass
{
	// Token: 0x02003A1A RID: 14874
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/EBulletLogicStage.EBulletLogicStage")]
	public enum EBulletLogicStage : byte
	{
		// Token: 0x0400EF4C RID: 61260
		OnBegin,
		// Token: 0x0400EF4D RID: 61261
		OnHit,
		// Token: 0x0400EF4E RID: 61262
		OnDestroy,
		// Token: 0x0400EF4F RID: 61263
		OnRebound,
		// Token: 0x0400EF50 RID: 61264
		OnSupport,
		// Token: 0x0400EF51 RID: 61265
		ReplaceMove,
		// Token: 0x0400EF52 RID: 61266
		OnHitBullet,
		// Token: 0x0400EF53 RID: 61267
		OnBulletCollision,
		// Token: 0x0400EF54 RID: 61268
		EBulletLogicStage_MAX
	}
}
