using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F11 RID: 16145
	public class IVarPrefabValidateConfigT
	{
		// Token: 0x17006D5A RID: 27994
		// (get) Token: 0x06015EDF RID: 89823 RVA: 0x003274AE File Offset: 0x003256AE
		// (set) Token: 0x06015EE0 RID: 89824 RVA: 0x003274B6 File Offset: 0x003256B6
		public EVar Type { get; set; }

		// Token: 0x06015EE1 RID: 89825 RVA: 0x003274BF File Offset: 0x003256BF
		public IVarPrefabValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
