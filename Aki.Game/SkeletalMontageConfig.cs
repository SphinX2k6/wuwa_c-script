using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using UnrealEngine;

// Token: 0x02002A03 RID: 10755
[NullableContext(1)]
[Nullable(0)]
public class SkeletalMontageConfig
{
	// Token: 0x0601B049 RID: 110665 RVA: 0x00848DAC File Offset: 0x00846FAC
	public SkeletalMontageConfig(SSceneInteractionMontage ueConfig, int pendingFrameCount = 0, bool pendingCompHiddenInGame = false, EVisibilityBasedAnimTickOption pendingCompVisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered)
	{
		this.UeConfig = ueConfig;
		this.PendingFrameCount = pendingFrameCount;
		this.PendingCompHiddenInGame = pendingCompHiddenInGame;
		this.PendingCompVisibilityBasedAnimTickOption = pendingCompVisibilityBasedAnimTickOption;
	}

	// Token: 0x0601B04A RID: 110666 RVA: 0x00848DD1 File Offset: 0x00846FD1
	public bool IsPendingApplyProps()
	{
		return this.PendingFrameCount > 0;
	}

	// Token: 0x0400EB08 RID: 60168
	public SSceneInteractionMontage UeConfig;

	// Token: 0x0400EB09 RID: 60169
	public int PendingFrameCount;

	// Token: 0x0400EB0A RID: 60170
	public bool PendingCompHiddenInGame;

	// Token: 0x0400EB0B RID: 60171
	public EVisibilityBasedAnimTickOption PendingCompVisibilityBasedAnimTickOption;
}
