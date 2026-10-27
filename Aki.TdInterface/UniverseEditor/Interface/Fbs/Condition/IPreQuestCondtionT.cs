using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C9E RID: 19614
	public class IPreQuestCondtionT
	{
		// Token: 0x17008E6B RID: 36459
		// (get) Token: 0x0601F1D5 RID: 127445 RVA: 0x00458C44 File Offset: 0x00456E44
		// (set) Token: 0x0601F1D6 RID: 127446 RVA: 0x00458C4C File Offset: 0x00456E4C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E6C RID: 36460
		// (get) Token: 0x0601F1D7 RID: 127447 RVA: 0x00458C55 File Offset: 0x00456E55
		// (set) Token: 0x0601F1D8 RID: 127448 RVA: 0x00458C5D File Offset: 0x00456E5D
		public int PreQuest { get; set; }

		// Token: 0x0601F1D9 RID: 127449 RVA: 0x00458C66 File Offset: 0x00456E66
		public IPreQuestCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreQuest = 0;
		}
	}
}
