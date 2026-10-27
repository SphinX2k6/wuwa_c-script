using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D7 RID: 24791
	public enum IActorLookAtData_Union : byte
	{
		// Token: 0x04010487 RID: 66695
		NONE,
		// Token: 0x04010488 RID: 66696
		IActorLookAtData,
		// Token: 0x04010489 RID: 66697
		IActorLookAtLockable,
		// Token: 0x0401048A RID: 66698
		IActorLookAtTalkerData,
		// Token: 0x0401048B RID: 66699
		IActorLookAtEmptyData,
		// Token: 0x0401048C RID: 66700
		IActorLookAtEntityData,
		// Token: 0x0401048D RID: 66701
		IActorLookAtPositionData,
		// Token: 0x0401048E RID: 66702
		IActorLookAtPlayerData,
		// Token: 0x0401048F RID: 66703
		IActorLookAtOtherActor,
		// Token: 0x04010490 RID: 66704
		IActorLookAtUnLock
	}
}
