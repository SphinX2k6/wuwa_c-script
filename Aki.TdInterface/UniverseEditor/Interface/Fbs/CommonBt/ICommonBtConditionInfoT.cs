using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAF RID: 24239
	public class ICommonBtConditionInfoT
	{
		// Token: 0x1700B522 RID: 46370
		// (get) Token: 0x0602990B RID: 170251 RVA: 0x005B3CC7 File Offset: 0x005B1EC7
		// (set) Token: 0x0602990C RID: 170252 RVA: 0x005B3CCF File Offset: 0x005B1ECF
		public int TaskId { get; set; }

		// Token: 0x1700B523 RID: 46371
		// (get) Token: 0x0602990D RID: 170253 RVA: 0x005B3CD8 File Offset: 0x005B1ED8
		// (set) Token: 0x0602990E RID: 170254 RVA: 0x005B3CE0 File Offset: 0x005B1EE0
		public ICondition2_UnionUnion Condition { get; set; }

		// Token: 0x0602990F RID: 170255 RVA: 0x005B3CE9 File Offset: 0x005B1EE9
		public ICommonBtConditionInfoT()
		{
			this.TaskId = 0;
			this.Condition = null;
		}
	}
}
