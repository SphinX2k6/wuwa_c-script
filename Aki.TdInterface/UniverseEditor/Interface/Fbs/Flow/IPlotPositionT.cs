using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB1 RID: 19377
	public class IPlotPositionT
	{
		// Token: 0x17008932 RID: 35122
		// (get) Token: 0x0601D940 RID: 121152 RVA: 0x00427076 File Offset: 0x00425276
		// (set) Token: 0x0601D941 RID: 121153 RVA: 0x0042707E File Offset: 0x0042527E
		public List<IPlotPosPlayFlowT> PlayFlow { get; set; }

		// Token: 0x17008933 RID: 35123
		// (get) Token: 0x0601D942 RID: 121154 RVA: 0x00427087 File Offset: 0x00425287
		// (set) Token: 0x0601D943 RID: 121155 RVA: 0x0042708F File Offset: 0x0042528F
		public List<IPlotPosFlowStateT> FlowState { get; set; }

		// Token: 0x0601D944 RID: 121156 RVA: 0x00427098 File Offset: 0x00425298
		public IPlotPositionT()
		{
			this.PlayFlow = null;
			this.FlowState = null;
		}
	}
}
