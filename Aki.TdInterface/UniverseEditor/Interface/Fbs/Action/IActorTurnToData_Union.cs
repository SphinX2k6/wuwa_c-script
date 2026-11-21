using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006760 RID: 26464
	public enum IActorTurnToData_Union : byte
	{
		// Token: 0x040112C8 RID: 70344
		NONE,
		// Token: 0x040112C9 RID: 70345
		IActorTurnToData,
		// Token: 0x040112CA RID: 70346
		IActorTurnToTalkerData,
		// Token: 0x040112CB RID: 70347
		IActorTurnToEmptyData,
		// Token: 0x040112CC RID: 70348
		IActorTurnToEntityData,
		// Token: 0x040112CD RID: 70349
		IActorTurnToPositionData,
		// Token: 0x040112CE RID: 70350
		IActorTurnToPlayerData
	}
}
