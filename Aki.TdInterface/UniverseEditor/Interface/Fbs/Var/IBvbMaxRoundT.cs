using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A67 RID: 14951
	public class IBvbMaxRoundT
	{
		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x0601444D RID: 83021 RVA: 0x002F5F66 File Offset: 0x002F4166
		// (set) Token: 0x0601444E RID: 83022 RVA: 0x002F5F6E File Offset: 0x002F416E
		public ESystemVarName Type { get; set; }

		// Token: 0x0601444F RID: 83023 RVA: 0x002F5F77 File Offset: 0x002F4177
		public IBvbMaxRoundT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
