using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA2 RID: 23458
	public class IWuWaGoEndGridT
	{
		// Token: 0x1700B147 RID: 45383
		// (get) Token: 0x060282B3 RID: 164531 RVA: 0x0058548C File Offset: 0x0058368C
		// (set) Token: 0x060282B4 RID: 164532 RVA: 0x00585494 File Offset: 0x00583694
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B148 RID: 45384
		// (get) Token: 0x060282B5 RID: 164533 RVA: 0x0058549D File Offset: 0x0058369D
		// (set) Token: 0x060282B6 RID: 164534 RVA: 0x005854A5 File Offset: 0x005836A5
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x060282B7 RID: 164535 RVA: 0x005854AE File Offset: 0x005836AE
		public IWuWaGoEndGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
		}
	}
}
