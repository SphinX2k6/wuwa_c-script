using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D56 RID: 23894
	public class IBvbPlayerTurnEndDataT
	{
		// Token: 0x1700B30D RID: 45837
		// (get) Token: 0x06028E1C RID: 167452 RVA: 0x0059E192 File Offset: 0x0059C392
		// (set) Token: 0x06028E1D RID: 167453 RVA: 0x0059E19A File Offset: 0x0059C39A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028E1E RID: 167454 RVA: 0x0059E1A3 File Offset: 0x0059C3A3
		public IBvbPlayerTurnEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
