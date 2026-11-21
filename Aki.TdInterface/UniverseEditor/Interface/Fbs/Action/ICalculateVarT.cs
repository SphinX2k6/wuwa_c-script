using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DE RID: 26846
	public class ICalculateVarT
	{
		// Token: 0x1700C54D RID: 50509
		// (get) Token: 0x0602DF26 RID: 188198 RVA: 0x00647AEC File Offset: 0x00645CEC
		// (set) Token: 0x0602DF27 RID: 188199 RVA: 0x00647AF4 File Offset: 0x00645CF4
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x1700C54E RID: 50510
		// (get) Token: 0x0602DF28 RID: 188200 RVA: 0x00647AFD File Offset: 0x00645CFD
		// (set) Token: 0x0602DF29 RID: 188201 RVA: 0x00647B05 File Offset: 0x00645D05
		public string Op { get; set; }

		// Token: 0x1700C54F RID: 50511
		// (get) Token: 0x0602DF2A RID: 188202 RVA: 0x00647B0E File Offset: 0x00645D0E
		// (set) Token: 0x0602DF2B RID: 188203 RVA: 0x00647B16 File Offset: 0x00645D16
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x1700C550 RID: 50512
		// (get) Token: 0x0602DF2C RID: 188204 RVA: 0x00647B1F File Offset: 0x00645D1F
		// (set) Token: 0x0602DF2D RID: 188205 RVA: 0x00647B27 File Offset: 0x00645D27
		public TVarRefUnion Result { get; set; }

		// Token: 0x0602DF2E RID: 188206 RVA: 0x00647B30 File Offset: 0x00645D30
		public ICalculateVarT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
