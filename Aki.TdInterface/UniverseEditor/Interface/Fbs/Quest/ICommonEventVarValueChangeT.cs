using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AF RID: 16815
	public class ICommonEventVarValueChangeT
	{
		// Token: 0x1700722C RID: 29228
		// (get) Token: 0x060173AB RID: 95147 RVA: 0x00350D7B File Offset: 0x0034EF7B
		// (set) Token: 0x060173AC RID: 95148 RVA: 0x00350D83 File Offset: 0x0034EF83
		public ECommonEventType Type { get; set; }

		// Token: 0x1700722D RID: 29229
		// (get) Token: 0x060173AD RID: 95149 RVA: 0x00350D8C File Offset: 0x0034EF8C
		// (set) Token: 0x060173AE RID: 95150 RVA: 0x00350D94 File Offset: 0x0034EF94
		public TVarRefUnion Var { get; set; }

		// Token: 0x060173AF RID: 95151 RVA: 0x00350D9D File Offset: 0x0034EF9D
		public ICommonEventVarValueChangeT()
		{
			this.Type = ECommonEventType.VarValueChange;
			this.Var = null;
		}
	}
}
