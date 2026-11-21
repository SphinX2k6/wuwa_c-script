using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426F RID: 17007
	public class IFinishDungeonQuestConditionT
	{
		// Token: 0x17007404 RID: 29700
		// (get) Token: 0x06017B5E RID: 97118 RVA: 0x00361D65 File Offset: 0x0035FF65
		// (set) Token: 0x06017B5F RID: 97119 RVA: 0x00361D6D File Offset: 0x0035FF6D
		public EChildQuest Type { get; set; }

		// Token: 0x17007405 RID: 29701
		// (get) Token: 0x06017B60 RID: 97120 RVA: 0x00361D76 File Offset: 0x0035FF76
		// (set) Token: 0x06017B61 RID: 97121 RVA: 0x00361D7E File Offset: 0x0035FF7E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007406 RID: 29702
		// (get) Token: 0x06017B62 RID: 97122 RVA: 0x00361D87 File Offset: 0x0035FF87
		// (set) Token: 0x06017B63 RID: 97123 RVA: 0x00361D8F File Offset: 0x0035FF8F
		public TDungeonConditionTypeUnion Condition { get; set; }

		// Token: 0x06017B64 RID: 97124 RVA: 0x00361D98 File Offset: 0x0035FF98
		public IFinishDungeonQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}
