using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using UnrealEngine;

// Token: 0x0200348E RID: 13454
[NullableContext(1)]
[Nullable(0)]
public class SequenceDirectorConfig
{
	// Token: 0x0601D33E RID: 119614 RVA: 0x00821A94 File Offset: 0x0081FC94
	public SequenceDirectorConfig(SSceneInteractionSequence ueConfig, bool isLoopOverride = false, float playRateOverride = 0f, bool reverseOverride = false)
	{
		this.UeConfig = ueConfig;
		this.IsLoopOverride = ((!isLoopOverride) ? ueConfig.IsLoop : isLoopOverride);
		this.PlayRateOverride = ((playRateOverride == 0f) ? ueConfig.PlayRate : playRateOverride);
		this.ReverseOverride = ((!reverseOverride) ? ueConfig.Reverse : reverseOverride);
	}

	// Token: 0x17002876 RID: 10358
	// (get) Token: 0x0601D33F RID: 119615 RVA: 0x00821AEB File Offset: 0x0081FCEB
	public bool IsLoop
	{
		get
		{
			return this.IsLoopOverride;
		}
	}

	// Token: 0x17002877 RID: 10359
	// (get) Token: 0x0601D340 RID: 119616 RVA: 0x00821AF3 File Offset: 0x0081FCF3
	public float PlayRate
	{
		get
		{
			return this.PlayRateOverride;
		}
	}

	// Token: 0x17002878 RID: 10360
	// (get) Token: 0x0601D341 RID: 119617 RVA: 0x00821AFB File Offset: 0x0081FCFB
	public bool Reverse
	{
		get
		{
			return this.ReverseOverride;
		}
	}

	// Token: 0x17002879 RID: 10361
	// (get) Token: 0x0601D342 RID: 119618 RVA: 0x00821B03 File Offset: 0x0081FD03
	[Nullable(2)]
	public ULevelSequence Sequence
	{
		[NullableContext(2)]
		get
		{
			return this.UeConfig.Sequence;
		}
	}

	// Token: 0x0400E64E RID: 58958
	public SSceneInteractionSequence UeConfig;

	// Token: 0x0400E64F RID: 58959
	public bool IsLoopOverride;

	// Token: 0x0400E650 RID: 58960
	public float PlayRateOverride;

	// Token: 0x0400E651 RID: 58961
	public bool ReverseOverride;
}
