using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAE RID: 19374
	public class IPlotPosFlowStateT
	{
		// Token: 0x1700892D RID: 35117
		// (get) Token: 0x0601D91E RID: 121118 RVA: 0x00426B1B File Offset: 0x00424D1B
		// (set) Token: 0x0601D91F RID: 121119 RVA: 0x00426B23 File Offset: 0x00424D23
		public IFlowStateIndexT Flow { get; set; }

		// Token: 0x1700892E RID: 35118
		// (get) Token: 0x0601D920 RID: 121120 RVA: 0x00426B2C File Offset: 0x00424D2C
		// (set) Token: 0x0601D921 RID: 121121 RVA: 0x00426B34 File Offset: 0x00424D34
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0601D922 RID: 121122 RVA: 0x00426B3D File Offset: 0x00424D3D
		public IPlotPosFlowStateT()
		{
			this.Flow = null;
			this.Pos = null;
		}
	}
}
