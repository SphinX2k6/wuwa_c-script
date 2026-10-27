using System;
using System.Runtime.CompilerServices;

// Token: 0x0200299F RID: 10655
public class ShipTowerBuffViewParams
{
	// Token: 0x0400A4A5 RID: 42149
	public int? BuffId;

	// Token: 0x0400A4A6 RID: 42150
	public int? StageId;

	// Token: 0x0400A4A7 RID: 42151
	public EShipTowerBuffOperationType? OperationType;

	// Token: 0x0400A4A8 RID: 42152
	[Nullable(2)]
	public ShipTowerTeamData TeamData;

	// Token: 0x0400A4A9 RID: 42153
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public Action<ShipTowerBuffData, ShipTowerTeamData> OnUseBuff;
}
