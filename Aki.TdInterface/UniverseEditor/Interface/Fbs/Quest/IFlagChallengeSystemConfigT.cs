using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E58 RID: 15960
	public class IFlagChallengeSystemConfigT
	{
		// Token: 0x17006EAE RID: 28334
		// (get) Token: 0x06016777 RID: 92023 RVA: 0x0033F89F File Offset: 0x0033DA9F
		// (set) Token: 0x06016778 RID: 92024 RVA: 0x0033F8A7 File Offset: 0x0033DAA7
		public EEnableSystemType Type { get; set; }

		// Token: 0x17006EAF RID: 28335
		// (get) Token: 0x06016779 RID: 92025 RVA: 0x0033F8B0 File Offset: 0x0033DAB0
		// (set) Token: 0x0601677A RID: 92026 RVA: 0x0033F8B8 File Offset: 0x0033DAB8
		public List<IFlagChallengeSystemVarT> Vars { get; set; }

		// Token: 0x0601677B RID: 92027 RVA: 0x0033F8C1 File Offset: 0x0033DAC1
		public IFlagChallengeSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
