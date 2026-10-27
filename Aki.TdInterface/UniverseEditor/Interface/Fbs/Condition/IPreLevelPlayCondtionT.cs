using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C98 RID: 19608
	public class IPreLevelPlayCondtionT
	{
		// Token: 0x17008E5F RID: 36447
		// (get) Token: 0x0601F1A5 RID: 127397 RVA: 0x004587B4 File Offset: 0x004569B4
		// (set) Token: 0x0601F1A6 RID: 127398 RVA: 0x004587BC File Offset: 0x004569BC
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008E60 RID: 36448
		// (get) Token: 0x0601F1A7 RID: 127399 RVA: 0x004587C5 File Offset: 0x004569C5
		// (set) Token: 0x0601F1A8 RID: 127400 RVA: 0x004587CD File Offset: 0x004569CD
		public int PreLevelPlay { get; set; }

		// Token: 0x0601F1A9 RID: 127401 RVA: 0x004587D6 File Offset: 0x004569D6
		public IPreLevelPlayCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.PreLevelPlay = 0;
		}
	}
}
