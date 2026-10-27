using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007428 RID: 29736
	public class ITraceSplineT
	{
		// Token: 0x1700E1C2 RID: 57794
		// (get) Token: 0x0603603E RID: 221246 RVA: 0x00758EC1 File Offset: 0x007570C1
		// (set) Token: 0x0603603F RID: 221247 RVA: 0x00758EC9 File Offset: 0x007570C9
		public string EffectPath { get; set; }

		// Token: 0x1700E1C3 RID: 57795
		// (get) Token: 0x06036040 RID: 221248 RVA: 0x00758ED2 File Offset: 0x007570D2
		// (set) Token: 0x06036041 RID: 221249 RVA: 0x00758EDA File Offset: 0x007570DA
		public int Duration { get; set; }

		// Token: 0x1700E1C4 RID: 57796
		// (get) Token: 0x06036042 RID: 221250 RVA: 0x00758EE3 File Offset: 0x007570E3
		// (set) Token: 0x06036043 RID: 221251 RVA: 0x00758EEB File Offset: 0x007570EB
		public int SplineEntityId { get; set; }

		// Token: 0x06036044 RID: 221252 RVA: 0x00758EF4 File Offset: 0x007570F4
		public ITraceSplineT()
		{
			this.EffectPath = null;
			this.Duration = 0;
			this.SplineEntityId = 0;
		}
	}
}
