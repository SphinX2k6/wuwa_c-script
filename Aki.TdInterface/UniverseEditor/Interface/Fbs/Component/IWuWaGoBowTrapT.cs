using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B2 RID: 25010
	public class IWuWaGoBowTrapT
	{
		// Token: 0x1700BA82 RID: 47746
		// (get) Token: 0x0602A831 RID: 174129 RVA: 0x005CC44A File Offset: 0x005CA64A
		// (set) Token: 0x0602A832 RID: 174130 RVA: 0x005CC452 File Offset: 0x005CA652
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x0602A833 RID: 174131 RVA: 0x005CC45B File Offset: 0x005CA65B
		public IWuWaGoBowTrapT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
		}
	}
}
