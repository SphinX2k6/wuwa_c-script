using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A6 RID: 24998
	public class IWoodenOxenAndFlowingHorsesPerformConfigT
	{
		// Token: 0x1700BA71 RID: 47729
		// (get) Token: 0x0602A7E1 RID: 174049 RVA: 0x005CBCFE File Offset: 0x005C9EFE
		// (set) Token: 0x0602A7E2 RID: 174050 RVA: 0x005CBD06 File Offset: 0x005C9F06
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700BA72 RID: 47730
		// (get) Token: 0x0602A7E3 RID: 174051 RVA: 0x005CBD0F File Offset: 0x005C9F0F
		// (set) Token: 0x0602A7E4 RID: 174052 RVA: 0x005CBD17 File Offset: 0x005C9F17
		public string Montage { get; set; }

		// Token: 0x1700BA73 RID: 47731
		// (get) Token: 0x0602A7E5 RID: 174053 RVA: 0x005CBD20 File Offset: 0x005C9F20
		// (set) Token: 0x0602A7E6 RID: 174054 RVA: 0x005CBD28 File Offset: 0x005C9F28
		public IVectorInfoT RelativeRot { get; set; }

		// Token: 0x0602A7E7 RID: 174055 RVA: 0x005CBD31 File Offset: 0x005C9F31
		public IWoodenOxenAndFlowingHorsesPerformConfigT()
		{
			this.Offset = null;
			this.Montage = null;
			this.RelativeRot = null;
		}
	}
}
