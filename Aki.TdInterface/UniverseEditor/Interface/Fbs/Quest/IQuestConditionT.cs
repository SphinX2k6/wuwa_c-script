using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004410 RID: 17424
	public class IQuestConditionT
	{
		// Token: 0x1700786F RID: 30831
		// (get) Token: 0x06018D98 RID: 101784 RVA: 0x0038B2BB File Offset: 0x003894BB
		// (set) Token: 0x06018D99 RID: 101785 RVA: 0x0038B2C3 File Offset: 0x003894C3
		public EChildQuest Type { get; set; }

		// Token: 0x17007870 RID: 30832
		// (get) Token: 0x06018D9A RID: 101786 RVA: 0x0038B2CC File Offset: 0x003894CC
		// (set) Token: 0x06018D9B RID: 101787 RVA: 0x0038B2D4 File Offset: 0x003894D4
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x06018D9C RID: 101788 RVA: 0x0038B2DD File Offset: 0x003894DD
		public IQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
