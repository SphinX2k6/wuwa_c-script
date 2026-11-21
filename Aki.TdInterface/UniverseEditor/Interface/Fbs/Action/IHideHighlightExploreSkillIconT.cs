using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9F RID: 28575
	public class IHideHighlightExploreSkillIconT
	{
		// Token: 0x1700D14C RID: 53580
		// (get) Token: 0x06031789 RID: 202633 RVA: 0x006B4DBF File Offset: 0x006B2FBF
		// (set) Token: 0x0603178A RID: 202634 RVA: 0x006B4DC7 File Offset: 0x006B2FC7
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700D14D RID: 53581
		// (get) Token: 0x0603178B RID: 202635 RVA: 0x006B4DD0 File Offset: 0x006B2FD0
		// (set) Token: 0x0603178C RID: 202636 RVA: 0x006B4DD8 File Offset: 0x006B2FD8
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700D14E RID: 53582
		// (get) Token: 0x0603178D RID: 202637 RVA: 0x006B4DE1 File Offset: 0x006B2FE1
		// (set) Token: 0x0603178E RID: 202638 RVA: 0x006B4DE9 File Offset: 0x006B2FE9
		public IHideHighlightExploreSkillIconTargetConfigT TargetConfig { get; set; }

		// Token: 0x1700D14F RID: 53583
		// (get) Token: 0x0603178F RID: 202639 RVA: 0x006B4DF2 File Offset: 0x006B2FF2
		// (set) Token: 0x06031790 RID: 202640 RVA: 0x006B4DFA File Offset: 0x006B2FFA
		public byte NullMask { get; set; }

		// Token: 0x06031791 RID: 202641 RVA: 0x006B4E03 File Offset: 0x006B3003
		public IHideHighlightExploreSkillIconT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.TargetConfig = null;
			this.NullMask = 0;
		}
	}
}
