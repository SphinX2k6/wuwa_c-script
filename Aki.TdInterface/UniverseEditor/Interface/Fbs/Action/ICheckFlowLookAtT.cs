using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635C RID: 25436
	public class ICheckFlowLookAtT
	{
		// Token: 0x1700BDC8 RID: 48584
		// (get) Token: 0x0602C013 RID: 180243 RVA: 0x0060C047 File Offset: 0x0060A247
		// (set) Token: 0x0602C014 RID: 180244 RVA: 0x0060C04F File Offset: 0x0060A24F
		public EOverrideLookAtType Type { get; set; }

		// Token: 0x1700BDC9 RID: 48585
		// (get) Token: 0x0602C015 RID: 180245 RVA: 0x0060C058 File Offset: 0x0060A258
		// (set) Token: 0x0602C016 RID: 180246 RVA: 0x0060C060 File Offset: 0x0060A260
		public List<ICheckFlowLookAtConfigT> CheckFlowLookAtConfigs { get; set; }

		// Token: 0x0602C017 RID: 180247 RVA: 0x0060C069 File Offset: 0x0060A269
		public ICheckFlowLookAtT()
		{
			this.Type = EOverrideLookAtType.CheckFlowLookAt;
			this.CheckFlowLookAtConfigs = null;
		}
	}
}
