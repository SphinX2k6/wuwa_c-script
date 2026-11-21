using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562F RID: 22063
	public class IDurabilityStateConfigT
	{
		// Token: 0x17009E6F RID: 40559
		// (get) Token: 0x060233A9 RID: 144297 RVA: 0x004D91CD File Offset: 0x004D73CD
		// (set) Token: 0x060233AA RID: 144298 RVA: 0x004D91D5 File Offset: 0x004D73D5
		public bool NonDestructable { get; set; }

		// Token: 0x17009E70 RID: 40560
		// (get) Token: 0x060233AB RID: 144299 RVA: 0x004D91DE File Offset: 0x004D73DE
		// (set) Token: 0x060233AC RID: 144300 RVA: 0x004D91E6 File Offset: 0x004D73E6
		public List<IDurabilityStateT> DurabilityStates { get; set; }

		// Token: 0x17009E71 RID: 40561
		// (get) Token: 0x060233AD RID: 144301 RVA: 0x004D91EF File Offset: 0x004D73EF
		// (set) Token: 0x060233AE RID: 144302 RVA: 0x004D91F7 File Offset: 0x004D73F7
		public byte NullMask { get; set; }

		// Token: 0x060233AF RID: 144303 RVA: 0x004D9200 File Offset: 0x004D7400
		public IDurabilityStateConfigT()
		{
			this.NonDestructable = false;
			this.DurabilityStates = null;
			this.NullMask = 0;
		}
	}
}
