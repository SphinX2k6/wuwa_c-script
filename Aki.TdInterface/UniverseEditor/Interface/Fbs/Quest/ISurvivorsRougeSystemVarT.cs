using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004170 RID: 16752
	public class ISurvivorsRougeSystemVarT
	{
		// Token: 0x170076A6 RID: 30374
		// (get) Token: 0x060189C1 RID: 100801 RVA: 0x0038B7F3 File Offset: 0x003899F3
		// (set) Token: 0x060189C2 RID: 100802 RVA: 0x0038B7FB File Offset: 0x003899FB
		public ESurvivorsRougeSystemVarType VarType { get; set; }

		// Token: 0x170076A7 RID: 30375
		// (get) Token: 0x060189C3 RID: 100803 RVA: 0x0038B804 File Offset: 0x00389A04
		// (set) Token: 0x060189C4 RID: 100804 RVA: 0x0038B80C File Offset: 0x00389A0C
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060189C5 RID: 100805 RVA: 0x0038B815 File Offset: 0x00389A15
		public ISurvivorsRougeSystemVarT()
		{
			this.VarType = ESurvivorsRougeSystemVarType.Gold;
			this.VarRef = null;
		}
	}
}
