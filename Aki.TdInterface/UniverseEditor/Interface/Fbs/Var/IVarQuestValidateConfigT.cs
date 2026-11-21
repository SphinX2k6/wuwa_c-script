using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F17 RID: 16151
	public class IVarQuestValidateConfigT
	{
		// Token: 0x17006D60 RID: 28000
		// (get) Token: 0x06015F03 RID: 89859 RVA: 0x0032779E File Offset: 0x0032599E
		// (set) Token: 0x06015F04 RID: 89860 RVA: 0x003277A6 File Offset: 0x003259A6
		public EVar Type { get; set; }

		// Token: 0x06015F05 RID: 89861 RVA: 0x003277AF File Offset: 0x003259AF
		public IVarQuestValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
