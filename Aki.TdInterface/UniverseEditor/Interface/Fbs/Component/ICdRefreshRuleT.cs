using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A3 RID: 21667
	public class ICdRefreshRuleT
	{
		// Token: 0x17009A79 RID: 39545
		// (get) Token: 0x060221E5 RID: 139749 RVA: 0x004B4118 File Offset: 0x004B2318
		// (set) Token: 0x060221E6 RID: 139750 RVA: 0x004B4120 File Offset: 0x004B2320
		public ERefreshRule Type { get; set; }

		// Token: 0x17009A7A RID: 39546
		// (get) Token: 0x060221E7 RID: 139751 RVA: 0x004B4129 File Offset: 0x004B2329
		// (set) Token: 0x060221E8 RID: 139752 RVA: 0x004B4131 File Offset: 0x004B2331
		public int Cd { get; set; }

		// Token: 0x060221E9 RID: 139753 RVA: 0x004B413A File Offset: 0x004B233A
		public ICdRefreshRuleT()
		{
			this.Type = ERefreshRule.CD;
			this.Cd = 0;
		}
	}
}
