using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515F RID: 20831
	public enum IEntityBatchRefreshMode_Union : byte
	{
		// Token: 0x0400E203 RID: 57859
		NONE,
		// Token: 0x0400E204 RID: 57860
		IEntityBatchRefreshMode,
		// Token: 0x0400E205 RID: 57861
		ISequenceBatchRefresh,
		// Token: 0x0400E206 RID: 57862
		IRandomBatchRefresh,
		// Token: 0x0400E207 RID: 57863
		IRandomBatchPoolRefresh
	}
}
