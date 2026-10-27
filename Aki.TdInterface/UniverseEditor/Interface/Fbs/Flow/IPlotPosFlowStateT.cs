using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004746 RID: 18246
	public class IPlotPosFlowStateT
	{
		// Token: 0x170082EC RID: 33516
		// (get) Token: 0x0601C149 RID: 115017 RVA: 0x003FA87F File Offset: 0x003F8A7F
		// (set) Token: 0x0601C14A RID: 115018 RVA: 0x003FA887 File Offset: 0x003F8A87
		public IFlowStateIndexT Flow { get; set; }

		// Token: 0x170082ED RID: 33517
		// (get) Token: 0x0601C14B RID: 115019 RVA: 0x003FA890 File Offset: 0x003F8A90
		// (set) Token: 0x0601C14C RID: 115020 RVA: 0x003FA898 File Offset: 0x003F8A98
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0601C14D RID: 115021 RVA: 0x003FA8A1 File Offset: 0x003F8AA1
		public IPlotPosFlowStateT()
		{
			this.Flow = null;
			this.Pos = null;
		}
	}
}
