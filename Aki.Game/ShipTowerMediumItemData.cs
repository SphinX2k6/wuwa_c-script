using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F0B RID: 7947
[RequiredMember]
public class ShipTowerMediumItemData
{
	// Token: 0x06013A48 RID: 80456 RVA: 0x005BA091 File Offset: 0x005B8291
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerMediumItemData()
	{
	}

	// Token: 0x0400A7E3 RID: 42979
	[RequiredMember]
	public int Id;

	// Token: 0x0400A7E4 RID: 42980
	[RequiredMember]
	public int Count;

	// Token: 0x0400A7E5 RID: 42981
	public bool? IsBuff;

	// Token: 0x0400A7E6 RID: 42982
	public int SkillBranchId;
}
