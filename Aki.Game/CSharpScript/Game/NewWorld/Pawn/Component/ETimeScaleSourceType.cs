using System;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061F0 RID: 25072
	public enum ETimeScaleSourceType
	{
		// Token: 0x0401FDEF RID: 130543
		DefaultTimeScale,
		// Token: 0x0401FDF0 RID: 130544
		MyBullet,
		// Token: 0x0401FDF1 RID: 130545
		OthersBullet,
		// Token: 0x0401FDF2 RID: 130546
		Counter,
		// Token: 0x0401FDF3 RID: 130547
		BeCountered,
		// Token: 0x0401FDF4 RID: 130548
		BattleSettlement,
		// Token: 0x0401FDF5 RID: 130549
		Buff,
		// Token: 0x0401FDF6 RID: 130550
		PanelQte,
		// Token: 0x0401FDF7 RID: 130551
		TimeStopMachine,
		// Token: 0x0401FDF8 RID: 130552
		InnerPauseLock,
		// Token: 0x0401FDF9 RID: 130553
		InnerNormalizeTimeScaleLock,
		// Token: 0x0401FDFA RID: 130554
		InnerDelayLock = 10,
		// Token: 0x0401FDFB RID: 130555
		InnerForceTimeScale,
		// Token: 0x0401FDFC RID: 130556
		Portal,
		// Token: 0x0401FDFD RID: 130557
		DeathEffect,
		// Token: 0x0401FDFE RID: 130558
		PhantomArenaBattle,
		// Token: 0x0401FDFF RID: 130559
		SelfCentered,
		// Token: 0x0401FE00 RID: 130560
		SelfBeHit,
		// Token: 0x0401FE01 RID: 130561
		DeadEyeMode,
		// Token: 0x0401FE02 RID: 130562
		ElementalField,
		// Token: 0x0401FE03 RID: 130563
		WithKscEntityUpdate,
		// Token: 0x0401FE04 RID: 130564
		MAX,
		// Token: 0x0401FE05 RID: 130565
		UiModel
	}
}
