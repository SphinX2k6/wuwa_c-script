using System;
using System.Runtime.CompilerServices;

// Token: 0x0200155F RID: 5471
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VersionPreheatQuestData
{
	// Token: 0x06009CDB RID: 40155 RVA: 0x0021EEEA File Offset: 0x0021D0EA
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VersionPreheatQuestData()
	{
	}

	// Token: 0x040044A0 RID: 17568
	public int Id;

	// Token: 0x040044A1 RID: 17569
	public EVersionPreheatQuestState State;

	// Token: 0x040044A2 RID: 17570
	[RequiredMember]
	public string NumberTextId;

	// Token: 0x040044A3 RID: 17571
	[RequiredMember]
	public string NumberTextArg;

	// Token: 0x040044A4 RID: 17572
	[RequiredMember]
	public string TitleTextId;

	// Token: 0x040044A5 RID: 17573
	public long UnlockTimestamp;
}
