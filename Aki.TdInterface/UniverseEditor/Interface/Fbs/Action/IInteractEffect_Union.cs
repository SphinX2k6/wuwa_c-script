using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007037 RID: 28727
	public enum IInteractEffect_Union : byte
	{
		// Token: 0x04011F79 RID: 73593
		NONE,
		// Token: 0x04011F7A RID: 73594
		IInteractEffect,
		// Token: 0x04011F7B RID: 73595
		IModifyTipText,
		// Token: 0x04011F7C RID: 73596
		IExecuteTag,
		// Token: 0x04011F7D RID: 73597
		ITriggerDialogues,
		// Token: 0x04011F7E RID: 73598
		ITriggerVoiceDialogues
	}
}
