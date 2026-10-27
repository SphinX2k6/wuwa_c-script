using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200298F RID: 10639
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerRecordItemData
{
	// Token: 0x06016041 RID: 90177 RVA: 0x0058F0C5 File Offset: 0x0058D2C5
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerRecordItemData()
	{
	}

	// Token: 0x0400A3F4 RID: 41972
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3F5 RID: 41973
	[RequiredMember]
	public int Score;

	// Token: 0x0400A3F6 RID: 41974
	[RequiredMember]
	public int Wave;

	// Token: 0x0400A3F7 RID: 41975
	[RequiredMember]
	public List<ShipTowerMediumItemData> TeamList;

	// Token: 0x0400A3F8 RID: 41976
	[RequiredMember]
	public int BuffId;
}
