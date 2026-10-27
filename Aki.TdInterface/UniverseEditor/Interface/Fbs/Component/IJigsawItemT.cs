using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AD RID: 21677
	public class IJigsawItemT
	{
		// Token: 0x17009FA8 RID: 40872
		// (get) Token: 0x06023B1E RID: 146206 RVA: 0x004EF635 File Offset: 0x004ED835
		// (set) Token: 0x06023B1F RID: 146207 RVA: 0x004EF63D File Offset: 0x004ED83D
		public bool Disabled { get; set; }

		// Token: 0x17009FA9 RID: 40873
		// (get) Token: 0x06023B20 RID: 146208 RVA: 0x004EF646 File Offset: 0x004ED846
		// (set) Token: 0x06023B21 RID: 146209 RVA: 0x004EF64E File Offset: 0x004ED84E
		public TFillConfigUnion FillCfg { get; set; }

		// Token: 0x17009FAA RID: 40874
		// (get) Token: 0x06023B22 RID: 146210 RVA: 0x004EF657 File Offset: 0x004ED857
		// (set) Token: 0x06023B23 RID: 146211 RVA: 0x004EF65F File Offset: 0x004ED85F
		public byte NullMask { get; set; }

		// Token: 0x06023B24 RID: 146212 RVA: 0x004EF668 File Offset: 0x004ED868
		public IJigsawItemT()
		{
			this.Disabled = false;
			this.FillCfg = null;
			this.NullMask = 0;
		}
	}
}
