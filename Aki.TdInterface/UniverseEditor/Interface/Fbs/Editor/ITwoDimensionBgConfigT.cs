using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D16 RID: 19734
	public class ITwoDimensionBgConfigT
	{
		// Token: 0x17008D36 RID: 36150
		// (get) Token: 0x0601E8C3 RID: 125123 RVA: 0x00446B97 File Offset: 0x00444D97
		// (set) Token: 0x0601E8C4 RID: 125124 RVA: 0x00446B9F File Offset: 0x00444D9F
		public string BgUrl { get; set; }

		// Token: 0x17008D37 RID: 36151
		// (get) Token: 0x0601E8C5 RID: 125125 RVA: 0x00446BA8 File Offset: 0x00444DA8
		// (set) Token: 0x0601E8C6 RID: 125126 RVA: 0x00446BB0 File Offset: 0x00444DB0
		public int Width { get; set; }

		// Token: 0x17008D38 RID: 36152
		// (get) Token: 0x0601E8C7 RID: 125127 RVA: 0x00446BB9 File Offset: 0x00444DB9
		// (set) Token: 0x0601E8C8 RID: 125128 RVA: 0x00446BC1 File Offset: 0x00444DC1
		public int Height { get; set; }

		// Token: 0x17008D39 RID: 36153
		// (get) Token: 0x0601E8C9 RID: 125129 RVA: 0x00446BCA File Offset: 0x00444DCA
		// (set) Token: 0x0601E8CA RID: 125130 RVA: 0x00446BD2 File Offset: 0x00444DD2
		public float Scale { get; set; }

		// Token: 0x0601E8CB RID: 125131 RVA: 0x00446BDB File Offset: 0x00444DDB
		public ITwoDimensionBgConfigT()
		{
			this.BgUrl = null;
			this.Width = 0;
			this.Height = 0;
			this.Scale = 0f;
		}
	}
}
