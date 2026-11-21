using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001EF9 RID: 7929
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerScoreInfoData
{
	// Token: 0x06013A39 RID: 80441 RVA: 0x005BA019 File Offset: 0x005B8219
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreInfoData()
	{
	}

	// Token: 0x0400A799 RID: 42905
	[RequiredMember]
	public string Title;

	// Token: 0x0400A79A RID: 42906
	[RequiredMember]
	public List<ShipTowerScoreTargetData> TargetList;
}
