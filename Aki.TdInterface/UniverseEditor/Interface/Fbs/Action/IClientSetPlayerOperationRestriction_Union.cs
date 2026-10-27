using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E8 RID: 25576
	public enum IClientSetPlayerOperationRestriction_Union : byte
	{
		// Token: 0x040109CA RID: 68042
		NONE,
		// Token: 0x040109CB RID: 68043
		IClientSetPlayerOperationRestriction,
		// Token: 0x040109CC RID: 68044
		IClientEnableAllPlayerOperation,
		// Token: 0x040109CD RID: 68045
		IClientDisableAllPlayerOperation,
		// Token: 0x040109CE RID: 68046
		IClientDisableModulePlayerOperation
	}
}
