using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2F RID: 23855
	public class IBvbAiGetBestDeployDataT
	{
		// Token: 0x1700B2CF RID: 45775
		// (get) Token: 0x06028C8D RID: 167053 RVA: 0x0059A615 File Offset: 0x00598815
		// (set) Token: 0x06028C8E RID: 167054 RVA: 0x0059A61D File Offset: 0x0059881D
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2D0 RID: 45776
		// (get) Token: 0x06028C8F RID: 167055 RVA: 0x0059A626 File Offset: 0x00598826
		// (set) Token: 0x06028C90 RID: 167056 RVA: 0x0059A62E File Offset: 0x0059882E
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700B2D1 RID: 45777
		// (get) Token: 0x06028C91 RID: 167057 RVA: 0x0059A637 File Offset: 0x00598837
		// (set) Token: 0x06028C92 RID: 167058 RVA: 0x0059A63F File Offset: 0x0059883F
		public TVarRefUnion BoardPosStored { get; set; }

		// Token: 0x06028C93 RID: 167059 RVA: 0x0059A648 File Offset: 0x00598848
		public IBvbAiGetBestDeployDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardPosStored = null;
		}
	}
}
