using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC3 RID: 23235
	public class IMechaTrackCountDownTipT
	{
		// Token: 0x1700A951 RID: 43345
		// (get) Token: 0x06026199 RID: 156057 RVA: 0x0053815F File Offset: 0x0053635F
		// (set) Token: 0x0602619A RID: 156058 RVA: 0x00538167 File Offset: 0x00536367
		public ETrampleTipType Type { get; set; }

		// Token: 0x1700A952 RID: 43346
		// (get) Token: 0x0602619B RID: 156059 RVA: 0x00538170 File Offset: 0x00536370
		// (set) Token: 0x0602619C RID: 156060 RVA: 0x00538178 File Offset: 0x00536378
		public string TidCountDownTip { get; set; }

		// Token: 0x0602619D RID: 156061 RVA: 0x00538181 File Offset: 0x00536381
		public IMechaTrackCountDownTipT()
		{
			this.Type = ETrampleTipType.CountDownTextTip;
			this.TidCountDownTip = null;
		}
	}
}
