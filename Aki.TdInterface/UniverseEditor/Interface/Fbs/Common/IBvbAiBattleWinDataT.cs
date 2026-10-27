using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1D RID: 23837
	public class IBvbAiBattleWinDataT
	{
		// Token: 0x1700B2A9 RID: 45737
		// (get) Token: 0x06028BBD RID: 166845 RVA: 0x005981FE File Offset: 0x005963FE
		// (set) Token: 0x06028BBE RID: 166846 RVA: 0x00598206 File Offset: 0x00596406
		public EBvbEventName Type { get; set; }

		// Token: 0x06028BBF RID: 166847 RVA: 0x0059820F File Offset: 0x0059640F
		public IBvbAiBattleWinDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
