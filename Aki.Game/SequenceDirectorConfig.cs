using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using UnrealEngine;

// Token: 0x02002A02 RID: 10754
[NullableContext(1)]
[Nullable(0)]
public class SequenceDirectorConfig
{
	// Token: 0x0601B044 RID: 110660 RVA: 0x00848D30 File Offset: 0x00846F30
	public SequenceDirectorConfig(SSceneInteractionSequence ueConfig, bool isLoopOverride = false, float playRateOverride = 0f, bool reverseOverride = false)
	{
		this.UeConfig = ueConfig;
		this.IsLoopOverride = ((!isLoopOverride) ? ueConfig.IsLoop : isLoopOverride);
		this.PlayRateOverride = ((playRateOverride == 0f) ? ueConfig.PlayRate : playRateOverride);
		this.ReverseOverride = ((!reverseOverride) ? ueConfig.Reverse : reverseOverride);
	}

	// Token: 0x17002C13 RID: 11283
	// (get) Token: 0x0601B045 RID: 110661 RVA: 0x00848D87 File Offset: 0x00846F87
	public bool IsLoop
	{
		get
		{
			return this.IsLoopOverride;
		}
	}

	// Token: 0x17002C14 RID: 11284
	// (get) Token: 0x0601B046 RID: 110662 RVA: 0x00848D8F File Offset: 0x00846F8F
	public float PlayRate
	{
		get
		{
			return this.PlayRateOverride;
		}
	}

	// Token: 0x17002C15 RID: 11285
	// (get) Token: 0x0601B047 RID: 110663 RVA: 0x00848D97 File Offset: 0x00846F97
	public bool Reverse
	{
		get
		{
			return this.ReverseOverride;
		}
	}

	// Token: 0x17002C16 RID: 11286
	// (get) Token: 0x0601B048 RID: 110664 RVA: 0x00848D9F File Offset: 0x00846F9F
	[Nullable(2)]
	public ULevelSequence Sequence
	{
		[NullableContext(2)]
		get
		{
			return this.UeConfig.Sequence;
		}
	}

	// Token: 0x0400EB04 RID: 60164
	public SSceneInteractionSequence UeConfig;

	// Token: 0x0400EB05 RID: 60165
	public bool IsLoopOverride;

	// Token: 0x0400EB06 RID: 60166
	public float PlayRateOverride;

	// Token: 0x0400EB07 RID: 60167
	public bool ReverseOverride;
}
