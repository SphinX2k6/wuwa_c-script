using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA8 RID: 24232
	public class IScanTraceEffectT
	{
		// Token: 0x1700B2F7 RID: 45815
		// (get) Token: 0x06028958 RID: 166232 RVA: 0x0058C423 File Offset: 0x0058A623
		// (set) Token: 0x06028959 RID: 166233 RVA: 0x0058C42B File Offset: 0x0058A62B
		public string Effect { get; set; }

		// Token: 0x1700B2F8 RID: 45816
		// (get) Token: 0x0602895A RID: 166234 RVA: 0x0058C434 File Offset: 0x0058A634
		// (set) Token: 0x0602895B RID: 166235 RVA: 0x0058C43C File Offset: 0x0058A63C
		public int Target { get; set; }

		// Token: 0x0602895C RID: 166236 RVA: 0x0058C445 File Offset: 0x0058A645
		public IScanTraceEffectT()
		{
			this.Effect = null;
			this.Target = 0;
		}
	}
}
