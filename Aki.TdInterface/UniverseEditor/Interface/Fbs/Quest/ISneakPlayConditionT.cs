using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004575 RID: 17781
	public class ISneakPlayConditionT
	{
		// Token: 0x17007C46 RID: 31814
		// (get) Token: 0x06019E5D RID: 106077 RVA: 0x003B1A1A File Offset: 0x003AFC1A
		// (set) Token: 0x06019E5E RID: 106078 RVA: 0x003B1A22 File Offset: 0x003AFC22
		public int Time { get; set; }

		// Token: 0x06019E5F RID: 106079 RVA: 0x003B1A2B File Offset: 0x003AFC2B
		public ISneakPlayConditionT()
		{
			this.Time = 0;
		}
	}
}
