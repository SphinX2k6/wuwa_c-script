using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E70 RID: 32368
	public enum TChangeEntityState : byte
	{
		// Token: 0x0401367B RID: 79483
		NONE,
		// Token: 0x0401367C RID: 79484
		IChangeEntityStateBatchDirectly,
		// Token: 0x0401367D RID: 79485
		IChangeEntityStateDirectly,
		// Token: 0x0401367E RID: 79486
		IChangeEntityStateLoop
	}
}
