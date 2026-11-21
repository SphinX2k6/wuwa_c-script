using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BA RID: 17082
	public class IGradingSystemConfigT
	{
		// Token: 0x170074E2 RID: 29922
		// (get) Token: 0x06017F06 RID: 98054 RVA: 0x0036B0AB File Offset: 0x003692AB
		// (set) Token: 0x06017F07 RID: 98055 RVA: 0x0036B0B3 File Offset: 0x003692B3
		public EEnableSystemType Type { get; set; }

		// Token: 0x170074E3 RID: 29923
		// (get) Token: 0x06017F08 RID: 98056 RVA: 0x0036B0BC File Offset: 0x003692BC
		// (set) Token: 0x06017F09 RID: 98057 RVA: 0x0036B0C4 File Offset: 0x003692C4
		public int GradingSystemId { get; set; }

		// Token: 0x170074E4 RID: 29924
		// (get) Token: 0x06017F0A RID: 98058 RVA: 0x0036B0CD File Offset: 0x003692CD
		// (set) Token: 0x06017F0B RID: 98059 RVA: 0x0036B0D5 File Offset: 0x003692D5
		public List<IGradingSystemVarT> Vars { get; set; }

		// Token: 0x170074E5 RID: 29925
		// (get) Token: 0x06017F0C RID: 98060 RVA: 0x0036B0DE File Offset: 0x003692DE
		// (set) Token: 0x06017F0D RID: 98061 RVA: 0x0036B0E6 File Offset: 0x003692E6
		public byte NullMask { get; set; }

		// Token: 0x06017F0E RID: 98062 RVA: 0x0036B0EF File Offset: 0x003692EF
		public IGradingSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.GradingSystemId = 0;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}
