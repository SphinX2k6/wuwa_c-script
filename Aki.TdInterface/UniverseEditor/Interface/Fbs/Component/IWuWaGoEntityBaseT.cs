using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA5 RID: 23461
	public class IWuWaGoEntityBaseT
	{
		// Token: 0x1700B14B RID: 45387
		// (get) Token: 0x060282C7 RID: 164551 RVA: 0x0058562E File Offset: 0x0058382E
		// (set) Token: 0x060282C8 RID: 164552 RVA: 0x00585636 File Offset: 0x00583836
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x060282C9 RID: 164553 RVA: 0x0058563F File Offset: 0x0058383F
		public IWuWaGoEntityBaseT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
		}
	}
}
