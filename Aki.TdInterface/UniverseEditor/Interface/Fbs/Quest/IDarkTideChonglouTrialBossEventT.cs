using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EB RID: 16875
	public class IDarkTideChonglouTrialBossEventT
	{
		// Token: 0x170072F4 RID: 29428
		// (get) Token: 0x060176BA RID: 95930 RVA: 0x00358D5E File Offset: 0x00356F5E
		// (set) Token: 0x060176BB RID: 95931 RVA: 0x00358D66 File Offset: 0x00356F66
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x060176BC RID: 95932 RVA: 0x00358D6F File Offset: 0x00356F6F
		public IDarkTideChonglouTrialBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
