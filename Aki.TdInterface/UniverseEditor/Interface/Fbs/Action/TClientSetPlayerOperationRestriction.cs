using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767D RID: 30333
	public enum TClientSetPlayerOperationRestriction : byte
	{
		// Token: 0x0401266C RID: 75372
		NONE,
		// Token: 0x0401266D RID: 75373
		IClientDisableAllPlayerOperation,
		// Token: 0x0401266E RID: 75374
		IClientDisableModulePlayerOperation,
		// Token: 0x0401266F RID: 75375
		IClientEnableAllPlayerOperation
	}
}
