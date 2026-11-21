using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF4 RID: 31732
	public class IToggleHighlightExploreUiT
	{
		// Token: 0x1700EDB6 RID: 60854
		// (get) Token: 0x06039336 RID: 234294 RVA: 0x007BA58A File Offset: 0x007B878A
		// (set) Token: 0x06039337 RID: 234295 RVA: 0x007BA592 File Offset: 0x007B8792
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700EDB7 RID: 60855
		// (get) Token: 0x06039338 RID: 234296 RVA: 0x007BA59B File Offset: 0x007B879B
		// (set) Token: 0x06039339 RID: 234297 RVA: 0x007BA5A3 File Offset: 0x007B87A3
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700EDB8 RID: 60856
		// (get) Token: 0x0603933A RID: 234298 RVA: 0x007BA5AC File Offset: 0x007B87AC
		// (set) Token: 0x0603933B RID: 234299 RVA: 0x007BA5B4 File Offset: 0x007B87B4
		public byte NullMask { get; set; }

		// Token: 0x0603933C RID: 234300 RVA: 0x007BA5BD File Offset: 0x007B87BD
		public IToggleHighlightExploreUiT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.NullMask = 0;
		}
	}
}
