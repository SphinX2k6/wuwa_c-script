using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E67 RID: 15975
	public class IFlipperSystemConfigT
	{
		// Token: 0x17006EC0 RID: 28352
		// (get) Token: 0x060167E0 RID: 92128 RVA: 0x003404C3 File Offset: 0x0033E6C3
		// (set) Token: 0x060167E1 RID: 92129 RVA: 0x003404CB File Offset: 0x0033E6CB
		public EEnableSystemType Type { get; set; }

		// Token: 0x17006EC1 RID: 28353
		// (get) Token: 0x060167E2 RID: 92130 RVA: 0x003404D4 File Offset: 0x0033E6D4
		// (set) Token: 0x060167E3 RID: 92131 RVA: 0x003404DC File Offset: 0x0033E6DC
		public List<IFlipperSystemVarT> Vars { get; set; }

		// Token: 0x060167E4 RID: 92132 RVA: 0x003404E5 File Offset: 0x0033E6E5
		public IFlipperSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
