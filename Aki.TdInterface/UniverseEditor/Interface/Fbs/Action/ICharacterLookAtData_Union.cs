using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B1 RID: 27057
	public enum ICharacterLookAtData_Union : byte
	{
		// Token: 0x0401171C RID: 71452
		NONE,
		// Token: 0x0401171D RID: 71453
		ICharacterLookAtData,
		// Token: 0x0401171E RID: 71454
		ICharacterLookAtEmptyData,
		// Token: 0x0401171F RID: 71455
		ICharacterLookAtEntityData,
		// Token: 0x04011720 RID: 71456
		ICharacterLookAtPositionData,
		// Token: 0x04011721 RID: 71457
		ICharacterLookAtPlayerData,
		// Token: 0x04011722 RID: 71458
		ICharacterLookAtUnlockData
	}
}
