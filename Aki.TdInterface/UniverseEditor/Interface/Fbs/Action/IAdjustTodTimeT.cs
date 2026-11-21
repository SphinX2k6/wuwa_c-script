using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D9 RID: 26585
	public class IAdjustTodTimeT
	{
		// Token: 0x1700C343 RID: 49987
		// (get) Token: 0x0602D61B RID: 185883 RVA: 0x00636E0E File Offset: 0x0063500E
		// (set) Token: 0x0602D61C RID: 185884 RVA: 0x00636E16 File Offset: 0x00635016
		public int Hour { get; set; }

		// Token: 0x1700C344 RID: 49988
		// (get) Token: 0x0602D61D RID: 185885 RVA: 0x00636E1F File Offset: 0x0063501F
		// (set) Token: 0x0602D61E RID: 185886 RVA: 0x00636E27 File Offset: 0x00635027
		public int Min { get; set; }

		// Token: 0x1700C345 RID: 49989
		// (get) Token: 0x0602D61F RID: 185887 RVA: 0x00636E30 File Offset: 0x00635030
		// (set) Token: 0x0602D620 RID: 185888 RVA: 0x00636E38 File Offset: 0x00635038
		public bool ShowUi { get; set; }

		// Token: 0x0602D621 RID: 185889 RVA: 0x00636E41 File Offset: 0x00635041
		public IAdjustTodTimeT()
		{
			this.Hour = 0;
			this.Min = 0;
			this.ShowUi = false;
		}
	}
}
