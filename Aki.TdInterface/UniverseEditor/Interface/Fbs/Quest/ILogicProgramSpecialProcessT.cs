using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004353 RID: 17235
	public class ILogicProgramSpecialProcessT
	{
		// Token: 0x17007643 RID: 30275
		// (get) Token: 0x0601852E RID: 99630 RVA: 0x00378419 File Offset: 0x00376619
		// (set) Token: 0x0601852F RID: 99631 RVA: 0x00378421 File Offset: 0x00376621
		public List<IDisableUroT> SpecialProcessList { get; set; }

		// Token: 0x06018530 RID: 99632 RVA: 0x0037842A File Offset: 0x0037662A
		public ILogicProgramSpecialProcessT()
		{
			this.SpecialProcessList = null;
		}
	}
}
