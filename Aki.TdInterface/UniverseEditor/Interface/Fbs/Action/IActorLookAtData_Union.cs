using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006739 RID: 26425
	public enum IActorLookAtData_Union : byte
	{
		// Token: 0x0401128B RID: 70283
		NONE,
		// Token: 0x0401128C RID: 70284
		IActorLookAtData,
		// Token: 0x0401128D RID: 70285
		IActorLookAtLockable,
		// Token: 0x0401128E RID: 70286
		IActorLookAtTalkerData,
		// Token: 0x0401128F RID: 70287
		IActorLookAtEmptyData,
		// Token: 0x04011290 RID: 70288
		IActorLookAtEntityData,
		// Token: 0x04011291 RID: 70289
		IActorLookAtPositionData,
		// Token: 0x04011292 RID: 70290
		IActorLookAtPlayerData,
		// Token: 0x04011293 RID: 70291
		IActorLookAtOtherActor,
		// Token: 0x04011294 RID: 70292
		IActorLookAtUnLock
	}
}
