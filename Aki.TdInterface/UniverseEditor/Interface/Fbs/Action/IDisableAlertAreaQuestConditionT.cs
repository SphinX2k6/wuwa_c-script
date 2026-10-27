using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065CE RID: 26062
	public class IDisableAlertAreaQuestConditionT
	{
		// Token: 0x1700C16A RID: 49514
		// (get) Token: 0x0602D332 RID: 185138 RVA: 0x006322D4 File Offset: 0x006304D4
		// (set) Token: 0x0602D333 RID: 185139 RVA: 0x006322DC File Offset: 0x006304DC
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x1700C16B RID: 49515
		// (get) Token: 0x0602D334 RID: 185140 RVA: 0x006322E5 File Offset: 0x006304E5
		// (set) Token: 0x0602D335 RID: 185141 RVA: 0x006322ED File Offset: 0x006304ED
		public int RelatedQuestId { get; set; }

		// Token: 0x0602D336 RID: 185142 RVA: 0x006322F6 File Offset: 0x006304F6
		public IDisableAlertAreaQuestConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
			this.RelatedQuestId = 0;
		}
	}
}
