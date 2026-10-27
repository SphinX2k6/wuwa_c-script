using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006077 RID: 24695
	public enum IActionContextType_Union : byte
	{
		// Token: 0x0401023F RID: 66111
		NONE,
		// Token: 0x04010240 RID: 66112
		IActionContextType,
		// Token: 0x04010241 RID: 66113
		IEntityActionContext,
		// Token: 0x04010242 RID: 66114
		IFlowActionContext,
		// Token: 0x04010243 RID: 66115
		ILevelPlayActionContext,
		// Token: 0x04010244 RID: 66116
		ICommonBtActionContext,
		// Token: 0x04010245 RID: 66117
		IQuestActionContext,
		// Token: 0x04010246 RID: 66118
		IGmActionContext,
		// Token: 0x04010247 RID: 66119
		IToolEditorActionContext,
		// Token: 0x04010248 RID: 66120
		ICsvActionContext
	}
}
