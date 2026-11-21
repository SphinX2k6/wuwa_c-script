using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000A16 RID: 2582
[RequiredMember]
public class VersionPreheatQuestInfoCache
{
	// Token: 0x060070B8 RID: 28856 RVA: 0x00228C92 File Offset: 0x00226E92
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestInfoCache()
	{
	}

	// Token: 0x04004542 RID: 17730
	[Nullable(1)]
	[RequiredMember]
	public PreheatSignNodeInfo Meta;

	// Token: 0x04004543 RID: 17731
	public int Id;

	// Token: 0x04004544 RID: 17732
	public long UnlockTimestamp;

	// Token: 0x04004545 RID: 17733
	public bool Rewarded;
}
