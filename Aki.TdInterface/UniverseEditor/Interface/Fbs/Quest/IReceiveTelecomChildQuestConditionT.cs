using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A1 RID: 16545
	public class IReceiveTelecomChildQuestConditionT
	{
		// Token: 0x170074BD RID: 29885
		// (get) Token: 0x06018165 RID: 98661 RVA: 0x00379025 File Offset: 0x00377225
		// (set) Token: 0x06018166 RID: 98662 RVA: 0x0037902D File Offset: 0x0037722D
		public EChildQuest Type { get; set; }

		// Token: 0x170074BE RID: 29886
		// (get) Token: 0x06018167 RID: 98663 RVA: 0x00379036 File Offset: 0x00377236
		// (set) Token: 0x06018168 RID: 98664 RVA: 0x0037903E File Offset: 0x0037723E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170074BF RID: 29887
		// (get) Token: 0x06018169 RID: 98665 RVA: 0x00379047 File Offset: 0x00377247
		// (set) Token: 0x0601816A RID: 98666 RVA: 0x0037904F File Offset: 0x0037724F
		public int TelecomId { get; set; }

		// Token: 0x0601816B RID: 98667 RVA: 0x00379058 File Offset: 0x00377258
		public IReceiveTelecomChildQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TelecomId = 0;
		}
	}
}
