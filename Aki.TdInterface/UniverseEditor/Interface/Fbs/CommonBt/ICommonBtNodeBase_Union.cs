using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC0 RID: 24256
	public enum ICommonBtNodeBase_Union : byte
	{
		// Token: 0x0400F93B RID: 63803
		NONE,
		// Token: 0x0400F93C RID: 63804
		ICommonBtNodeBase,
		// Token: 0x0400F93D RID: 63805
		ICommonBtStart,
		// Token: 0x0400F93E RID: 63806
		ICommonBtSequence,
		// Token: 0x0400F93F RID: 63807
		ICommonBtSelector,
		// Token: 0x0400F940 RID: 63808
		ICommonBtTask,
		// Token: 0x0400F941 RID: 63809
		ICommonBtProbability
	}
}
