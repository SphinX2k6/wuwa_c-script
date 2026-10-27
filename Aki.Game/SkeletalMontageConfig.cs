using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using UnrealEngine;

// Token: 0x0200348F RID: 13455
[NullableContext(1)]
[Nullable(0)]
public class SkeletalMontageConfig
{
	// Token: 0x0601D343 RID: 119619 RVA: 0x00821B10 File Offset: 0x0081FD10
	public SkeletalMontageConfig(SSceneInteractionMontage ueConfig, int pendingFrameCount = 0, bool pendingCompHiddenInGame = false, EVisibilityBasedAnimTickOption pendingCompVisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered)
	{
		this.UeConfig = ueConfig;
		this.PendingFrameCount = pendingFrameCount;
		this.PendingCompHiddenInGame = pendingCompHiddenInGame;
		this.PendingCompVisibilityBasedAnimTickOption = pendingCompVisibilityBasedAnimTickOption;
	}

	// Token: 0x0601D344 RID: 119620 RVA: 0x00821B35 File Offset: 0x0081FD35
	public bool IsPendingApplyProps()
	{
		return this.PendingFrameCount > 0;
	}

	// Token: 0x0400E652 RID: 58962
	public SSceneInteractionMontage UeConfig;

	// Token: 0x0400E653 RID: 58963
	public int PendingFrameCount;

	// Token: 0x0400E654 RID: 58964
	public bool PendingCompHiddenInGame;

	// Token: 0x0400E655 RID: 58965
	public EVisibilityBasedAnimTickOption PendingCompVisibilityBasedAnimTickOption;
}
