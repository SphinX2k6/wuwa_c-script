using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001848 RID: 6216
[RequiredMember]
public class PayGiftPreviewBuildResult
{
	// Token: 0x0600F5B5 RID: 62901 RVA: 0x0047C580 File Offset: 0x0047A780
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PayGiftPreviewBuildResult()
	{
	}

	// Token: 0x04008A00 RID: 35328
	[Nullable(1)]
	[RequiredMember]
	public List<RewardItemData> PreviewItems;
}
