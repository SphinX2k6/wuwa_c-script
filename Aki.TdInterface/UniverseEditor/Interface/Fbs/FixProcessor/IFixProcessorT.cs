using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004758 RID: 18264
	public class IFixProcessorT
	{
		// Token: 0x17008307 RID: 33543
		// (get) Token: 0x0601C1CB RID: 115147 RVA: 0x003FBAB1 File Offset: 0x003F9CB1
		// (set) Token: 0x0601C1CC RID: 115148 RVA: 0x003FBAB9 File Offset: 0x003F9CB9
		public List<IFixActionT> FixActions { get; set; }

		// Token: 0x0601C1CD RID: 115149 RVA: 0x003FBAC2 File Offset: 0x003F9CC2
		public IFixProcessorT()
		{
			this.FixActions = null;
		}
	}
}
