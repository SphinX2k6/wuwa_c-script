using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EFF RID: 16127
	public class IVarBooleanValidateConfigT
	{
		// Token: 0x17006D26 RID: 27942
		// (get) Token: 0x06015DF9 RID: 89593 RVA: 0x00325276 File Offset: 0x00323476
		// (set) Token: 0x06015DFA RID: 89594 RVA: 0x0032527E File Offset: 0x0032347E
		public EVar Type { get; set; }

		// Token: 0x06015DFB RID: 89595 RVA: 0x00325287 File Offset: 0x00323487
		public IVarBooleanValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
