using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E43 RID: 32323
	public enum TActorLookAtData : byte
	{
		// Token: 0x04013606 RID: 79366
		NONE,
		// Token: 0x04013607 RID: 79367
		IActorLookAtEmptyData,
		// Token: 0x04013608 RID: 79368
		IActorLookAtEntityData,
		// Token: 0x04013609 RID: 79369
		IActorLookAtOtherActor,
		// Token: 0x0401360A RID: 79370
		IActorLookAtPlayerData,
		// Token: 0x0401360B RID: 79371
		IActorLookAtPositionData,
		// Token: 0x0401360C RID: 79372
		IActorLookAtTalkerData,
		// Token: 0x0401360D RID: 79373
		IActorLookAtUnLock
	}
}
