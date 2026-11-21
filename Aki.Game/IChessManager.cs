using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000682 RID: 1666
[NullableContext(1)]
public interface IChessManager
{
	// Token: 0x06004D07 RID: 19719
	ChessboardPoint CreateChessboardPoint();

	// Token: 0x06004D08 RID: 19720
	ChessItem CreateChessItem();

	// Token: 0x06004D09 RID: 19721
	[NullableContext(2)]
	IChessAgent GetChessAgent(EChessAgentType type, EntityHandle entityHandle = null);

	// Token: 0x06004D0A RID: 19722
	void BatchTeleportItemsToPointSorted(List<IChessTransmitData> transmitDataList);
}
