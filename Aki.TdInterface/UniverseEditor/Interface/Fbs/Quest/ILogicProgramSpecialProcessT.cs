using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F15 RID: 16149
	public class ILogicProgramSpecialProcessT
	{
		// Token: 0x17007054 RID: 28756
		// (get) Token: 0x06016ED6 RID: 93910 RVA: 0x0034F1F1 File Offset: 0x0034D3F1
		// (set) Token: 0x06016ED7 RID: 93911 RVA: 0x0034F1F9 File Offset: 0x0034D3F9
		public List<IDisableUroT> SpecialProcessList { get; set; }

		// Token: 0x06016ED8 RID: 93912 RVA: 0x0034F202 File Offset: 0x0034D402
		public ILogicProgramSpecialProcessT()
		{
			this.SpecialProcessList = null;
		}
	}
}
