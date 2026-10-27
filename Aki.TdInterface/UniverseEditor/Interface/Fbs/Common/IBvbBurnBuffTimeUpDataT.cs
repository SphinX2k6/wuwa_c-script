using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D47 RID: 23879
	public class IBvbBurnBuffTimeUpDataT
	{
		// Token: 0x1700B2FF RID: 45823
		// (get) Token: 0x06028D9A RID: 167322 RVA: 0x0059D49A File Offset: 0x0059B69A
		// (set) Token: 0x06028D9B RID: 167323 RVA: 0x0059D4A2 File Offset: 0x0059B6A2
		public EBvbEventName Type { get; set; }

		// Token: 0x06028D9C RID: 167324 RVA: 0x0059D4AB File Offset: 0x0059B6AB
		public IBvbBurnBuffTimeUpDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
