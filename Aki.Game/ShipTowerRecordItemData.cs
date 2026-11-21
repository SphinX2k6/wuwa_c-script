using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F0A RID: 7946
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRecordItemData
{
	// Token: 0x06013A47 RID: 80455 RVA: 0x005BA089 File Offset: 0x005B8289
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRecordItemData()
	{
	}

	// Token: 0x0400A7DE RID: 42974
	[RequiredMember]
	public string Title;

	// Token: 0x0400A7DF RID: 42975
	[RequiredMember]
	public int Score;

	// Token: 0x0400A7E0 RID: 42976
	[RequiredMember]
	public int Wave;

	// Token: 0x0400A7E1 RID: 42977
	[RequiredMember]
	public List<ShipTowerMediumItemData> TeamList;

	// Token: 0x0400A7E2 RID: 42978
	[RequiredMember]
	public int BuffId;
}
