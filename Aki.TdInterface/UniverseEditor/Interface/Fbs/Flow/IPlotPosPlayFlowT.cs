using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB4 RID: 19380
	public class IPlotPosPlayFlowT
	{
		// Token: 0x17008937 RID: 35127
		// (get) Token: 0x0601D958 RID: 121176 RVA: 0x00427353 File Offset: 0x00425553
		// (set) Token: 0x0601D959 RID: 121177 RVA: 0x0042735B File Offset: 0x0042555B
		public string Guid { get; set; }

		// Token: 0x17008938 RID: 35128
		// (get) Token: 0x0601D95A RID: 121178 RVA: 0x00427364 File Offset: 0x00425564
		// (set) Token: 0x0601D95B RID: 121179 RVA: 0x0042736C File Offset: 0x0042556C
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0601D95C RID: 121180 RVA: 0x00427375 File Offset: 0x00425575
		public IPlotPosPlayFlowT()
		{
			this.Guid = null;
			this.Pos = null;
		}
	}
}
