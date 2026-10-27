using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006478 RID: 25720
	public class ICommonCalculateVarT
	{
		// Token: 0x1700BF66 RID: 48998
		// (get) Token: 0x0602C8F6 RID: 182518 RVA: 0x0061E6D0 File Offset: 0x0061C8D0
		// (set) Token: 0x0602C8F7 RID: 182519 RVA: 0x0061E6D8 File Offset: 0x0061C8D8
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x1700BF67 RID: 48999
		// (get) Token: 0x0602C8F8 RID: 182520 RVA: 0x0061E6E1 File Offset: 0x0061C8E1
		// (set) Token: 0x0602C8F9 RID: 182521 RVA: 0x0061E6E9 File Offset: 0x0061C8E9
		public string Op { get; set; }

		// Token: 0x1700BF68 RID: 49000
		// (get) Token: 0x0602C8FA RID: 182522 RVA: 0x0061E6F2 File Offset: 0x0061C8F2
		// (set) Token: 0x0602C8FB RID: 182523 RVA: 0x0061E6FA File Offset: 0x0061C8FA
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x1700BF69 RID: 49001
		// (get) Token: 0x0602C8FC RID: 182524 RVA: 0x0061E703 File Offset: 0x0061C903
		// (set) Token: 0x0602C8FD RID: 182525 RVA: 0x0061E70B File Offset: 0x0061C90B
		public TVarRefUnion Result { get; set; }

		// Token: 0x0602C8FE RID: 182526 RVA: 0x0061E714 File Offset: 0x0061C914
		public ICommonCalculateVarT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
