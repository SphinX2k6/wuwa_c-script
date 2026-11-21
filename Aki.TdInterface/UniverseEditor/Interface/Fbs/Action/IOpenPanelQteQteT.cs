using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737A RID: 29562
	public class IOpenPanelQteQteT
	{
		// Token: 0x1700D8E6 RID: 55526
		// (get) Token: 0x060339DF RID: 211423 RVA: 0x006F555C File Offset: 0x006F375C
		// (set) Token: 0x060339E0 RID: 211424 RVA: 0x006F5564 File Offset: 0x006F3764
		public EOpenQteType Type { get; set; }

		// Token: 0x1700D8E7 RID: 55527
		// (get) Token: 0x060339E1 RID: 211425 RVA: 0x006F556D File Offset: 0x006F376D
		// (set) Token: 0x060339E2 RID: 211426 RVA: 0x006F5575 File Offset: 0x006F3775
		public int Id { get; set; }

		// Token: 0x060339E3 RID: 211427 RVA: 0x006F557E File Offset: 0x006F377E
		public IOpenPanelQteQteT()
		{
			this.Type = EOpenQteType.PanelQte;
			this.Id = 0;
		}
	}
}
