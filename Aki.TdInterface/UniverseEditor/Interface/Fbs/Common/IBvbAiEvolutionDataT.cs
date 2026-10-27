using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2C RID: 23852
	public class IBvbAiEvolutionDataT
	{
		// Token: 0x1700B2C8 RID: 45768
		// (get) Token: 0x06028C65 RID: 167013 RVA: 0x00599E69 File Offset: 0x00598069
		// (set) Token: 0x06028C66 RID: 167014 RVA: 0x00599E71 File Offset: 0x00598071
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2C9 RID: 45769
		// (get) Token: 0x06028C67 RID: 167015 RVA: 0x00599E7A File Offset: 0x0059807A
		// (set) Token: 0x06028C68 RID: 167016 RVA: 0x00599E82 File Offset: 0x00598082
		public TVarRefUnion HandCard { get; set; }

		// Token: 0x1700B2CA RID: 45770
		// (get) Token: 0x06028C69 RID: 167017 RVA: 0x00599E8B File Offset: 0x0059808B
		// (set) Token: 0x06028C6A RID: 167018 RVA: 0x00599E93 File Offset: 0x00598093
		public TVarRefUnion BoardCard { get; set; }

		// Token: 0x06028C6B RID: 167019 RVA: 0x00599E9C File Offset: 0x0059809C
		public IBvbAiEvolutionDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.HandCard = null;
			this.BoardCard = null;
		}
	}
}
