using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200297E RID: 10622
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerScoreInfoData
{
	// Token: 0x06016033 RID: 90163 RVA: 0x0058F055 File Offset: 0x0058D255
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerScoreInfoData()
	{
	}

	// Token: 0x0400A3AF RID: 41903
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3B0 RID: 41904
	[RequiredMember]
	public List<ShipTowerScoreTargetData> TargetList;
}
