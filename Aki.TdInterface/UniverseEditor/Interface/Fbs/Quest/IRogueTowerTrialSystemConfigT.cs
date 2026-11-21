using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F7 RID: 17655
	public class IRogueTowerTrialSystemConfigT
	{
		// Token: 0x17007AF0 RID: 31472
		// (get) Token: 0x060198C8 RID: 104648 RVA: 0x003A48E7 File Offset: 0x003A2AE7
		// (set) Token: 0x060198C9 RID: 104649 RVA: 0x003A48EF File Offset: 0x003A2AEF
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007AF1 RID: 31473
		// (get) Token: 0x060198CA RID: 104650 RVA: 0x003A48F8 File Offset: 0x003A2AF8
		// (set) Token: 0x060198CB RID: 104651 RVA: 0x003A4900 File Offset: 0x003A2B00
		public List<IRogueTowerTrialSystemVarT> Vars { get; set; }

		// Token: 0x060198CC RID: 104652 RVA: 0x003A4909 File Offset: 0x003A2B09
		public IRogueTowerTrialSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
