using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD3 RID: 15059
	public class ISystemVarBaseT
	{
		// Token: 0x1700674E RID: 26446
		// (get) Token: 0x060147D3 RID: 83923 RVA: 0x002FC016 File Offset: 0x002FA216
		// (set) Token: 0x060147D4 RID: 83924 RVA: 0x002FC01E File Offset: 0x002FA21E
		public ESystemVarName Type { get; set; }

		// Token: 0x060147D5 RID: 83925 RVA: 0x002FC027 File Offset: 0x002FA227
		public ISystemVarBaseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
