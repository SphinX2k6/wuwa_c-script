using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE7 RID: 31975
	public class IVarContextT
	{
		// Token: 0x1700EF56 RID: 61270
		// (get) Token: 0x06039B18 RID: 236312 RVA: 0x007C88A2 File Offset: 0x007C6AA2
		// (set) Token: 0x06039B19 RID: 236313 RVA: 0x007C88AA File Offset: 0x007C6AAA
		public EVarContext Type { get; set; }

		// Token: 0x06039B1A RID: 236314 RVA: 0x007C88B3 File Offset: 0x007C6AB3
		public IVarContextT()
		{
			this.Type = EVarContext.None;
		}
	}
}
