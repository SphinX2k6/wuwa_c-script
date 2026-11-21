using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E0D RID: 24077
	public class IRangedRandomT
	{
		// Token: 0x1700B17A RID: 45434
		// (get) Token: 0x06028341 RID: 164673 RVA: 0x0057F928 File Offset: 0x0057DB28
		// (set) Token: 0x06028342 RID: 164674 RVA: 0x0057F930 File Offset: 0x0057DB30
		public float Left { get; set; }

		// Token: 0x1700B17B RID: 45435
		// (get) Token: 0x06028343 RID: 164675 RVA: 0x0057F939 File Offset: 0x0057DB39
		// (set) Token: 0x06028344 RID: 164676 RVA: 0x0057F941 File Offset: 0x0057DB41
		public float Right { get; set; }

		// Token: 0x06028345 RID: 164677 RVA: 0x0057F94A File Offset: 0x0057DB4A
		public IRangedRandomT()
		{
			this.Left = 0f;
			this.Right = 0f;
		}
	}
}
