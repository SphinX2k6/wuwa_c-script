using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4A RID: 23882
	public class IBvbEnableHatredDataT
	{
		// Token: 0x1700B302 RID: 45826
		// (get) Token: 0x06028DAC RID: 167340 RVA: 0x0059D612 File Offset: 0x0059B812
		// (set) Token: 0x06028DAD RID: 167341 RVA: 0x0059D61A File Offset: 0x0059B81A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028DAE RID: 167342 RVA: 0x0059D623 File Offset: 0x0059B823
		public IBvbEnableHatredDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
