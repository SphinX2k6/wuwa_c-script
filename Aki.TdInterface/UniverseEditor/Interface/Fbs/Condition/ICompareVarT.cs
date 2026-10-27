using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BCC RID: 19404
	public class ICompareVarT
	{
		// Token: 0x17008CF1 RID: 36081
		// (get) Token: 0x0601EA13 RID: 125459 RVA: 0x00448A87 File Offset: 0x00446C87
		// (set) Token: 0x0601EA14 RID: 125460 RVA: 0x00448A8F File Offset: 0x00446C8F
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008CF2 RID: 36082
		// (get) Token: 0x0601EA15 RID: 125461 RVA: 0x00448A98 File Offset: 0x00446C98
		// (set) Token: 0x0601EA16 RID: 125462 RVA: 0x00448AA0 File Offset: 0x00446CA0
		public ECompare Compare { get; set; }

		// Token: 0x17008CF3 RID: 36083
		// (get) Token: 0x0601EA17 RID: 125463 RVA: 0x00448AA9 File Offset: 0x00446CA9
		// (set) Token: 0x0601EA18 RID: 125464 RVA: 0x00448AB1 File Offset: 0x00446CB1
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17008CF4 RID: 36084
		// (get) Token: 0x0601EA19 RID: 125465 RVA: 0x00448ABA File Offset: 0x00446CBA
		// (set) Token: 0x0601EA1A RID: 125466 RVA: 0x00448AC2 File Offset: 0x00446CC2
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x0601EA1B RID: 125467 RVA: 0x00448ACB File Offset: 0x00446CCB
		public ICompareVarT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Var1 = null;
			this.Var2 = null;
		}
	}
}
