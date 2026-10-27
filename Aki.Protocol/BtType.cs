using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155A RID: 5466
	public enum BtType
	{
		// Token: 0x0400A5F6 RID: 42486
		[OriginalName("BtTypeInvalid")]
		Invalid,
		// Token: 0x0400A5F7 RID: 42487
		[OriginalName("BtTypeQuest")]
		Quest,
		// Token: 0x0400A5F8 RID: 42488
		[OriginalName("BtTypeLevelPlay")]
		LevelPlay,
		// Token: 0x0400A5F9 RID: 42489
		[OriginalName("BtTypeInst")]
		Inst,
		// Token: 0x0400A5FA RID: 42490
		[OriginalName("BtTypeInstDecision")]
		InstDecision,
		// Token: 0x0400A5FB RID: 42491
		[OriginalName("BtTypeRecall")]
		Recall
	}
}
