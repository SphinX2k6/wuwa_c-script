using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A68 RID: 27240
	public enum IClientSetPlayerOperationRestriction_Union : byte
	{
		// Token: 0x040117F0 RID: 71664
		NONE,
		// Token: 0x040117F1 RID: 71665
		IClientSetPlayerOperationRestriction,
		// Token: 0x040117F2 RID: 71666
		IClientEnableAllPlayerOperation,
		// Token: 0x040117F3 RID: 71667
		IClientDisableAllPlayerOperation,
		// Token: 0x040117F4 RID: 71668
		IClientDisableModulePlayerOperation
	}
}
