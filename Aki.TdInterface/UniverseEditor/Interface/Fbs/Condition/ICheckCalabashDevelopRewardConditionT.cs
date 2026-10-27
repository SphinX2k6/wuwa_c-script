using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004992 RID: 18834
	public class ICheckCalabashDevelopRewardConditionT
	{
		// Token: 0x1700880F RID: 34831
		// (get) Token: 0x0601D5F2 RID: 120306 RVA: 0x00423FD2 File Offset: 0x004221D2
		// (set) Token: 0x0601D5F3 RID: 120307 RVA: 0x00423FDA File Offset: 0x004221DA
		public ECondition Type { get; set; }

		// Token: 0x17008810 RID: 34832
		// (get) Token: 0x0601D5F4 RID: 120308 RVA: 0x00423FE3 File Offset: 0x004221E3
		// (set) Token: 0x0601D5F5 RID: 120309 RVA: 0x00423FEB File Offset: 0x004221EB
		public int MonsterId { get; set; }

		// Token: 0x17008811 RID: 34833
		// (get) Token: 0x0601D5F6 RID: 120310 RVA: 0x00423FF4 File Offset: 0x004221F4
		// (set) Token: 0x0601D5F7 RID: 120311 RVA: 0x00423FFC File Offset: 0x004221FC
		public ECalabashDevelop Develop { get; set; }

		// Token: 0x0601D5F8 RID: 120312 RVA: 0x00424005 File Offset: 0x00422205
		public ICheckCalabashDevelopRewardConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.MonsterId = 0;
			this.Develop = ECalabashDevelop.None;
		}
	}
}
