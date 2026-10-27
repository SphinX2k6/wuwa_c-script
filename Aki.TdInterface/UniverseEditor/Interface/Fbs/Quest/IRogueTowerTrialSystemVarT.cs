using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B9 RID: 16569
	public class IRogueTowerTrialSystemVarT
	{
		// Token: 0x170074EF RID: 29935
		// (get) Token: 0x06018244 RID: 98884 RVA: 0x0037AE13 File Offset: 0x00379013
		// (set) Token: 0x06018245 RID: 98885 RVA: 0x0037AE1B File Offset: 0x0037901B
		public ERogueTowerTrialSystemVarType VarType { get; set; }

		// Token: 0x170074F0 RID: 29936
		// (get) Token: 0x06018246 RID: 98886 RVA: 0x0037AE24 File Offset: 0x00379024
		// (set) Token: 0x06018247 RID: 98887 RVA: 0x0037AE2C File Offset: 0x0037902C
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06018248 RID: 98888 RVA: 0x0037AE35 File Offset: 0x00379035
		public IRogueTowerTrialSystemVarT()
		{
			this.VarType = ERogueTowerTrialSystemVarType.KillBoss1;
			this.VarRef = null;
		}
	}
}
