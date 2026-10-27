using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA7 RID: 15783
	public class ICompareVarInChildQuestT
	{
		// Token: 0x17006C98 RID: 27800
		// (get) Token: 0x06015F24 RID: 89892 RVA: 0x0032B64D File Offset: 0x0032984D
		// (set) Token: 0x06015F25 RID: 89893 RVA: 0x0032B655 File Offset: 0x00329855
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17006C99 RID: 27801
		// (get) Token: 0x06015F26 RID: 89894 RVA: 0x0032B65E File Offset: 0x0032985E
		// (set) Token: 0x06015F27 RID: 89895 RVA: 0x0032B666 File Offset: 0x00329866
		public ECompare Compare { get; set; }

		// Token: 0x17006C9A RID: 27802
		// (get) Token: 0x06015F28 RID: 89896 RVA: 0x0032B66F File Offset: 0x0032986F
		// (set) Token: 0x06015F29 RID: 89897 RVA: 0x0032B677 File Offset: 0x00329877
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x06015F2A RID: 89898 RVA: 0x0032B680 File Offset: 0x00329880
		public ICompareVarInChildQuestT()
		{
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
