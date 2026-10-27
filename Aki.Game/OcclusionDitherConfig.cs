using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

// Token: 0x0200303F RID: 12351
public class OcclusionDitherConfig
{
	// Token: 0x0601A319 RID: 107289 RVA: 0x006E3A98 File Offset: 0x006E1C98
	[NullableContext(1)]
	public OcclusionDitherConfig(SOcclusionDitherConfig config)
	{
		this.IsEnableOcclusionDither = config.bEnableOcclusionDither;
		this.OcclusionDitherValue = config.OcclusionDitherValue;
		this.OcclusionDitherInterpSpeed = config.OcclusionDitherInterpSpeed;
		this.IgnoreOcclusionDitherTag = ((config.IgnoreOcclusionDitherTag.TagName == "None") ? null : new FGameplayTag?(config.IgnoreOcclusionDitherTag));
	}

	// Token: 0x0400C737 RID: 50999
	public bool IsEnableOcclusionDither;

	// Token: 0x0400C738 RID: 51000
	public float OcclusionDitherValue;

	// Token: 0x0400C739 RID: 51001
	public float OcclusionDitherInterpSpeed;

	// Token: 0x0400C73A RID: 51002
	public FGameplayTag? IgnoreOcclusionDitherTag;
}
