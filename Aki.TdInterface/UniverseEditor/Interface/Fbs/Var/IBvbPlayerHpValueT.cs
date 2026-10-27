using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7F RID: 14975
	public class IBvbPlayerHpValueT
	{
		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x060144DD RID: 83165 RVA: 0x002F6B26 File Offset: 0x002F4D26
		// (set) Token: 0x060144DE RID: 83166 RVA: 0x002F6B2E File Offset: 0x002F4D2E
		public ESystemVarName Type { get; set; }

		// Token: 0x060144DF RID: 83167 RVA: 0x002F6B37 File Offset: 0x002F4D37
		public IBvbPlayerHpValueT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
