using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050BC RID: 20668
	public class ICompareVarConditionT
	{
		// Token: 0x1700941E RID: 37918
		// (get) Token: 0x0602060D RID: 132621 RVA: 0x0047C1CF File Offset: 0x0047A3CF
		// (set) Token: 0x0602060E RID: 132622 RVA: 0x0047C1D7 File Offset: 0x0047A3D7
		public ECondition Type { get; set; }

		// Token: 0x1700941F RID: 37919
		// (get) Token: 0x0602060F RID: 132623 RVA: 0x0047C1E0 File Offset: 0x0047A3E0
		// (set) Token: 0x06020610 RID: 132624 RVA: 0x0047C1E8 File Offset: 0x0047A3E8
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17009420 RID: 37920
		// (get) Token: 0x06020611 RID: 132625 RVA: 0x0047C1F1 File Offset: 0x0047A3F1
		// (set) Token: 0x06020612 RID: 132626 RVA: 0x0047C1F9 File Offset: 0x0047A3F9
		public ECompare Compare { get; set; }

		// Token: 0x17009421 RID: 37921
		// (get) Token: 0x06020613 RID: 132627 RVA: 0x0047C202 File Offset: 0x0047A402
		// (set) Token: 0x06020614 RID: 132628 RVA: 0x0047C20A File Offset: 0x0047A40A
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x06020615 RID: 132629 RVA: 0x0047C213 File Offset: 0x0047A413
		public ICompareVarConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
