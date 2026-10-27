using System;
using System.Runtime.CompilerServices;

// Token: 0x02002990 RID: 10640
[RequiredMember]
public class ShipTowerMediumItemData
{
	// Token: 0x06016042 RID: 90178 RVA: 0x0058F0CD File Offset: 0x0058D2CD
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMediumItemData()
	{
	}

	// Token: 0x0400A3F9 RID: 41977
	[RequiredMember]
	public int Id;

	// Token: 0x0400A3FA RID: 41978
	[RequiredMember]
	public int Count;

	// Token: 0x0400A3FB RID: 41979
	public bool? IsBuff;

	// Token: 0x0400A3FC RID: 41980
	public int SkillBranchId;
}
