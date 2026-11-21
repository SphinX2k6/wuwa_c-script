using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F1A RID: 7962
public class ShipTowerBuffViewParams
{
	// Token: 0x0400A88F RID: 43151
	public int? BuffId;

	// Token: 0x0400A890 RID: 43152
	public int? StageId;

	// Token: 0x0400A891 RID: 43153
	public EShipTowerBuffOperationType? OperationType;

	// Token: 0x0400A892 RID: 43154
	[Nullable(2)]
	public ShipTowerTeamData TeamData;

	// Token: 0x0400A893 RID: 43155
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public Action<ShipTowerBuffData, ShipTowerTeamData> OnUseBuff;
}
