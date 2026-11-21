using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006967 RID: 26983
	public enum IChangeEntityState_Union : byte
	{
		// Token: 0x040116C2 RID: 71362
		NONE,
		// Token: 0x040116C3 RID: 71363
		IChangeEntityState,
		// Token: 0x040116C4 RID: 71364
		IChangeEntityStateDirectly,
		// Token: 0x040116C5 RID: 71365
		IChangeEntityStateBatchDirectly,
		// Token: 0x040116C6 RID: 71366
		IChangeEntityStateLoop
	}
}
