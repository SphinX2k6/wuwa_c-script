using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006354 RID: 25428
	public class IBvbAiBattleWinDataT
	{
		// Token: 0x1700BC0A RID: 48138
		// (get) Token: 0x0602B227 RID: 176679 RVA: 0x005E0C6E File Offset: 0x005DEE6E
		// (set) Token: 0x0602B228 RID: 176680 RVA: 0x005E0C76 File Offset: 0x005DEE76
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B229 RID: 176681 RVA: 0x005E0C7F File Offset: 0x005DEE7F
		public IBvbAiBattleWinDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
