using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F14 RID: 16148
	public class IVarQuestStateValidateConfigT
	{
		// Token: 0x17006D5D RID: 27997
		// (get) Token: 0x06015EF1 RID: 89841 RVA: 0x00327626 File Offset: 0x00325826
		// (set) Token: 0x06015EF2 RID: 89842 RVA: 0x0032762E File Offset: 0x0032582E
		public EVar Type { get; set; }

		// Token: 0x06015EF3 RID: 89843 RVA: 0x00327637 File Offset: 0x00325837
		public IVarQuestStateValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
