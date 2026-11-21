using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F20 RID: 16160
	public class IVarTransformValidateConfigT
	{
		// Token: 0x17006D6F RID: 28015
		// (get) Token: 0x06015F4B RID: 89931 RVA: 0x00327EDA File Offset: 0x003260DA
		// (set) Token: 0x06015F4C RID: 89932 RVA: 0x00327EE2 File Offset: 0x003260E2
		public EVar Type { get; set; }

		// Token: 0x06015F4D RID: 89933 RVA: 0x00327EEB File Offset: 0x003260EB
		public IVarTransformValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
