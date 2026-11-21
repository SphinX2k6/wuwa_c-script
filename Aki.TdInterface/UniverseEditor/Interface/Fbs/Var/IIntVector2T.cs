using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EA2 RID: 16034
	public class IIntVector2T
	{
		// Token: 0x17006C6E RID: 27758
		// (get) Token: 0x06015AA0 RID: 88736 RVA: 0x0031ED5A File Offset: 0x0031CF5A
		// (set) Token: 0x06015AA1 RID: 88737 RVA: 0x0031ED62 File Offset: 0x0031CF62
		public int X { get; set; }

		// Token: 0x17006C6F RID: 27759
		// (get) Token: 0x06015AA2 RID: 88738 RVA: 0x0031ED6B File Offset: 0x0031CF6B
		// (set) Token: 0x06015AA3 RID: 88739 RVA: 0x0031ED73 File Offset: 0x0031CF73
		public int Y { get; set; }

		// Token: 0x17006C70 RID: 27760
		// (get) Token: 0x06015AA4 RID: 88740 RVA: 0x0031ED7C File Offset: 0x0031CF7C
		// (set) Token: 0x06015AA5 RID: 88741 RVA: 0x0031ED84 File Offset: 0x0031CF84
		public byte NullMask { get; set; }

		// Token: 0x06015AA6 RID: 88742 RVA: 0x0031ED8D File Offset: 0x0031CF8D
		public IIntVector2T()
		{
			this.X = 0;
			this.Y = 0;
			this.NullMask = 0;
		}
	}
}
