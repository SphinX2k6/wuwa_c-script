using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A76 RID: 14966
	public class IBvbNpcHpValueT
	{
		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x060144A7 RID: 83111 RVA: 0x002F66BE File Offset: 0x002F48BE
		// (set) Token: 0x060144A8 RID: 83112 RVA: 0x002F66C6 File Offset: 0x002F48C6
		public ESystemVarName Type { get; set; }

		// Token: 0x060144A9 RID: 83113 RVA: 0x002F66CF File Offset: 0x002F48CF
		public IBvbNpcHpValueT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
