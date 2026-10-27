using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006984 RID: 27012
	public enum IInteractEffect_Union : byte
	{
		// Token: 0x0401110D RID: 69901
		NONE,
		// Token: 0x0401110E RID: 69902
		IInteractEffect,
		// Token: 0x0401110F RID: 69903
		IModifyTipText,
		// Token: 0x04011110 RID: 69904
		IExecuteTag,
		// Token: 0x04011111 RID: 69905
		ITriggerDialogues,
		// Token: 0x04011112 RID: 69906
		ITriggerVoiceDialogues
	}
}
