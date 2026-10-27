using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E0 RID: 28896
	public class IShowHighlightExploreSkillIconT
	{
		// Token: 0x1700D6B7 RID: 54967
		// (get) Token: 0x0603331B RID: 209691 RVA: 0x006E6D18 File Offset: 0x006E4F18
		// (set) Token: 0x0603331C RID: 209692 RVA: 0x006E6D20 File Offset: 0x006E4F20
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700D6B8 RID: 54968
		// (get) Token: 0x0603331D RID: 209693 RVA: 0x006E6D29 File Offset: 0x006E4F29
		// (set) Token: 0x0603331E RID: 209694 RVA: 0x006E6D31 File Offset: 0x006E4F31
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700D6B9 RID: 54969
		// (get) Token: 0x0603331F RID: 209695 RVA: 0x006E6D3A File Offset: 0x006E4F3A
		// (set) Token: 0x06033320 RID: 209696 RVA: 0x006E6D42 File Offset: 0x006E4F42
		public int SkillType { get; set; }

		// Token: 0x1700D6BA RID: 54970
		// (get) Token: 0x06033321 RID: 209697 RVA: 0x006E6D4B File Offset: 0x006E4F4B
		// (set) Token: 0x06033322 RID: 209698 RVA: 0x006E6D53 File Offset: 0x006E4F53
		public float Duration { get; set; }

		// Token: 0x1700D6BB RID: 54971
		// (get) Token: 0x06033323 RID: 209699 RVA: 0x006E6D5C File Offset: 0x006E4F5C
		// (set) Token: 0x06033324 RID: 209700 RVA: 0x006E6D64 File Offset: 0x006E4F64
		public bool IsSwitchBack { get; set; }

		// Token: 0x1700D6BC RID: 54972
		// (get) Token: 0x06033325 RID: 209701 RVA: 0x006E6D6D File Offset: 0x006E4F6D
		// (set) Token: 0x06033326 RID: 209702 RVA: 0x006E6D75 File Offset: 0x006E4F75
		public byte NullMask { get; set; }

		// Token: 0x06033327 RID: 209703 RVA: 0x006E6D7E File Offset: 0x006E4F7E
		public IShowHighlightExploreSkillIconT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.SkillType = 0;
			this.Duration = 0f;
			this.IsSwitchBack = false;
			this.NullMask = 0;
		}
	}
}
