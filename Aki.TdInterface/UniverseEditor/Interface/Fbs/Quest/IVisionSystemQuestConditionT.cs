using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D1 RID: 18129
	public class IVisionSystemQuestConditionT
	{
		// Token: 0x17007EF3 RID: 32499
		// (get) Token: 0x0601AA58 RID: 109144 RVA: 0x003C9D49 File Offset: 0x003C7F49
		// (set) Token: 0x0601AA59 RID: 109145 RVA: 0x003C9D51 File Offset: 0x003C7F51
		public EChildQuest Type { get; set; }

		// Token: 0x17007EF4 RID: 32500
		// (get) Token: 0x0601AA5A RID: 109146 RVA: 0x003C9D5A File Offset: 0x003C7F5A
		// (set) Token: 0x0601AA5B RID: 109147 RVA: 0x003C9D62 File Offset: 0x003C7F62
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007EF5 RID: 32501
		// (get) Token: 0x0601AA5C RID: 109148 RVA: 0x003C9D6B File Offset: 0x003C7F6B
		// (set) Token: 0x0601AA5D RID: 109149 RVA: 0x003C9D73 File Offset: 0x003C7F73
		public TVisionSystemQuestUnion Quest { get; set; }

		// Token: 0x0601AA5E RID: 109150 RVA: 0x003C9D7C File Offset: 0x003C7F7C
		public IVisionSystemQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Quest = null;
		}
	}
}
