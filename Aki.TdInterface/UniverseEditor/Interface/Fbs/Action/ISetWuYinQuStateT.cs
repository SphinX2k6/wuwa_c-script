using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B6 RID: 28854
	public class ISetWuYinQuStateT
	{
		// Token: 0x1700D659 RID: 54873
		// (get) Token: 0x060331A3 RID: 209315 RVA: 0x006E4473 File Offset: 0x006E2673
		// (set) Token: 0x060331A4 RID: 209316 RVA: 0x006E447B File Offset: 0x006E267B
		public string WuYinQuName { get; set; }

		// Token: 0x1700D65A RID: 54874
		// (get) Token: 0x060331A5 RID: 209317 RVA: 0x006E4484 File Offset: 0x006E2684
		// (set) Token: 0x060331A6 RID: 209318 RVA: 0x006E448C File Offset: 0x006E268C
		public EWuYinQuState State { get; set; }

		// Token: 0x060331A7 RID: 209319 RVA: 0x006E4495 File Offset: 0x006E2695
		public ISetWuYinQuStateT()
		{
			this.WuYinQuName = null;
			this.State = EWuYinQuState.End;
		}
	}
}
