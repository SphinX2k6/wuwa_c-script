using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C92 RID: 19602
	public class IPreChildQuestCondtionT
	{
		// Token: 0x17008E55 RID: 36437
		// (get) Token: 0x0601F179 RID: 127353 RVA: 0x00458393 File Offset: 0x00456593
		// (set) Token: 0x0601F17A RID: 127354 RVA: 0x0045839B File Offset: 0x0045659B
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E56 RID: 36438
		// (get) Token: 0x0601F17B RID: 127355 RVA: 0x004583A4 File Offset: 0x004565A4
		// (set) Token: 0x0601F17C RID: 127356 RVA: 0x004583AC File Offset: 0x004565AC
		public IChildQuestConditionT PreChildQuest { get; set; }

		// Token: 0x0601F17D RID: 127357 RVA: 0x004583B5 File Offset: 0x004565B5
		public IPreChildQuestCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreChildQuest = null;
		}
	}
}
