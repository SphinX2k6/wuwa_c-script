using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD4 RID: 20436
	public class ICommonSplinePointT
	{
		// Token: 0x1700940A RID: 37898
		// (get) Token: 0x060208C9 RID: 133321 RVA: 0x00486D1F File Offset: 0x00484F1F
		// (set) Token: 0x060208CA RID: 133322 RVA: 0x00486D27 File Offset: 0x00484F27
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700940B RID: 37899
		// (get) Token: 0x060208CB RID: 133323 RVA: 0x00486D30 File Offset: 0x00484F30
		// (set) Token: 0x060208CC RID: 133324 RVA: 0x00486D38 File Offset: 0x00484F38
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700940C RID: 37900
		// (get) Token: 0x060208CD RID: 133325 RVA: 0x00486D41 File Offset: 0x00484F41
		// (set) Token: 0x060208CE RID: 133326 RVA: 0x00486D49 File Offset: 0x00484F49
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700940D RID: 37901
		// (get) Token: 0x060208CF RID: 133327 RVA: 0x00486D52 File Offset: 0x00484F52
		// (set) Token: 0x060208D0 RID: 133328 RVA: 0x00486D5A File Offset: 0x00484F5A
		public ESplineLine LineType { get; set; }

		// Token: 0x1700940E RID: 37902
		// (get) Token: 0x060208D1 RID: 133329 RVA: 0x00486D63 File Offset: 0x00484F63
		// (set) Token: 0x060208D2 RID: 133330 RVA: 0x00486D6B File Offset: 0x00484F6B
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x060208D3 RID: 133331 RVA: 0x00486D74 File Offset: 0x00484F74
		public ICommonSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
		}
	}
}
