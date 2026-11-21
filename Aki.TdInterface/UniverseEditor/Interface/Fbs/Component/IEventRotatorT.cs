using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572E RID: 22318
	public class IEventRotatorT
	{
		// Token: 0x1700A128 RID: 41256
		// (get) Token: 0x06023E78 RID: 147064 RVA: 0x004EFA16 File Offset: 0x004EDC16
		// (set) Token: 0x06023E79 RID: 147065 RVA: 0x004EFA1E File Offset: 0x004EDC1E
		public List<IActionInfoT> StartActions { get; set; }

		// Token: 0x1700A129 RID: 41257
		// (get) Token: 0x06023E7A RID: 147066 RVA: 0x004EFA27 File Offset: 0x004EDC27
		// (set) Token: 0x06023E7B RID: 147067 RVA: 0x004EFA2F File Offset: 0x004EDC2F
		public List<IActionInfoT> EndActions { get; set; }

		// Token: 0x06023E7C RID: 147068 RVA: 0x004EFA38 File Offset: 0x004EDC38
		public IEventRotatorT()
		{
			this.StartActions = null;
			this.EndActions = null;
		}
	}
}
