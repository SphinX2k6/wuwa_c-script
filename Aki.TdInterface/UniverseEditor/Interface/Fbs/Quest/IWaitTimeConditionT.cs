using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004284 RID: 17028
	public class IWaitTimeConditionT
	{
		// Token: 0x170078E3 RID: 30947
		// (get) Token: 0x06019378 RID: 103288 RVA: 0x0039F7FB File Offset: 0x0039D9FB
		// (set) Token: 0x06019379 RID: 103289 RVA: 0x0039F803 File Offset: 0x0039DA03
		public EChildQuest Type { get; set; }

		// Token: 0x170078E4 RID: 30948
		// (get) Token: 0x0601937A RID: 103290 RVA: 0x0039F80C File Offset: 0x0039DA0C
		// (set) Token: 0x0601937B RID: 103291 RVA: 0x0039F814 File Offset: 0x0039DA14
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078E5 RID: 30949
		// (get) Token: 0x0601937C RID: 103292 RVA: 0x0039F81D File Offset: 0x0039DA1D
		// (set) Token: 0x0601937D RID: 103293 RVA: 0x0039F825 File Offset: 0x0039DA25
		public int Days { get; set; }

		// Token: 0x170078E6 RID: 30950
		// (get) Token: 0x0601937E RID: 103294 RVA: 0x0039F82E File Offset: 0x0039DA2E
		// (set) Token: 0x0601937F RID: 103295 RVA: 0x0039F836 File Offset: 0x0039DA36
		public int Hours { get; set; }

		// Token: 0x170078E7 RID: 30951
		// (get) Token: 0x06019380 RID: 103296 RVA: 0x0039F83F File Offset: 0x0039DA3F
		// (set) Token: 0x06019381 RID: 103297 RVA: 0x0039F847 File Offset: 0x0039DA47
		public int Minutes { get; set; }

		// Token: 0x170078E8 RID: 30952
		// (get) Token: 0x06019382 RID: 103298 RVA: 0x0039F850 File Offset: 0x0039DA50
		// (set) Token: 0x06019383 RID: 103299 RVA: 0x0039F858 File Offset: 0x0039DA58
		public int Seconds { get; set; }

		// Token: 0x06019384 RID: 103300 RVA: 0x0039F861 File Offset: 0x0039DA61
		public IWaitTimeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Days = 0;
			this.Hours = 0;
			this.Minutes = 0;
			this.Seconds = 0;
		}
	}
}
