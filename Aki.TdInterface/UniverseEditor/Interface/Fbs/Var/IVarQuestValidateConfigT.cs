using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B15 RID: 15125
	public class IVarQuestValidateConfigT
	{
		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x06014A59 RID: 84569 RVA: 0x0030150E File Offset: 0x002FF70E
		// (set) Token: 0x06014A5A RID: 84570 RVA: 0x00301516 File Offset: 0x002FF716
		public EVar Type { get; set; }

		// Token: 0x06014A5B RID: 84571 RVA: 0x0030151F File Offset: 0x002FF71F
		public IVarQuestValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
