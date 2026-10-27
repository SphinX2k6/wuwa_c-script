using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006340 RID: 25408
	public enum ICharacterLookAtData_Union : byte
	{
		// Token: 0x04010907 RID: 67847
		NONE,
		// Token: 0x04010908 RID: 67848
		ICharacterLookAtData,
		// Token: 0x04010909 RID: 67849
		ICharacterLookAtEmptyData,
		// Token: 0x0401090A RID: 67850
		ICharacterLookAtEntityData,
		// Token: 0x0401090B RID: 67851
		ICharacterLookAtPositionData,
		// Token: 0x0401090C RID: 67852
		ICharacterLookAtPlayerData,
		// Token: 0x0401090D RID: 67853
		ICharacterLookAtUnlockData
	}
}
