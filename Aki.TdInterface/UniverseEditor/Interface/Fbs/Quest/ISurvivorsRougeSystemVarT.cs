using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B4 RID: 17844
	public class ISurvivorsRougeSystemVarT
	{
		// Token: 0x17007CB5 RID: 31925
		// (get) Token: 0x0601A089 RID: 106633 RVA: 0x003B5DAF File Offset: 0x003B3FAF
		// (set) Token: 0x0601A08A RID: 106634 RVA: 0x003B5DB7 File Offset: 0x003B3FB7
		public ESurvivorsRougeSystemVarType VarType { get; set; }

		// Token: 0x17007CB6 RID: 31926
		// (get) Token: 0x0601A08B RID: 106635 RVA: 0x003B5DC0 File Offset: 0x003B3FC0
		// (set) Token: 0x0601A08C RID: 106636 RVA: 0x003B5DC8 File Offset: 0x003B3FC8
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0601A08D RID: 106637 RVA: 0x003B5DD1 File Offset: 0x003B3FD1
		public ISurvivorsRougeSystemVarT()
		{
			this.VarType = ESurvivorsRougeSystemVarType.Gold;
			this.VarRef = null;
		}
	}
}
