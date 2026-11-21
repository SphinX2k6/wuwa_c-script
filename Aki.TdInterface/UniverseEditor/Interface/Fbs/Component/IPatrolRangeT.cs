using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D15 RID: 23829
	public class IPatrolRangeT
	{
		// Token: 0x1700AF08 RID: 44808
		// (get) Token: 0x06027934 RID: 162100 RVA: 0x00569DA3 File Offset: 0x00567FA3
		// (set) Token: 0x06027935 RID: 162101 RVA: 0x00569DAB File Offset: 0x00567FAB
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700AF09 RID: 44809
		// (get) Token: 0x06027936 RID: 162102 RVA: 0x00569DB4 File Offset: 0x00567FB4
		// (set) Token: 0x06027937 RID: 162103 RVA: 0x00569DBC File Offset: 0x00567FBC
		public int Radius { get; set; }

		// Token: 0x06027938 RID: 162104 RVA: 0x00569DC5 File Offset: 0x00567FC5
		public IPatrolRangeT()
		{
			this.Center = null;
			this.Radius = 0;
		}
	}
}
