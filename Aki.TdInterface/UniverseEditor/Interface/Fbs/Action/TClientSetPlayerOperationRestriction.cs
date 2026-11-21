using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E8B RID: 32395
	public enum TClientSetPlayerOperationRestriction : byte
	{
		// Token: 0x040136B7 RID: 79543
		NONE,
		// Token: 0x040136B8 RID: 79544
		IClientDisableAllPlayerOperation,
		// Token: 0x040136B9 RID: 79545
		IClientDisableModulePlayerOperation,
		// Token: 0x040136BA RID: 79546
		IClientEnableAllPlayerOperation
	}
}
