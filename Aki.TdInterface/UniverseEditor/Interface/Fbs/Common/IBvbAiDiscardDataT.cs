using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D26 RID: 23846
	public class IBvbAiDiscardDataT
	{
		// Token: 0x1700B2BA RID: 45754
		// (get) Token: 0x06028C1F RID: 166943 RVA: 0x005992DD File Offset: 0x005974DD
		// (set) Token: 0x06028C20 RID: 166944 RVA: 0x005992E5 File Offset: 0x005974E5
		public EBvbEventName Type { get; set; }

		// Token: 0x1700B2BB RID: 45755
		// (get) Token: 0x06028C21 RID: 166945 RVA: 0x005992EE File Offset: 0x005974EE
		// (set) Token: 0x06028C22 RID: 166946 RVA: 0x005992F6 File Offset: 0x005974F6
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x1700B2BC RID: 45756
		// (get) Token: 0x06028C23 RID: 166947 RVA: 0x005992FF File Offset: 0x005974FF
		// (set) Token: 0x06028C24 RID: 166948 RVA: 0x00599307 File Offset: 0x00597507
		public EDiscardStrategy Strategy { get; set; }

		// Token: 0x06028C25 RID: 166949 RVA: 0x00599310 File Offset: 0x00597510
		public IBvbAiDiscardDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
			this.ReserveHandCard = null;
			this.Strategy = EDiscardStrategy.LowestScore;
		}
	}
}
