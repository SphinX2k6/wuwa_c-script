using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB8 RID: 31672
	public class ITextStyleT
	{
		// Token: 0x1700ED45 RID: 60741
		// (get) Token: 0x0603914E RID: 233806 RVA: 0x007B70F5 File Offset: 0x007B52F5
		// (set) Token: 0x0603914F RID: 233807 RVA: 0x007B70FD File Offset: 0x007B52FD
		public TCenterTextShowAnimUnion ShowAnim { get; set; }

		// Token: 0x1700ED46 RID: 60742
		// (get) Token: 0x06039150 RID: 233808 RVA: 0x007B7106 File Offset: 0x007B5306
		// (set) Token: 0x06039151 RID: 233809 RVA: 0x007B710E File Offset: 0x007B530E
		public EFontSize FontSize { get; set; }

		// Token: 0x1700ED47 RID: 60743
		// (get) Token: 0x06039152 RID: 233810 RVA: 0x007B7117 File Offset: 0x007B5317
		// (set) Token: 0x06039153 RID: 233811 RVA: 0x007B711F File Offset: 0x007B531F
		public ETextAlign TextAlign { get; set; }

		// Token: 0x1700ED48 RID: 60744
		// (get) Token: 0x06039154 RID: 233812 RVA: 0x007B7128 File Offset: 0x007B5328
		// (set) Token: 0x06039155 RID: 233813 RVA: 0x007B7130 File Offset: 0x007B5330
		public ETextHorizontal TextHorizontal { get; set; }

		// Token: 0x1700ED49 RID: 60745
		// (get) Token: 0x06039156 RID: 233814 RVA: 0x007B7139 File Offset: 0x007B5339
		// (set) Token: 0x06039157 RID: 233815 RVA: 0x007B7141 File Offset: 0x007B5341
		public byte NullMask { get; set; }

		// Token: 0x06039158 RID: 233816 RVA: 0x007B714A File Offset: 0x007B534A
		public ITextStyleT()
		{
			this.ShowAnim = null;
			this.FontSize = EFontSize.Small;
			this.TextAlign = ETextAlign.Top;
			this.TextHorizontal = ETextHorizontal.Left;
			this.NullMask = 0;
		}
	}
}
