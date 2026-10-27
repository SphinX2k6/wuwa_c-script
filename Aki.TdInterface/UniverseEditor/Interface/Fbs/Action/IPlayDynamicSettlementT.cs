using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE2 RID: 27874
	public class IPlayDynamicSettlementT
	{
		// Token: 0x1700CFA4 RID: 53156
		// (get) Token: 0x0603126C RID: 201324 RVA: 0x006AB56D File Offset: 0x006A976D
		// (set) Token: 0x0603126D RID: 201325 RVA: 0x006AB575 File Offset: 0x006A9775
		public TDynamicSettlementConfigUnion DynamicSettlementConfig { get; set; }

		// Token: 0x0603126E RID: 201326 RVA: 0x006AB57E File Offset: 0x006A977E
		public IPlayDynamicSettlementT()
		{
			this.DynamicSettlementConfig = null;
		}
	}
}
