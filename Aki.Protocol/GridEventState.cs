using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001642 RID: 5698
	public enum GridEventState
	{
		// Token: 0x0400C0B3 RID: 49331
		[OriginalName("UnTrigger")]
		UnTrigger,
		// Token: 0x0400C0B4 RID: 49332
		[OriginalName("PreBeginPloting")]
		PreBeginPloting,
		// Token: 0x0400C0B5 RID: 49333
		[OriginalName("BeginPloting")]
		BeginPloting,
		// Token: 0x0400C0B6 RID: 49334
		[OriginalName("PreBeginPlotEffecting")]
		PreBeginPlotEffecting,
		// Token: 0x0400C0B7 RID: 49335
		[OriginalName("BeginPlotEffecting")]
		BeginPlotEffecting,
		// Token: 0x0400C0B8 RID: 49336
		[OriginalName("PreEndPloting")]
		PreEndPloting,
		// Token: 0x0400C0B9 RID: 49337
		[OriginalName("EndPloting")]
		EndPloting,
		// Token: 0x0400C0BA RID: 49338
		[OriginalName("PreEndPlotEffecting")]
		PreEndPlotEffecting,
		// Token: 0x0400C0BB RID: 49339
		[OriginalName("EndPlotEffecting")]
		EndPlotEffecting,
		// Token: 0x0400C0BC RID: 49340
		[OriginalName("PreTakeGrid")]
		PreTakeGrid,
		// Token: 0x0400C0BD RID: 49341
		[OriginalName("TakeGrid")]
		TakeGrid,
		// Token: 0x0400C0BE RID: 49342
		[OriginalName("PreFinishAward")]
		PreFinishAward,
		// Token: 0x0400C0BF RID: 49343
		[OriginalName("FinishAward")]
		FinishAward,
		// Token: 0x0400C0C0 RID: 49344
		[OriginalName("End")]
		End
	}
}
