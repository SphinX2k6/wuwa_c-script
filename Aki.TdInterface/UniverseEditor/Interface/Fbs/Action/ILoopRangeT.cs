using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007185 RID: 29061
	public class ILoopRangeT
	{
		// Token: 0x1700D4B7 RID: 54455
		// (get) Token: 0x0603284C RID: 206924 RVA: 0x006D3BF6 File Offset: 0x006D1DF6
		// (set) Token: 0x0603284D RID: 206925 RVA: 0x006D3BFE File Offset: 0x006D1DFE
		public string LeftMark { get; set; }

		// Token: 0x1700D4B8 RID: 54456
		// (get) Token: 0x0603284E RID: 206926 RVA: 0x006D3C07 File Offset: 0x006D1E07
		// (set) Token: 0x0603284F RID: 206927 RVA: 0x006D3C0F File Offset: 0x006D1E0F
		public string RightMark { get; set; }

		// Token: 0x06032850 RID: 206928 RVA: 0x006D3C18 File Offset: 0x006D1E18
		public ILoopRangeT()
		{
			this.LeftMark = null;
			this.RightMark = null;
		}
	}
}
