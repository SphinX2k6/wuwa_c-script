using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004083 RID: 16515
	public class IRecallConfigT
	{
		// Token: 0x1700748F RID: 29839
		// (get) Token: 0x06018069 RID: 98409 RVA: 0x0037746A File Offset: 0x0037566A
		// (set) Token: 0x0601806A RID: 98410 RVA: 0x00377472 File Offset: 0x00375672
		public int RecallId { get; set; }

		// Token: 0x0601806B RID: 98411 RVA: 0x0037747B File Offset: 0x0037567B
		public IRecallConfigT()
		{
			this.RecallId = 0;
		}
	}
}
