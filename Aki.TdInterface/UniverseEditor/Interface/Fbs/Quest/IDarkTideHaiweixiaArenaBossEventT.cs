using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EE RID: 16878
	public class IDarkTideHaiweixiaArenaBossEventT
	{
		// Token: 0x170072F7 RID: 29431
		// (get) Token: 0x060176CC RID: 95948 RVA: 0x00358ED6 File Offset: 0x003570D6
		// (set) Token: 0x060176CD RID: 95949 RVA: 0x00358EDE File Offset: 0x003570DE
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x060176CE RID: 95950 RVA: 0x00358EE7 File Offset: 0x003570E7
		public IDarkTideHaiweixiaArenaBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
