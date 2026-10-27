using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F6 RID: 25334
	public enum IChangeEntityState_Union : byte
	{
		// Token: 0x040108AC RID: 67756
		NONE,
		// Token: 0x040108AD RID: 67757
		IChangeEntityState,
		// Token: 0x040108AE RID: 67758
		IChangeEntityStateDirectly,
		// Token: 0x040108AF RID: 67759
		IChangeEntityStateBatchDirectly,
		// Token: 0x040108B0 RID: 67760
		IChangeEntityStateLoop
	}
}
