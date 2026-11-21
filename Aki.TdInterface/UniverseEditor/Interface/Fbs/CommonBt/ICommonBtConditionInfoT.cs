using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F2 RID: 25842
	public class ICommonBtConditionInfoT
	{
		// Token: 0x1700BE8D RID: 48781
		// (get) Token: 0x0602BFBF RID: 180159 RVA: 0x005FD1AB File Offset: 0x005FB3AB
		// (set) Token: 0x0602BFC0 RID: 180160 RVA: 0x005FD1B3 File Offset: 0x005FB3B3
		public int TaskId { get; set; }

		// Token: 0x1700BE8E RID: 48782
		// (get) Token: 0x0602BFC1 RID: 180161 RVA: 0x005FD1BC File Offset: 0x005FB3BC
		// (set) Token: 0x0602BFC2 RID: 180162 RVA: 0x005FD1C4 File Offset: 0x005FB3C4
		public ICondition2_UnionUnion Condition { get; set; }

		// Token: 0x0602BFC3 RID: 180163 RVA: 0x005FD1CD File Offset: 0x005FB3CD
		public ICommonBtConditionInfoT()
		{
			this.TaskId = 0;
			this.Condition = null;
		}
	}
}
