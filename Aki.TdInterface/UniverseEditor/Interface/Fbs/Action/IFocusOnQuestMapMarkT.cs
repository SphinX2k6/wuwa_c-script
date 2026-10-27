using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684D RID: 26701
	public class IFocusOnQuestMapMarkT
	{
		// Token: 0x1700C653 RID: 50771
		// (get) Token: 0x0602E8E1 RID: 190689 RVA: 0x0065A004 File Offset: 0x00658204
		// (set) Token: 0x0602E8E2 RID: 190690 RVA: 0x0065A00C File Offset: 0x0065820C
		public EMapMarkType Type { get; set; }

		// Token: 0x1700C654 RID: 50772
		// (get) Token: 0x0602E8E3 RID: 190691 RVA: 0x0065A015 File Offset: 0x00658215
		// (set) Token: 0x0602E8E4 RID: 190692 RVA: 0x0065A01D File Offset: 0x0065821D
		public int QuestId { get; set; }

		// Token: 0x0602E8E5 RID: 190693 RVA: 0x0065A026 File Offset: 0x00658226
		public IFocusOnQuestMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
			this.QuestId = 0;
		}
	}
}
