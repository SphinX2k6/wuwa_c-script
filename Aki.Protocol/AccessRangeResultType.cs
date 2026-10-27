using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001621 RID: 5665
	public enum AccessRangeResultType
	{
		// Token: 0x0400C010 RID: 49168
		[OriginalName("Trigger")]
		Trigger,
		// Token: 0x0400C011 RID: 49169
		[OriginalName("Trample")]
		Trample,
		// Token: 0x0400C012 RID: 49170
		[OriginalName("DynamicPortal")]
		DynamicPortal,
		// Token: 0x0400C013 RID: 49171
		[OriginalName("EffectArea")]
		EffectArea,
		// Token: 0x0400C014 RID: 49172
		[OriginalName("AirPassage")]
		AirPassage,
		// Token: 0x0400C015 RID: 49173
		[OriginalName("Range")]
		Range,
		// Token: 0x0400C016 RID: 49174
		[OriginalName("GravityFlip")]
		GravityFlip,
		// Token: 0x0400C017 RID: 49175
		[OriginalName("RollBlock")]
		RollBlock
	}
}
