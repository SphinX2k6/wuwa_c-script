using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200781E RID: 30750
	public enum ISetPlayerOperationRestriction_Union : byte
	{
		// Token: 0x04012A84 RID: 76420
		NONE,
		// Token: 0x04012A85 RID: 76421
		ISetPlayerOperationRestriction,
		// Token: 0x04012A86 RID: 76422
		IEnableAllPlayerOperation,
		// Token: 0x04012A87 RID: 76423
		IDisableAllPlayerOperation,
		// Token: 0x04012A88 RID: 76424
		IDisableModulePlayerOperation
	}
}
