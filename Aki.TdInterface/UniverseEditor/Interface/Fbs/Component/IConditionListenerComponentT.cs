using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF8 RID: 20472
	public class IConditionListenerComponentT
	{
		// Token: 0x17009451 RID: 37969
		// (get) Token: 0x06020B9F RID: 134047 RVA: 0x0048CF09 File Offset: 0x0048B109
		// (set) Token: 0x06020BA0 RID: 134048 RVA: 0x0048CF11 File Offset: 0x0048B111
		public bool Disabled { get; set; }

		// Token: 0x17009452 RID: 37970
		// (get) Token: 0x06020BA1 RID: 134049 RVA: 0x0048CF1A File Offset: 0x0048B11A
		// (set) Token: 0x06020BA2 RID: 134050 RVA: 0x0048CF22 File Offset: 0x0048B122
		public List<ICondtionListenerT> Listeners { get; set; }

		// Token: 0x17009453 RID: 37971
		// (get) Token: 0x06020BA3 RID: 134051 RVA: 0x0048CF2B File Offset: 0x0048B12B
		// (set) Token: 0x06020BA4 RID: 134052 RVA: 0x0048CF33 File Offset: 0x0048B133
		public byte NullMask { get; set; }

		// Token: 0x06020BA5 RID: 134053 RVA: 0x0048CF3C File Offset: 0x0048B13C
		public IConditionListenerComponentT()
		{
			this.Disabled = false;
			this.Listeners = null;
			this.NullMask = 0;
		}
	}
}
