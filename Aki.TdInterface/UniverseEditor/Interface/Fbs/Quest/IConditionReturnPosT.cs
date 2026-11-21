using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C7 RID: 16839
	public class IConditionReturnPosT
	{
		// Token: 0x1700726E RID: 29294
		// (get) Token: 0x060174BE RID: 95422 RVA: 0x0035366B File Offset: 0x0035186B
		// (set) Token: 0x060174BF RID: 95423 RVA: 0x00353673 File Offset: 0x00351873
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700726F RID: 29295
		// (get) Token: 0x060174C0 RID: 95424 RVA: 0x0035367C File Offset: 0x0035187C
		// (set) Token: 0x060174C1 RID: 95425 RVA: 0x00353684 File Offset: 0x00351884
		public TFastReturnPosUnion Pos { get; set; }

		// Token: 0x060174C2 RID: 95426 RVA: 0x0035368D File Offset: 0x0035188D
		public IConditionReturnPosT()
		{
			this.Condition = null;
			this.Pos = null;
		}
	}
}
