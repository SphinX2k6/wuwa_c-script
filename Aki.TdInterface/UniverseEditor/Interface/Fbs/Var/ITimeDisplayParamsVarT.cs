using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF7 RID: 15095
	public class ITimeDisplayParamsVarT
	{
		// Token: 0x17006785 RID: 26501
		// (get) Token: 0x0601492D RID: 84269 RVA: 0x002FECCB File Offset: 0x002FCECB
		// (set) Token: 0x0601492E RID: 84270 RVA: 0x002FECD3 File Offset: 0x002FCED3
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x17006786 RID: 26502
		// (get) Token: 0x0601492F RID: 84271 RVA: 0x002FECDC File Offset: 0x002FCEDC
		// (set) Token: 0x06014930 RID: 84272 RVA: 0x002FECE4 File Offset: 0x002FCEE4
		public TVarRefUnion Var { get; set; }

		// Token: 0x06014931 RID: 84273 RVA: 0x002FECED File Offset: 0x002FCEED
		public ITimeDisplayParamsVarT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
			this.Var = null;
		}
	}
}
