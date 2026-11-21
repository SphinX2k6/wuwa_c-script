using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CE RID: 30158
	public class IRemoveFlowInteractOptionT
	{
		// Token: 0x1700DDB2 RID: 56754
		// (get) Token: 0x06034E88 RID: 216712 RVA: 0x0071C335 File Offset: 0x0071A535
		// (set) Token: 0x06034E89 RID: 216713 RVA: 0x0071C33D File Offset: 0x0071A53D
		public IFlowIndexT Flow { get; set; }

		// Token: 0x1700DDB3 RID: 56755
		// (get) Token: 0x06034E8A RID: 216714 RVA: 0x0071C346 File Offset: 0x0071A546
		// (set) Token: 0x06034E8B RID: 216715 RVA: 0x0071C34E File Offset: 0x0071A54E
		public int EntityId { get; set; }

		// Token: 0x1700DDB4 RID: 56756
		// (get) Token: 0x06034E8C RID: 216716 RVA: 0x0071C357 File Offset: 0x0071A557
		// (set) Token: 0x06034E8D RID: 216717 RVA: 0x0071C35F File Offset: 0x0071A55F
		public string InteractToken { get; set; }

		// Token: 0x06034E8E RID: 216718 RVA: 0x0071C368 File Offset: 0x0071A568
		public IRemoveFlowInteractOptionT()
		{
			this.Flow = null;
			this.EntityId = 0;
			this.InteractToken = null;
		}
	}
}
