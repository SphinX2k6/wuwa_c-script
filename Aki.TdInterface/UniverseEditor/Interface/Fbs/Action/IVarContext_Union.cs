using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE9 RID: 31977
	public enum IVarContext_Union : byte
	{
		// Token: 0x040133F9 RID: 78841
		NONE,
		// Token: 0x040133FA RID: 78842
		IVarContext,
		// Token: 0x040133FB RID: 78843
		IEntityVarContext,
		// Token: 0x040133FC RID: 78844
		IQuestVarContext,
		// Token: 0x040133FD RID: 78845
		ILevelPlayVarContext,
		// Token: 0x040133FE RID: 78846
		IEntityTemplateContext,
		// Token: 0x040133FF RID: 78847
		IBehaviorTreeFragmentContext,
		// Token: 0x04013400 RID: 78848
		ICommonBtContext
	}
}
