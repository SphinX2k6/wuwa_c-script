using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B30 RID: 15152
	public class IWoodenBoxProliferatePositionListT
	{
		// Token: 0x170067FC RID: 26620
		// (get) Token: 0x06014B53 RID: 84819 RVA: 0x00303103 File Offset: 0x00301303
		// (set) Token: 0x06014B54 RID: 84820 RVA: 0x0030310B File Offset: 0x0030130B
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x170067FD RID: 26621
		// (get) Token: 0x06014B55 RID: 84821 RVA: 0x00303114 File Offset: 0x00301314
		// (set) Token: 0x06014B56 RID: 84822 RVA: 0x0030311C File Offset: 0x0030131C
		public List<IVectorInfoT> Positions { get; set; }

		// Token: 0x06014B57 RID: 84823 RVA: 0x00303125 File Offset: 0x00301325
		public IWoodenBoxProliferatePositionListT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
			this.Positions = null;
		}
	}
}
