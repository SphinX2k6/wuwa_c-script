using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007662 RID: 30306
	public enum TChangeEntityState : byte
	{
		// Token: 0x04012631 RID: 75313
		NONE,
		// Token: 0x04012632 RID: 75314
		IChangeEntityStateBatchDirectly,
		// Token: 0x04012633 RID: 75315
		IChangeEntityStateDirectly,
		// Token: 0x04012634 RID: 75316
		IChangeEntityStateLoop
	}
}
