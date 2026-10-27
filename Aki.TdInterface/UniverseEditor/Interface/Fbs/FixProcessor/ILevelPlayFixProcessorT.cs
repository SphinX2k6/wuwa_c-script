using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004764 RID: 18276
	public class ILevelPlayFixProcessorT
	{
		// Token: 0x1700831D RID: 33565
		// (get) Token: 0x0601C233 RID: 115251 RVA: 0x003FC799 File Offset: 0x003FA999
		// (set) Token: 0x0601C234 RID: 115252 RVA: 0x003FC7A1 File Offset: 0x003FA9A1
		public List<IFixActionT> FixActions { get; set; }

		// Token: 0x0601C235 RID: 115253 RVA: 0x003FC7AA File Offset: 0x003FA9AA
		public ILevelPlayFixProcessorT()
		{
			this.FixActions = null;
		}
	}
}
