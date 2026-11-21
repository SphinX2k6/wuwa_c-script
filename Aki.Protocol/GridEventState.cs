using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B9 RID: 5817
	public enum GridEventState
	{
		// Token: 0x0400C5BE RID: 50622
		[OriginalName("UnTrigger")]
		UnTrigger,
		// Token: 0x0400C5BF RID: 50623
		[OriginalName("PreBeginPloting")]
		PreBeginPloting,
		// Token: 0x0400C5C0 RID: 50624
		[OriginalName("BeginPloting")]
		BeginPloting,
		// Token: 0x0400C5C1 RID: 50625
		[OriginalName("PreBeginPlotEffecting")]
		PreBeginPlotEffecting,
		// Token: 0x0400C5C2 RID: 50626
		[OriginalName("BeginPlotEffecting")]
		BeginPlotEffecting,
		// Token: 0x0400C5C3 RID: 50627
		[OriginalName("PreEndPloting")]
		PreEndPloting,
		// Token: 0x0400C5C4 RID: 50628
		[OriginalName("EndPloting")]
		EndPloting,
		// Token: 0x0400C5C5 RID: 50629
		[OriginalName("PreEndPlotEffecting")]
		PreEndPlotEffecting,
		// Token: 0x0400C5C6 RID: 50630
		[OriginalName("EndPlotEffecting")]
		EndPlotEffecting,
		// Token: 0x0400C5C7 RID: 50631
		[OriginalName("PreTakeGrid")]
		PreTakeGrid,
		// Token: 0x0400C5C8 RID: 50632
		[OriginalName("TakeGrid")]
		TakeGrid,
		// Token: 0x0400C5C9 RID: 50633
		[OriginalName("PreFinishAward")]
		PreFinishAward,
		// Token: 0x0400C5CA RID: 50634
		[OriginalName("FinishAward")]
		FinishAward,
		// Token: 0x0400C5CB RID: 50635
		[OriginalName("End")]
		End
	}
}
