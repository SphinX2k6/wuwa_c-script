using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C36 RID: 27702
	public class IDisableAlertAreaQuestConditionT
	{
		// Token: 0x1700CAF9 RID: 51961
		// (get) Token: 0x0602FAB6 RID: 195254 RVA: 0x0067E498 File Offset: 0x0067C698
		// (set) Token: 0x0602FAB7 RID: 195255 RVA: 0x0067E4A0 File Offset: 0x0067C6A0
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x1700CAFA RID: 51962
		// (get) Token: 0x0602FAB8 RID: 195256 RVA: 0x0067E4A9 File Offset: 0x0067C6A9
		// (set) Token: 0x0602FAB9 RID: 195257 RVA: 0x0067E4B1 File Offset: 0x0067C6B1
		public int RelatedQuestId { get; set; }

		// Token: 0x0602FABA RID: 195258 RVA: 0x0067E4BA File Offset: 0x0067C6BA
		public IDisableAlertAreaQuestConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
			this.RelatedQuestId = 0;
		}
	}
}
