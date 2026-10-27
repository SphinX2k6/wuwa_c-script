using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020011CE RID: 4558
[NullableContext(1)]
public interface IChessManager
{
	// Token: 0x06007970 RID: 31088
	ChessboardPoint CreateChessboardPoint();

	// Token: 0x06007971 RID: 31089
	ChessItem CreateChessItem();

	// Token: 0x06007972 RID: 31090
	[NullableContext(2)]
	IChessAgent GetChessAgent(EChessAgentType type, EntityHandle entityHandle = null);

	// Token: 0x06007973 RID: 31091
	void BatchTeleportItemsToPointSorted(List<IChessTransmitData> transmitDataList);
}
