using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005474 RID: 21620
	public class IInteractSectorRangeT
	{
		// Token: 0x17009F24 RID: 40740
		// (get) Token: 0x0602390F RID: 145679 RVA: 0x004EB27C File Offset: 0x004E947C
		// (set) Token: 0x06023910 RID: 145680 RVA: 0x004EB284 File Offset: 0x004E9484
		public float Begin { get; set; }

		// Token: 0x17009F25 RID: 40741
		// (get) Token: 0x06023911 RID: 145681 RVA: 0x004EB28D File Offset: 0x004E948D
		// (set) Token: 0x06023912 RID: 145682 RVA: 0x004EB295 File Offset: 0x004E9495
		public float End { get; set; }

		// Token: 0x06023913 RID: 145683 RVA: 0x004EB29E File Offset: 0x004E949E
		public IInteractSectorRangeT()
		{
			this.Begin = 0f;
			this.End = 0f;
		}
	}
}
