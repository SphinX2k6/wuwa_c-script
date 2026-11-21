using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001EF7 RID: 7927
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ShipTowerBuffQuality
{
	// Token: 0x06013A37 RID: 80439 RVA: 0x005BA009 File Offset: 0x005B8209
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerBuffQuality()
	{
	}

	// Token: 0x0400A792 RID: 42898
	[RequiredMember]
	public int Quality;

	// Token: 0x0400A793 RID: 42899
	[RequiredMember]
	public string Title;

	// Token: 0x0400A794 RID: 42900
	[RequiredMember]
	public List<ShipTowerBuffData> BuffList;
}
