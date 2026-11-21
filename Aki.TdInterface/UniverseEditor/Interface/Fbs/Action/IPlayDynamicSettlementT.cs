using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007457 RID: 29783
	public class IPlayDynamicSettlementT
	{
		// Token: 0x1700DAE3 RID: 56035
		// (get) Token: 0x06034240 RID: 213568 RVA: 0x007067DD File Offset: 0x007049DD
		// (set) Token: 0x06034241 RID: 213569 RVA: 0x007067E5 File Offset: 0x007049E5
		public TDynamicSettlementConfigUnion DynamicSettlementConfig { get; set; }

		// Token: 0x06034242 RID: 213570 RVA: 0x007067EE File Offset: 0x007049EE
		public IPlayDynamicSettlementT()
		{
			this.DynamicSettlementConfig = null;
		}
	}
}
