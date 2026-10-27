using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200155E RID: 5470
[RequiredMember]
public class VersionPreheatQuestInfoCache
{
	// Token: 0x06009CDA RID: 40154 RVA: 0x0021EEE2 File Offset: 0x0021D0E2
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestInfoCache()
	{
	}

	// Token: 0x0400449C RID: 17564
	[Nullable(1)]
	[RequiredMember]
	public PreheatSignNodeInfo Meta;

	// Token: 0x0400449D RID: 17565
	public int Id;

	// Token: 0x0400449E RID: 17566
	public long UnlockTimestamp;

	// Token: 0x0400449F RID: 17567
	public bool Rewarded;
}
