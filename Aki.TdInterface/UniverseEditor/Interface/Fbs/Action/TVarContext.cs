using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008039 RID: 32825
	public enum TVarContext : byte
	{
		// Token: 0x04013B39 RID: 80697
		NONE,
		// Token: 0x04013B3A RID: 80698
		IBehaviorTreeFragmentContext,
		// Token: 0x04013B3B RID: 80699
		ICommonBtContext,
		// Token: 0x04013B3C RID: 80700
		IEntityTemplateContext,
		// Token: 0x04013B3D RID: 80701
		IEntityVarContext,
		// Token: 0x04013B3E RID: 80702
		ILevelPlayVarContext,
		// Token: 0x04013B3F RID: 80703
		IQuestVarContext
	}
}
