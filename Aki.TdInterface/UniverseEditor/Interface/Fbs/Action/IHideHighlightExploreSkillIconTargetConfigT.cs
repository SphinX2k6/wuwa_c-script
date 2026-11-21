using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA2 RID: 28578
	public class IHideHighlightExploreSkillIconTargetConfigT
	{
		// Token: 0x1700D154 RID: 53588
		// (get) Token: 0x060317A5 RID: 202661 RVA: 0x006B508E File Offset: 0x006B328E
		// (set) Token: 0x060317A6 RID: 202662 RVA: 0x006B5096 File Offset: 0x006B3296
		public int SkillType { get; set; }

		// Token: 0x1700D155 RID: 53589
		// (get) Token: 0x060317A7 RID: 202663 RVA: 0x006B509F File Offset: 0x006B329F
		// (set) Token: 0x060317A8 RID: 202664 RVA: 0x006B50A7 File Offset: 0x006B32A7
		public int ItemId { get; set; }

		// Token: 0x1700D156 RID: 53590
		// (get) Token: 0x060317A9 RID: 202665 RVA: 0x006B50B0 File Offset: 0x006B32B0
		// (set) Token: 0x060317AA RID: 202666 RVA: 0x006B50B8 File Offset: 0x006B32B8
		public byte NullMask { get; set; }

		// Token: 0x060317AB RID: 202667 RVA: 0x006B50C1 File Offset: 0x006B32C1
		public IHideHighlightExploreSkillIconTargetConfigT()
		{
			this.SkillType = 0;
			this.ItemId = 0;
			this.NullMask = 0;
		}
	}
}
