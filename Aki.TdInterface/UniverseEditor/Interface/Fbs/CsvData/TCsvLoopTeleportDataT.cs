using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC8 RID: 19912
	public class TCsvLoopTeleportDataT
	{
		// Token: 0x17008E6F RID: 36463
		// (get) Token: 0x0601EE6B RID: 126571 RVA: 0x0045148D File Offset: 0x0044F68D
		// (set) Token: 0x0601EE6C RID: 126572 RVA: 0x00451495 File Offset: 0x0044F695
		public int Id { get; set; }

		// Token: 0x17008E70 RID: 36464
		// (get) Token: 0x0601EE6D RID: 126573 RVA: 0x0045149E File Offset: 0x0044F69E
		// (set) Token: 0x0601EE6E RID: 126574 RVA: 0x004514A6 File Offset: 0x0044F6A6
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17008E71 RID: 36465
		// (get) Token: 0x0601EE6F RID: 126575 RVA: 0x004514AF File Offset: 0x0044F6AF
		// (set) Token: 0x0601EE70 RID: 126576 RVA: 0x004514B7 File Offset: 0x0044F6B7
		public List<ILoopTeleportClientLogicItemBase_UnionUnion> ClientLogic { get; set; }

		// Token: 0x0601EE71 RID: 126577 RVA: 0x004514C0 File Offset: 0x0044F6C0
		public TCsvLoopTeleportDataT()
		{
			this.Id = 0;
			this.Conditions = null;
			this.ClientLogic = null;
		}
	}
}
