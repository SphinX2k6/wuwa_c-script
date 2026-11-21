using System;
using System.Runtime.CompilerServices;

// Token: 0x02001246 RID: 4678
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class IOccupationInfo
{
	// Token: 0x0600B96B RID: 47467 RVA: 0x0036BE93 File Offset: 0x0036A093
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public IOccupationInfo()
	{
	}

	// Token: 0x04006AF3 RID: 27379
	[RequiredMember]
	public string ResourceName;

	// Token: 0x04006AF4 RID: 27380
	[RequiredMember]
	public string QuestName;

	// Token: 0x04006AF5 RID: 27381
	[RequiredMember]
	public long TreeIncId;
}
