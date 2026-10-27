using System;
using System.Runtime.CompilerServices;

// Token: 0x02002982 RID: 10626
[RequiredMember]
public class ShipTowerTeamTab
{
	// Token: 0x06016035 RID: 90165 RVA: 0x0058F065 File Offset: 0x0058D265
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShipTowerTeamTab()
	{
	}

	// Token: 0x0400A3BE RID: 41918
	[RequiredMember]
	public EShipTowerTeamTabType TabType;

	// Token: 0x0400A3BF RID: 41919
	[Nullable(1)]
	[RequiredMember]
	public string Title;
}
