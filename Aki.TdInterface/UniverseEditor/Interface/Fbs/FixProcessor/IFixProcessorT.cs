using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC0 RID: 19392
	public class IFixProcessorT
	{
		// Token: 0x17008948 RID: 35144
		// (get) Token: 0x0601D9A0 RID: 121248 RVA: 0x00427D4D File Offset: 0x00425F4D
		// (set) Token: 0x0601D9A1 RID: 121249 RVA: 0x00427D55 File Offset: 0x00425F55
		public List<IFixActionT> FixActions { get; set; }

		// Token: 0x0601D9A2 RID: 121250 RVA: 0x00427D5E File Offset: 0x00425F5E
		public IFixProcessorT()
		{
			this.FixActions = null;
		}
	}
}
