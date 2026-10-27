using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007052 RID: 28754
	public enum ISetPlayerOperationRestriction_Union : byte
	{
		// Token: 0x04011A97 RID: 72343
		NONE,
		// Token: 0x04011A98 RID: 72344
		ISetPlayerOperationRestriction,
		// Token: 0x04011A99 RID: 72345
		IEnableAllPlayerOperation,
		// Token: 0x04011A9A RID: 72346
		IDisableAllPlayerOperation,
		// Token: 0x04011A9B RID: 72347
		IDisableModulePlayerOperation
	}
}
