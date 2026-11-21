using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BCC RID: 19404
	public class ILevelPlayFixProcessorT
	{
		// Token: 0x1700895E RID: 35166
		// (get) Token: 0x0601DA08 RID: 121352 RVA: 0x00428A35 File Offset: 0x00426C35
		// (set) Token: 0x0601DA09 RID: 121353 RVA: 0x00428A3D File Offset: 0x00426C3D
		public List<IFixActionT> FixActions { get; set; }

		// Token: 0x0601DA0A RID: 121354 RVA: 0x00428A46 File Offset: 0x00426C46
		public ILevelPlayFixProcessorT()
		{
			this.FixActions = null;
		}
	}
}
