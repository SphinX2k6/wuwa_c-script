using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6E RID: 23918
	public class IBvbWaitForGameBeginDataT
	{
		// Token: 0x1700B324 RID: 45860
		// (get) Token: 0x06028EA8 RID: 167592 RVA: 0x0059ED22 File Offset: 0x0059CF22
		// (set) Token: 0x06028EA9 RID: 167593 RVA: 0x0059ED2A File Offset: 0x0059CF2A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028EAA RID: 167594 RVA: 0x0059ED33 File Offset: 0x0059CF33
		public IBvbWaitForGameBeginDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
