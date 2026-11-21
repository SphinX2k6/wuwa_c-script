using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D0 RID: 5584
	public enum BtType
	{
		// Token: 0x0400AA83 RID: 43651
		[OriginalName("BtTypeInvalid")]
		Invalid,
		// Token: 0x0400AA84 RID: 43652
		[OriginalName("BtTypeQuest")]
		Quest,
		// Token: 0x0400AA85 RID: 43653
		[OriginalName("BtTypeLevelPlay")]
		LevelPlay,
		// Token: 0x0400AA86 RID: 43654
		[OriginalName("BtTypeInst")]
		Inst,
		// Token: 0x0400AA87 RID: 43655
		[OriginalName("BtTypeInstDecision")]
		InstDecision,
		// Token: 0x0400AA88 RID: 43656
		[OriginalName("BtTypeRecall")]
		Recall
	}
}
