using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FE RID: 24830
	public enum IActorTurnToData_Union : byte
	{
		// Token: 0x040104C4 RID: 66756
		NONE,
		// Token: 0x040104C5 RID: 66757
		IActorTurnToData,
		// Token: 0x040104C6 RID: 66758
		IActorTurnToTalkerData,
		// Token: 0x040104C7 RID: 66759
		IActorTurnToEmptyData,
		// Token: 0x040104C8 RID: 66760
		IActorTurnToEntityData,
		// Token: 0x040104C9 RID: 66761
		IActorTurnToPositionData,
		// Token: 0x040104CA RID: 66762
		IActorTurnToPlayerData
	}
}
