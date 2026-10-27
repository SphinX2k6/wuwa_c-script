using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADC RID: 15068
	public class ISystemVarDefineT
	{
		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x06014849 RID: 84041 RVA: 0x002FCEAC File Offset: 0x002FB0AC
		// (set) Token: 0x0601484A RID: 84042 RVA: 0x002FCEB4 File Offset: 0x002FB0B4
		public string Name { get; set; }

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x0601484B RID: 84043 RVA: 0x002FCEBD File Offset: 0x002FB0BD
		// (set) Token: 0x0601484C RID: 84044 RVA: 0x002FCEC5 File Offset: 0x002FB0C5
		public string Type { get; set; }

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x0601484D RID: 84045 RVA: 0x002FCECE File Offset: 0x002FB0CE
		// (set) Token: 0x0601484E RID: 84046 RVA: 0x002FCED6 File Offset: 0x002FB0D6
		public ESystemModuleName ModuleName { get; set; }

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x0601484F RID: 84047 RVA: 0x002FCEDF File Offset: 0x002FB0DF
		// (set) Token: 0x06014850 RID: 84048 RVA: 0x002FCEE7 File Offset: 0x002FB0E7
		public string CnName { get; set; }

		// Token: 0x1700675F RID: 26463
		// (get) Token: 0x06014851 RID: 84049 RVA: 0x002FCEF0 File Offset: 0x002FB0F0
		// (set) Token: 0x06014852 RID: 84050 RVA: 0x002FCEF8 File Offset: 0x002FB0F8
		public bool Readonly { get; set; }

		// Token: 0x17006760 RID: 26464
		// (get) Token: 0x06014853 RID: 84051 RVA: 0x002FCF01 File Offset: 0x002FB101
		// (set) Token: 0x06014854 RID: 84052 RVA: 0x002FCF09 File Offset: 0x002FB109
		public bool HasArgs { get; set; }

		// Token: 0x06014855 RID: 84053 RVA: 0x002FCF12 File Offset: 0x002FB112
		public ISystemVarDefineT()
		{
			this.Name = null;
			this.Type = null;
			this.ModuleName = ESystemModuleName.Common;
			this.CnName = null;
			this.Readonly = false;
			this.HasArgs = false;
		}
	}
}
