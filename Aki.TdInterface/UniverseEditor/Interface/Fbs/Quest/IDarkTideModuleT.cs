using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F7 RID: 16887
	public class IDarkTideModuleT
	{
		// Token: 0x17007300 RID: 29440
		// (get) Token: 0x06017702 RID: 96002 RVA: 0x0035933E File Offset: 0x0035753E
		// (set) Token: 0x06017703 RID: 96003 RVA: 0x00359346 File Offset: 0x00357546
		public EDarkTideModuleType Type { get; set; }

		// Token: 0x06017704 RID: 96004 RVA: 0x0035934F File Offset: 0x0035754F
		public IDarkTideModuleT()
		{
			this.Type = EDarkTideModuleType.BossEvent;
		}
	}
}
