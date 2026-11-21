using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005191 RID: 20881
	public class IPreLevelPlayCondtionT
	{
		// Token: 0x1700958D RID: 38285
		// (get) Token: 0x06020DC7 RID: 134599 RVA: 0x0048C304 File Offset: 0x0048A504
		// (set) Token: 0x06020DC8 RID: 134600 RVA: 0x0048C30C File Offset: 0x0048A50C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x1700958E RID: 38286
		// (get) Token: 0x06020DC9 RID: 134601 RVA: 0x0048C315 File Offset: 0x0048A515
		// (set) Token: 0x06020DCA RID: 134602 RVA: 0x0048C31D File Offset: 0x0048A51D
		public int PreLevelPlay { get; set; }

		// Token: 0x06020DCB RID: 134603 RVA: 0x0048C326 File Offset: 0x0048A526
		public IPreLevelPlayCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreLevelPlay = 0;
		}
	}
}
