using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007638 RID: 30264
	public enum TActorTurnToData : byte
	{
		// Token: 0x040125C7 RID: 75207
		NONE,
		// Token: 0x040125C8 RID: 75208
		IActorTurnToEmptyData,
		// Token: 0x040125C9 RID: 75209
		IActorTurnToEntityData,
		// Token: 0x040125CA RID: 75210
		IActorTurnToPlayerData,
		// Token: 0x040125CB RID: 75211
		IActorTurnToPositionData,
		// Token: 0x040125CC RID: 75212
		IActorTurnToTalkerData
	}
}
