using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BCF RID: 19407
	public class ICompareVarConditionT
	{
		// Token: 0x17008CFA RID: 36090
		// (get) Token: 0x0601EA3F RID: 125503 RVA: 0x004492C3 File Offset: 0x004474C3
		// (set) Token: 0x0601EA40 RID: 125504 RVA: 0x004492CB File Offset: 0x004474CB
		public ECondition Type { get; set; }

		// Token: 0x17008CFB RID: 36091
		// (get) Token: 0x0601EA41 RID: 125505 RVA: 0x004492D4 File Offset: 0x004474D4
		// (set) Token: 0x0601EA42 RID: 125506 RVA: 0x004492DC File Offset: 0x004474DC
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17008CFC RID: 36092
		// (get) Token: 0x0601EA43 RID: 125507 RVA: 0x004492E5 File Offset: 0x004474E5
		// (set) Token: 0x0601EA44 RID: 125508 RVA: 0x004492ED File Offset: 0x004474ED
		public ECompare Compare { get; set; }

		// Token: 0x17008CFD RID: 36093
		// (get) Token: 0x0601EA45 RID: 125509 RVA: 0x004492F6 File Offset: 0x004474F6
		// (set) Token: 0x0601EA46 RID: 125510 RVA: 0x004492FE File Offset: 0x004474FE
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x0601EA47 RID: 125511 RVA: 0x00449307 File Offset: 0x00447507
		public ICompareVarConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
