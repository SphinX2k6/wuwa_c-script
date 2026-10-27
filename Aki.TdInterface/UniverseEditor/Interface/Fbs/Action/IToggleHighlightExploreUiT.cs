using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740A RID: 29706
	public class IToggleHighlightExploreUiT
	{
		// Token: 0x1700E1A1 RID: 57761
		// (get) Token: 0x06035F83 RID: 221059 RVA: 0x00757E16 File Offset: 0x00756016
		// (set) Token: 0x06035F84 RID: 221060 RVA: 0x00757E1E File Offset: 0x0075601E
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700E1A2 RID: 57762
		// (get) Token: 0x06035F85 RID: 221061 RVA: 0x00757E27 File Offset: 0x00756027
		// (set) Token: 0x06035F86 RID: 221062 RVA: 0x00757E2F File Offset: 0x0075602F
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700E1A3 RID: 57763
		// (get) Token: 0x06035F87 RID: 221063 RVA: 0x00757E38 File Offset: 0x00756038
		// (set) Token: 0x06035F88 RID: 221064 RVA: 0x00757E40 File Offset: 0x00756040
		public byte NullMask { get; set; }

		// Token: 0x06035F89 RID: 221065 RVA: 0x00757E49 File Offset: 0x00756049
		public IToggleHighlightExploreUiT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.NullMask = 0;
		}
	}
}
