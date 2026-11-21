using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E0 RID: 17376
	public class IPlaybackShowTimelineQuestConditionT
	{
		// Token: 0x170077B5 RID: 30645
		// (get) Token: 0x06018AE7 RID: 101095 RVA: 0x00384DC5 File Offset: 0x00382FC5
		// (set) Token: 0x06018AE8 RID: 101096 RVA: 0x00384DCD File Offset: 0x00382FCD
		public EChildQuest Type { get; set; }

		// Token: 0x170077B6 RID: 30646
		// (get) Token: 0x06018AE9 RID: 101097 RVA: 0x00384DD6 File Offset: 0x00382FD6
		// (set) Token: 0x06018AEA RID: 101098 RVA: 0x00384DDE File Offset: 0x00382FDE
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170077B7 RID: 30647
		// (get) Token: 0x06018AEB RID: 101099 RVA: 0x00384DE7 File Offset: 0x00382FE7
		// (set) Token: 0x06018AEC RID: 101100 RVA: 0x00384DEF File Offset: 0x00382FEF
		public string ShowTimelineFileName { get; set; }

		// Token: 0x06018AED RID: 101101 RVA: 0x00384DF8 File Offset: 0x00382FF8
		public IPlaybackShowTimelineQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ShowTimelineFileName = null;
		}
	}
}
