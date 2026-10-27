using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D44 RID: 23876
	public class IBvbAiTurnEndDataT
	{
		// Token: 0x1700B2FC RID: 45820
		// (get) Token: 0x06028D88 RID: 167304 RVA: 0x0059D322 File Offset: 0x0059B522
		// (set) Token: 0x06028D89 RID: 167305 RVA: 0x0059D32A File Offset: 0x0059B52A
		public EBvbEventName Type { get; set; }

		// Token: 0x06028D8A RID: 167306 RVA: 0x0059D333 File Offset: 0x0059B533
		public IBvbAiTurnEndDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
