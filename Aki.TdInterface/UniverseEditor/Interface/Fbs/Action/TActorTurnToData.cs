using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E46 RID: 32326
	public enum TActorTurnToData : byte
	{
		// Token: 0x04013611 RID: 79377
		NONE,
		// Token: 0x04013612 RID: 79378
		IActorTurnToEmptyData,
		// Token: 0x04013613 RID: 79379
		IActorTurnToEntityData,
		// Token: 0x04013614 RID: 79380
		IActorTurnToPlayerData,
		// Token: 0x04013615 RID: 79381
		IActorTurnToPositionData,
		// Token: 0x04013616 RID: 79382
		IActorTurnToTalkerData
	}
}
