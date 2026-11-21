using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A68 RID: 31336
	public class ITalkBackgroundT
	{
		// Token: 0x1700E588 RID: 58760
		// (get) Token: 0x060373A5 RID: 226213 RVA: 0x0076057A File Offset: 0x0075E77A
		// (set) Token: 0x060373A6 RID: 226214 RVA: 0x00760582 File Offset: 0x0075E782
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x060373A7 RID: 226215 RVA: 0x0076058B File Offset: 0x0075E78B
		public ITalkBackgroundT()
		{
			this.Type = ETalkBackgroundType.Clean;
		}
	}
}
