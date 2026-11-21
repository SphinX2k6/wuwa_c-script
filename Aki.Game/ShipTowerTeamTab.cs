using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EFD RID: 7933
[RequiredMember]
public class ShipTowerTeamTab
{
	// Token: 0x06013A3B RID: 80443 RVA: 0x005BA029 File Offset: 0x005B8229
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerTeamTab()
	{
	}

	// Token: 0x0400A7A8 RID: 42920
	[RequiredMember]
	public EShipTowerTeamTabType TabType;

	// Token: 0x0400A7A9 RID: 42921
	[Nullable(1)]
	[RequiredMember]
	public string Title;
}
