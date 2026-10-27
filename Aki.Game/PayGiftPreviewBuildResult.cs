using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02002363 RID: 9059
[RequiredMember]
public class PayGiftPreviewBuildResult
{
	// Token: 0x06012105 RID: 73989 RVA: 0x0046F458 File Offset: 0x0046D658
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PayGiftPreviewBuildResult()
	{
	}

	// Token: 0x040088BB RID: 35003
	[Nullable(1)]
	[RequiredMember]
	public List<RewardItemData> PreviewItems;
}
