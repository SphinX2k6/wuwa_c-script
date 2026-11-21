using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006503 RID: 25859
	public enum ICommonBtNodeBase_Union : byte
	{
		// Token: 0x0401069E RID: 67230
		NONE,
		// Token: 0x0401069F RID: 67231
		ICommonBtNodeBase,
		// Token: 0x040106A0 RID: 67232
		ICommonBtStart,
		// Token: 0x040106A1 RID: 67233
		ICommonBtSequence,
		// Token: 0x040106A2 RID: 67234
		ICommonBtSelector,
		// Token: 0x040106A3 RID: 67235
		ICommonBtTask,
		// Token: 0x040106A4 RID: 67236
		ICommonBtProbability
	}
}
