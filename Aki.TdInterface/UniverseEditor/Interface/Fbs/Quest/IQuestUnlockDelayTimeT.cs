using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A6 RID: 17574
	public class IQuestUnlockDelayTimeT
	{
		// Token: 0x17007A29 RID: 31273
		// (get) Token: 0x06019564 RID: 103780 RVA: 0x0039DC92 File Offset: 0x0039BE92
		// (set) Token: 0x06019565 RID: 103781 RVA: 0x0039DC9A File Offset: 0x0039BE9A
		public int Day { get; set; }

		// Token: 0x17007A2A RID: 31274
		// (get) Token: 0x06019566 RID: 103782 RVA: 0x0039DCA3 File Offset: 0x0039BEA3
		// (set) Token: 0x06019567 RID: 103783 RVA: 0x0039DCAB File Offset: 0x0039BEAB
		public int Hour { get; set; }

		// Token: 0x17007A2B RID: 31275
		// (get) Token: 0x06019568 RID: 103784 RVA: 0x0039DCB4 File Offset: 0x0039BEB4
		// (set) Token: 0x06019569 RID: 103785 RVA: 0x0039DCBC File Offset: 0x0039BEBC
		public int Minute { get; set; }

		// Token: 0x0601956A RID: 103786 RVA: 0x0039DCC5 File Offset: 0x0039BEC5
		public IQuestUnlockDelayTimeT()
		{
			this.Day = 0;
			this.Hour = 0;
			this.Minute = 0;
		}
	}
}
