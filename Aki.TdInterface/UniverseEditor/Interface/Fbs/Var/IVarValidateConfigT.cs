using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F23 RID: 16163
	public class IVarValidateConfigT
	{
		// Token: 0x17006D72 RID: 28018
		// (get) Token: 0x06015F5D RID: 89949 RVA: 0x00328052 File Offset: 0x00326252
		// (set) Token: 0x06015F5E RID: 89950 RVA: 0x0032805A File Offset: 0x0032625A
		public EVar Type { get; set; }

		// Token: 0x06015F5F RID: 89951 RVA: 0x00328063 File Offset: 0x00326263
		public IVarValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
