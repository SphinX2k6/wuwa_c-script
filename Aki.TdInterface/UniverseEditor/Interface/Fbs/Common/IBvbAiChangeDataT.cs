using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D20 RID: 23840
	public class IBvbAiChangeDataT
	{
		// Token: 0x1700B2AD RID: 45741
		// (get) Token: 0x06028BD8 RID: 166872 RVA: 0x00598633 File Offset: 0x00596833
		// (set) Token: 0x06028BD9 RID: 166873 RVA: 0x0059863B File Offset: 0x0059683B
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2AE RID: 45742
		// (get) Token: 0x06028BDA RID: 166874 RVA: 0x00598644 File Offset: 0x00596844
		// (set) Token: 0x06028BDB RID: 166875 RVA: 0x0059864C File Offset: 0x0059684C
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x06028BDC RID: 166876 RVA: 0x00598655 File Offset: 0x00596855
		public IBvbAiChangeDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
		}
	}
}
