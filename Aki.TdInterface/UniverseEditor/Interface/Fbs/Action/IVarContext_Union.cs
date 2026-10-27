using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F3 RID: 29939
	public enum IVarContext_Union : byte
	{
		// Token: 0x040123C8 RID: 74696
		NONE,
		// Token: 0x040123C9 RID: 74697
		IVarContext,
		// Token: 0x040123CA RID: 74698
		IEntityVarContext,
		// Token: 0x040123CB RID: 74699
		IQuestVarContext,
		// Token: 0x040123CC RID: 74700
		ILevelPlayVarContext,
		// Token: 0x040123CD RID: 74701
		IEntityTemplateContext,
		// Token: 0x040123CE RID: 74702
		IBehaviorTreeFragmentContext,
		// Token: 0x040123CF RID: 74703
		ICommonBtContext
	}
}
