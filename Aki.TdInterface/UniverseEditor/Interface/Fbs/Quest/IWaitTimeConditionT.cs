using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E0 RID: 18144
	public class IWaitTimeConditionT
	{
		// Token: 0x17007F14 RID: 32532
		// (get) Token: 0x0601AAE4 RID: 109284 RVA: 0x003CAED3 File Offset: 0x003C90D3
		// (set) Token: 0x0601AAE5 RID: 109285 RVA: 0x003CAEDB File Offset: 0x003C90DB
		public EChildQuest Type { get; set; }

		// Token: 0x17007F15 RID: 32533
		// (get) Token: 0x0601AAE6 RID: 109286 RVA: 0x003CAEE4 File Offset: 0x003C90E4
		// (set) Token: 0x0601AAE7 RID: 109287 RVA: 0x003CAEEC File Offset: 0x003C90EC
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007F16 RID: 32534
		// (get) Token: 0x0601AAE8 RID: 109288 RVA: 0x003CAEF5 File Offset: 0x003C90F5
		// (set) Token: 0x0601AAE9 RID: 109289 RVA: 0x003CAEFD File Offset: 0x003C90FD
		public int Days { get; set; }

		// Token: 0x17007F17 RID: 32535
		// (get) Token: 0x0601AAEA RID: 109290 RVA: 0x003CAF06 File Offset: 0x003C9106
		// (set) Token: 0x0601AAEB RID: 109291 RVA: 0x003CAF0E File Offset: 0x003C910E
		public int Hours { get; set; }

		// Token: 0x17007F18 RID: 32536
		// (get) Token: 0x0601AAEC RID: 109292 RVA: 0x003CAF17 File Offset: 0x003C9117
		// (set) Token: 0x0601AAED RID: 109293 RVA: 0x003CAF1F File Offset: 0x003C911F
		public int Minutes { get; set; }

		// Token: 0x17007F19 RID: 32537
		// (get) Token: 0x0601AAEE RID: 109294 RVA: 0x003CAF28 File Offset: 0x003C9128
		// (set) Token: 0x0601AAEF RID: 109295 RVA: 0x003CAF30 File Offset: 0x003C9130
		public int Seconds { get; set; }

		// Token: 0x0601AAF0 RID: 109296 RVA: 0x003CAF39 File Offset: 0x003C9139
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
