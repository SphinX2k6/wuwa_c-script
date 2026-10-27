using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004749 RID: 18249
	public class IPlotPositionT
	{
		// Token: 0x170082F1 RID: 33521
		// (get) Token: 0x0601C16B RID: 115051 RVA: 0x003FADDA File Offset: 0x003F8FDA
		// (set) Token: 0x0601C16C RID: 115052 RVA: 0x003FADE2 File Offset: 0x003F8FE2
		public List<IPlotPosPlayFlowT> PlayFlow { get; set; }

		// Token: 0x170082F2 RID: 33522
		// (get) Token: 0x0601C16D RID: 115053 RVA: 0x003FADEB File Offset: 0x003F8FEB
		// (set) Token: 0x0601C16E RID: 115054 RVA: 0x003FADF3 File Offset: 0x003F8FF3
		public List<IPlotPosFlowStateT> FlowState { get; set; }

		// Token: 0x0601C16F RID: 115055 RVA: 0x003FADFC File Offset: 0x003F8FFC
		public IPlotPositionT()
		{
			this.PlayFlow = null;
			this.FlowState = null;
		}
	}
}
