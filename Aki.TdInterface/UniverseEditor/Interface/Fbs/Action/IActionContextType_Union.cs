using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D9 RID: 26329
	public enum IActionContextType_Union : byte
	{
		// Token: 0x04011034 RID: 69684
		NONE,
		// Token: 0x04011035 RID: 69685
		IActionContextType,
		// Token: 0x04011036 RID: 69686
		IEntityActionContext,
		// Token: 0x04011037 RID: 69687
		IFlowActionContext,
		// Token: 0x04011038 RID: 69688
		ILevelPlayActionContext,
		// Token: 0x04011039 RID: 69689
		ICommonBtActionContext,
		// Token: 0x0401103A RID: 69690
		IQuestActionContext,
		// Token: 0x0401103B RID: 69691
		IGmActionContext,
		// Token: 0x0401103C RID: 69692
		IToolEditorActionContext,
		// Token: 0x0401103D RID: 69693
		ICsvActionContext
	}
}
