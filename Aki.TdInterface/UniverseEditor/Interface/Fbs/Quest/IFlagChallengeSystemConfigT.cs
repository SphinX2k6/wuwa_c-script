using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004293 RID: 17043
	public class IFlagChallengeSystemConfigT
	{
		// Token: 0x17007492 RID: 29842
		// (get) Token: 0x06017D9E RID: 97694 RVA: 0x003683CF File Offset: 0x003665CF
		// (set) Token: 0x06017D9F RID: 97695 RVA: 0x003683D7 File Offset: 0x003665D7
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007493 RID: 29843
		// (get) Token: 0x06017DA0 RID: 97696 RVA: 0x003683E0 File Offset: 0x003665E0
		// (set) Token: 0x06017DA1 RID: 97697 RVA: 0x003683E8 File Offset: 0x003665E8
		public List<IFlagChallengeSystemVarT> Vars { get; set; }

		// Token: 0x06017DA2 RID: 97698 RVA: 0x003683F1 File Offset: 0x003665F1
		public IFlagChallengeSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.Vars = null;
		}
	}
}
