using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538F RID: 21391
	public class IAiGearStrategyComponentT
	{
		// Token: 0x17009732 RID: 38706
		// (get) Token: 0x060215C5 RID: 136645 RVA: 0x0049A961 File Offset: 0x00498B61
		// (set) Token: 0x060215C6 RID: 136646 RVA: 0x0049A969 File Offset: 0x00498B69
		public bool Disabled { get; set; }

		// Token: 0x17009733 RID: 38707
		// (get) Token: 0x060215C7 RID: 136647 RVA: 0x0049A972 File Offset: 0x00498B72
		// (set) Token: 0x060215C8 RID: 136648 RVA: 0x0049A97A File Offset: 0x00498B7A
		public TAiGearStrategyUnion StrategyType { get; set; }

		// Token: 0x17009734 RID: 38708
		// (get) Token: 0x060215C9 RID: 136649 RVA: 0x0049A983 File Offset: 0x00498B83
		// (set) Token: 0x060215CA RID: 136650 RVA: 0x0049A98B File Offset: 0x00498B8B
		public byte NullMask { get; set; }

		// Token: 0x060215CB RID: 136651 RVA: 0x0049A994 File Offset: 0x00498B94
		public IAiGearStrategyComponentT()
		{
			this.Disabled = false;
			this.StrategyType = null;
			this.NullMask = 0;
		}
	}
}
