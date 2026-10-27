using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4D RID: 23885
	public class IBvbEventDataT
	{
		// Token: 0x1700B305 RID: 45829
		// (get) Token: 0x06028DBE RID: 167358 RVA: 0x0059D78A File Offset: 0x0059B98A
		// (set) Token: 0x06028DBF RID: 167359 RVA: 0x0059D792 File Offset: 0x0059B992
		public EBvbEventName Type { get; set; }

		// Token: 0x06028DC0 RID: 167360 RVA: 0x0059D79B File Offset: 0x0059B99B
		public IBvbEventDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
