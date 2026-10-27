using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ACA RID: 15050
	public class IScoreDisplayParamsVarT
	{
		// Token: 0x17006741 RID: 26433
		// (get) Token: 0x06014797 RID: 83863 RVA: 0x002FBA93 File Offset: 0x002F9C93
		// (set) Token: 0x06014798 RID: 83864 RVA: 0x002FBA9B File Offset: 0x002F9C9B
		public EScoreDisplayDataSource Type { get; set; }

		// Token: 0x17006742 RID: 26434
		// (get) Token: 0x06014799 RID: 83865 RVA: 0x002FBAA4 File Offset: 0x002F9CA4
		// (set) Token: 0x0601479A RID: 83866 RVA: 0x002FBAAC File Offset: 0x002F9CAC
		public TVarRefUnion Var { get; set; }

		// Token: 0x0601479B RID: 83867 RVA: 0x002FBAB5 File Offset: 0x002F9CB5
		public IScoreDisplayParamsVarT()
		{
			this.Type = EScoreDisplayDataSource.Var;
			this.Var = null;
		}
	}
}
