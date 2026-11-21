using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200518B RID: 20875
	public class IPreChildQuestCondtionT
	{
		// Token: 0x17009583 RID: 38275
		// (get) Token: 0x06020D9B RID: 134555 RVA: 0x0048BEE3 File Offset: 0x0048A0E3
		// (set) Token: 0x06020D9C RID: 134556 RVA: 0x0048BEEB File Offset: 0x0048A0EB
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009584 RID: 38276
		// (get) Token: 0x06020D9D RID: 134557 RVA: 0x0048BEF4 File Offset: 0x0048A0F4
		// (set) Token: 0x06020D9E RID: 134558 RVA: 0x0048BEFC File Offset: 0x0048A0FC
		public IChildQuestConditionT PreChildQuest { get; set; }

		// Token: 0x06020D9F RID: 134559 RVA: 0x0048BF05 File Offset: 0x0048A105
		public IPreChildQuestCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreChildQuest = null;
		}
	}
}
