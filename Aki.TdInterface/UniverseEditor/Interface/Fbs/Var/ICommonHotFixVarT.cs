using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A8E RID: 14990
	public class ICommonHotFixVarT
	{
		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x06014557 RID: 83287 RVA: 0x002F77C0 File Offset: 0x002F59C0
		// (set) Token: 0x06014558 RID: 83288 RVA: 0x002F77C8 File Offset: 0x002F59C8
		public ESystemVarName Type { get; set; }

		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x06014559 RID: 83289 RVA: 0x002F77D1 File Offset: 0x002F59D1
		// (set) Token: 0x0601455A RID: 83290 RVA: 0x002F77D9 File Offset: 0x002F59D9
		public string VarName { get; set; }

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x0601455B RID: 83291 RVA: 0x002F77E2 File Offset: 0x002F59E2
		// (set) Token: 0x0601455C RID: 83292 RVA: 0x002F77EA File Offset: 0x002F59EA
		public string VarParams { get; set; }

		// Token: 0x0601455D RID: 83293 RVA: 0x002F77F3 File Offset: 0x002F59F3
		public ICommonHotFixVarT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}
