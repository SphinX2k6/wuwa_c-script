using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200782B RID: 30763
	public class ISetRegionConfigT
	{
		// Token: 0x1700E1BA RID: 57786
		// (get) Token: 0x060361A5 RID: 221605 RVA: 0x0073FB42 File Offset: 0x0073DD42
		// (set) Token: 0x060361A6 RID: 221606 RVA: 0x0073FB4A File Offset: 0x0073DD4A
		public ERegionConfigType Type { get; set; }

		// Token: 0x060361A7 RID: 221607 RVA: 0x0073FB53 File Offset: 0x0073DD53
		public ISetRegionConfigT()
		{
			this.Type = ERegionConfigType.Mpc;
		}
	}
}
