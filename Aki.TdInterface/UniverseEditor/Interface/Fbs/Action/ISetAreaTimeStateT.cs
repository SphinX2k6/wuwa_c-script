using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007772 RID: 30578
	public class ISetAreaTimeStateT
	{
		// Token: 0x1700E01B RID: 57371
		// (get) Token: 0x06035ABD RID: 219837 RVA: 0x00731449 File Offset: 0x0072F649
		// (set) Token: 0x06035ABE RID: 219838 RVA: 0x00731451 File Offset: 0x0072F651
		public TSetAreaTimeTypeUnion SetAreaTimeConfig { get; set; }

		// Token: 0x06035ABF RID: 219839 RVA: 0x0073145A File Offset: 0x0072F65A
		public ISetAreaTimeStateT()
		{
			this.SetAreaTimeConfig = null;
		}
	}
}
