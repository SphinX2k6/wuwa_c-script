using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B12 RID: 15122
	public class IVarQuestStateValidateConfigT
	{
		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x06014A47 RID: 84551 RVA: 0x00301396 File Offset: 0x002FF596
		// (set) Token: 0x06014A48 RID: 84552 RVA: 0x0030139E File Offset: 0x002FF59E
		public EVar Type { get; set; }

		// Token: 0x06014A49 RID: 84553 RVA: 0x003013A7 File Offset: 0x002FF5A7
		public IVarQuestStateValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
