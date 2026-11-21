using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C0 RID: 17088
	public class IGuideConditionT
	{
		// Token: 0x170074EF RID: 29935
		// (get) Token: 0x06017F3F RID: 98111 RVA: 0x0036B875 File Offset: 0x00369A75
		// (set) Token: 0x06017F40 RID: 98112 RVA: 0x0036B87D File Offset: 0x00369A7D
		public EChildQuest Type { get; set; }

		// Token: 0x170074F0 RID: 29936
		// (get) Token: 0x06017F41 RID: 98113 RVA: 0x0036B886 File Offset: 0x00369A86
		// (set) Token: 0x06017F42 RID: 98114 RVA: 0x0036B88E File Offset: 0x00369A8E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170074F1 RID: 29937
		// (get) Token: 0x06017F43 RID: 98115 RVA: 0x0036B897 File Offset: 0x00369A97
		// (set) Token: 0x06017F44 RID: 98116 RVA: 0x0036B89F File Offset: 0x00369A9F
		public int GuideGroupId { get; set; }

		// Token: 0x06017F45 RID: 98117 RVA: 0x0036B8A8 File Offset: 0x00369AA8
		public IGuideConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GuideGroupId = 0;
		}
	}
}
