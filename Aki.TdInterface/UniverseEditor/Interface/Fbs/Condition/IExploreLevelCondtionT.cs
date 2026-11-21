using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200510D RID: 20749
	public class IExploreLevelCondtionT
	{
		// Token: 0x170094B5 RID: 38069
		// (get) Token: 0x060209E5 RID: 133605 RVA: 0x00485BC4 File Offset: 0x00483DC4
		// (set) Token: 0x060209E6 RID: 133606 RVA: 0x00485BCC File Offset: 0x00483DCC
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x170094B6 RID: 38070
		// (get) Token: 0x060209E7 RID: 133607 RVA: 0x00485BD5 File Offset: 0x00483DD5
		// (set) Token: 0x060209E8 RID: 133608 RVA: 0x00485BDD File Offset: 0x00483DDD
		public int ExploreLevel { get; set; }

		// Token: 0x060209E9 RID: 133609 RVA: 0x00485BE6 File Offset: 0x00483DE6
		public IExploreLevelCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.ExploreLevel = 0;
		}
	}
}
