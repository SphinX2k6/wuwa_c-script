using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

// Token: 0x02002595 RID: 9621
public class OcclusionDitherConfig
{
	// Token: 0x06017C83 RID: 97411 RVA: 0x0070B620 File Offset: 0x00709820
	[NullableContext(1)]
	public OcclusionDitherConfig(SOcclusionDitherConfig config)
	{
		this.IsEnableOcclusionDither = config.bEnableOcclusionDither;
		this.OcclusionDitherValue = config.OcclusionDitherValue;
		this.OcclusionDitherInterpSpeed = config.OcclusionDitherInterpSpeed;
		this.IgnoreOcclusionDitherTag = ((config.IgnoreOcclusionDitherTag.TagName == "None") ? null : new FGameplayTag?(config.IgnoreOcclusionDitherTag));
	}

	// Token: 0x0400CB10 RID: 51984
	public bool IsEnableOcclusionDither;

	// Token: 0x0400CB11 RID: 51985
	public float OcclusionDitherValue;

	// Token: 0x0400CB12 RID: 51986
	public float OcclusionDitherInterpSpeed;

	// Token: 0x0400CB13 RID: 51987
	public FGameplayTag? IgnoreOcclusionDitherTag;
}
