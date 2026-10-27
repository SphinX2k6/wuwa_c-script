using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B6 RID: 16566
	public class IRogueTowerTrialSystemConfigT
	{
		// Token: 0x170074EA RID: 29930
		// (get) Token: 0x06018227 RID: 98855 RVA: 0x0037A997 File Offset: 0x00378B97
		// (set) Token: 0x06018228 RID: 98856 RVA: 0x0037A99F File Offset: 0x00378B9F
		public EEnableSystemType Type { get; set; }

		// Token: 0x170074EB RID: 29931
		// (get) Token: 0x06018229 RID: 98857 RVA: 0x0037A9A8 File Offset: 0x00378BA8
		// (set) Token: 0x0601822A RID: 98858 RVA: 0x0037A9B0 File Offset: 0x00378BB0
		public List<IRogueTowerTrialSystemVarT> Vars { get; set; }

		// Token: 0x0601822B RID: 98859 RVA: 0x0037A9B9 File Offset: 0x00378BB9
		public IRogueTowerTrialSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
