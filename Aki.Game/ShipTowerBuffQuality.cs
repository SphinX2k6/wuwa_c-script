using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200297C RID: 10620
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerBuffQuality
{
	// Token: 0x06016031 RID: 90161 RVA: 0x0058F045 File Offset: 0x0058D245
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerBuffQuality()
	{
	}

	// Token: 0x0400A3A8 RID: 41896
	[RequiredMember]
	public int Quality;

	// Token: 0x0400A3A9 RID: 41897
	[RequiredMember]
	public string Title;

	// Token: 0x0400A3AA RID: 41898
	[RequiredMember]
	public List<ShipTowerBuffData> BuffList;
}
