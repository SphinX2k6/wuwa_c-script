using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001694 RID: 5780
	public enum AccessRangeResultType
	{
		// Token: 0x0400C50A RID: 50442
		[OriginalName("Trigger")]
		Trigger,
		// Token: 0x0400C50B RID: 50443
		[OriginalName("Trample")]
		Trample,
		// Token: 0x0400C50C RID: 50444
		[OriginalName("DynamicPortal")]
		DynamicPortal,
		// Token: 0x0400C50D RID: 50445
		[OriginalName("EffectArea")]
		EffectArea,
		// Token: 0x0400C50E RID: 50446
		[OriginalName("AirPassage")]
		AirPassage,
		// Token: 0x0400C50F RID: 50447
		[OriginalName("Range")]
		Range,
		// Token: 0x0400C510 RID: 50448
		[OriginalName("GravityFlip")]
		GravityFlip,
		// Token: 0x0400C511 RID: 50449
		[OriginalName("RollBlock")]
		RollBlock
	}
}
